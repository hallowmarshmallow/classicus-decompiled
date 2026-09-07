# API / hooks — every surface a harness can realistically touch

This folder is the API/hooks index for the Classic Us 2026.9.5 audit.
It is written for "what can a plugin, memory edit, or disassembler-driven
test actually reach", not for "what looks interesting in source".

Two ground rules for this game:

1. The managed source is useful for names, fields, and method signatures.
   It is NOT useful for full body logic in a lot of places, because
   cpp2IL strips method bodies. Where the decompiled file is a stub, the
   binary annotation is what matters, and I say so.
2. The interesting hookable surfaces are almost all either:
   - RPC send/recv paths
   - per-frame MonoBehaviour lifecycle methods
   - HTTP / staff-service clients compiled into the client
   - component UI entry points (which overlap with the UI folder)

---

## RPC send/recv surfaces

### Send side

Managed send surfaces:

- `InnerNetClient.StartRpc(uint targetNetId, byte callId, SendOption option)`
- `InnerNetClient.SendRpc(uint targetNetId, byte callId, SendOption option)`
- `PlayerControl.RpcSendChat(string chatText)`
- `PlayerControl.RpcBroadcastSystemAlert(string message)`
- `PlayerControl.RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType)`
- `PlayerControl.StartRoleRpc(int rpcId, int target = -1)`
- `PlayerControl.RpcMurderPlayer(...)`
- `PlayerControl.RpcSetPlayerScale(float scale)`
- `PlayerControl.RpcExile()`
- `PlayerControl.CmdCheckMurder(...)`
- `PlayerControl.CmdReportDeadBody(...)`
- `PlayerControl.RpcStartMeeting(...)`
- `PlayerControl.CmdCheckColor(byte bodyColor)`
- `PlayerControl.CmdCheckName(string name)`
- `StaffLobbyMusicBroadcast.PlayFromUrl(string url)`
- `StaffCustomSoundPlayer.PlayFromUrl(string url)` (and related audio send paths)

These are the managed send helpers. In IL2CPP land, the real wire writing
may be partially in the binary, but these are the managed entry points a
plugin or hook would normally target.

### Receive side

Managed receive surfaces:

- `PlayerControl.HandleRpc(byte callId, MessageReader reader)` — main switch,
  98 slots
- `RoleBehaviour.HandleRpc(MessageReader reader, int rpc)` — role-ability
  sub-channel from PlayerControl id 25
- `ShipHolder.HandleRpc` — forwards to active `ShipStatus`
- `ShipStatus.HandleRpc` — sabotage/doors/winners
- `BackroomShipStatus.HandleRpc` — maze regen
- `SubmergedStatus.HandleRpc` — elevator doors
- `MeetingHud.HandleRpc` — meeting close/vote/clear/complete
- `VoteBanSystem.HandleRpc` — vote-ban path
- `GameData.HandleRpc` — task-list path
- `LobbyBehaviour.HandleRpc` — lobby closecountdown path
- `CustomNetworkTransform.HandleRpc` — teleport/freeze
- `PlayerPhysics.HandleRpc` — vent/ladder
- `InnerNetServer.HandleMessage(Player client, MessageReader reader, SendOption sendOption)`
- `InnerNetClient.HandleMessage(MessageReader reader, SendOption sendOption)`
- `PlayerControl.HandleVoice(MessageReader reader)` — voice dispatch (RPC 29)

This is the full set of managed receive surfaces that matter. If you want
to intercept or modify "what the game does when a packet arrives", these are
the methods.

### Most important receive surface by exploit impact

If you only care about "where do the biggest exploits live", the priority
list is:

1. `PlayerControl.HandleRpc` — covers most of exploits 4-5, 8, 12, 13, 15,
   18, 20, 21, 22, 23, 24 plus the cosmetic/state spoofs
2. `InnerNetServer.HandleMessage` — covers exploits 2, 6, 7
3. `MeetingHud.HandleRpc` — exploit 9
4. `ShipHolder`/`ShipStatus` family — exploits 10, 11, 16, 17
5. `GameData.HandleRpc` — exploit 14
6. `LobbyBehaviour.HandleRpc` — exploit 13
7. `CustomNetworkTransform.HandleRpc` — exploit 12
8. `PlayerPhysics.HandleRpc` — exploits 15, 21
9. `RoleBehaviour.HandleRpc` via id 25 — unenumerated role abilities
10. `PlayerControl.HandleVoice` — voice RPC 29, fuzz candidate

### Relay / host-bridge surface

- `StaffTools.AmongUsGameBridge.RelayToHost(GameAction action, CommandContext ctx)`
- `StaffTools.AmongUsGameBridge.HandleStaffHostActionRelayRpc(MessageReader reader)`

This is the managed bridge for the RPC 97 relay path. The exploit is that
the receiver only checks `AmHost`, not staff/session. The bridge code is
where the relay packet is built and where the host-side handler reads it
back.

---

## Per-frame / lifecycle hook surfaces

MonoBehaviour per-frame methods are the easiest "run code every frame" hook
points if you are working from BepInEx/Harmony or from memory edits that can
call managed methods.

Big picture from the scan:

- ~402 managed files mention `Update`/`FixedUpdate`/`LateUpdate` or
  `StartCoroutine` or `Application.Quit` or settings/save flow.
- The interesting ones for a harness are the ones that are:
  - always alive during a session, or
  - alive in the specific state you care about (lobby, in-game, etc.), and
  - have real logic in the binary even if the decompiled source is a stub

Useful categories:

### Always-alive or near-always-alive candidates

- `StaffMenuController.Update` — runs as long as the staff console component
  exists; this is the F5 gate. Private in the interop surface, which matters
  if you are trying to Harmony-patch it.
- `AmongUsClient` — network client; alive during sessions.
- `GameData` — global state; alive during sessions.
- `RoleManager` — global role registry.
- `HudManager` — in-game HUD; alive during game.
- `MeetingHud` — meeting HUD; alive during meetings.
- `ChatController` — chat UI; alive when chat is relevant.

### Per-mode candidates

- `LobbyBehaviour` — lobby state; useful for lobby-phase hooks.
- `PlayerControl` — per-player; useful for player-specific hooks.
- `PlayerPhysics` — per-player physics; useful for vent/movement hooks.
- `ShipStatus` / map-specific status objects — in-game system state.
- `CustomNetworkTransform` — per-player network transform.
- `VoiceDebugGui`, `VoiceNetwork`, voice pipeline objects — voice flow.

### Lifecycle / quit / restart / settings

- `ApplicationRestarter`, `ExitGameButton`, `Application.Quit` path —
  quit/restart behavior.
- `SaveManager`, `PlayerPrefs` usage — persistent settings/storage.
- `OptionsMenuBehaviour`, `GameOptionsMenu`, `KeybindManager`, `ResolutionManager`,
  `FullScreenScaler`, `StaffSystemOptions` — settings flow.
- `SceneChanger` / scene load behavior — scene transitions.

If you want "a per-frame hook that is always alive and public enough to touch",
the best candidates are the global singletons and the UI managers; if you want
"per-player hooks", `PlayerControl`/`PlayerPhysics`/`CustomNetworkTransform` are
the obvious ones.

---

## HTTP / staff-service client surfaces

These are the managed clients compiled into the client:

- `StaffServices` — staff backend service layer
- `SessionManager` — session handling
- `StaffSystem` — staff system root
- `AmongUsGameBridge` — relay/bridge to host and to staff backend
- `AccountService` — player-account layer
- `Announcement` / `AnnoucementPopUpGithub` — announcement path
- `GithubReleaseChecker` / `InAppUpdater` — release/updater path
- `StaffLobbyMusicBroadcast`, `StaffCustomSoundPlayer` — staff audio send
- `CustomMusicPlayer` — player-provided custom music
- `FindAGameManager`, `RegionPingMenu`, `ServerTracker` — lobby discovery
- `GoogleTranslator` — translation service
- `ModsManager`, `ModButton` — mod UI/paths
- `RankStatsScreen` — stats screen

### What is hookable here

- Any HTTP call site: `UnityWebRequest` usage in `AmongUsGameBridge`,
  `StaffLobbyMusicBroadcast`, and the announcement/updater paths.
- Session/token handling: `SessionManager` and `StaffServices`.
- Staff backend path/config: the staff endpoint and localhost fallback are
  compiled in; the client has the endpoint logic even if some of it is binary.

### What is not automatically "any-player exploit"

Most of these are trust-domain or service paths, not in-lobby exploits:

- Announcement + updater are dev-controlled trust domains.
- Player-account layer is a player auth path, not a lobby exploit path.
- Staff backend behavior is only exploitable if the backend trusts the client
  too much; that is a live-server question, not a static one.

Still, these are the right surfaces if you want to ask "what does the client
send to the outside world, and can I intercept or spoof it".

---

## Il2CppInterop / BepInEx-relevant managed entry points

If you are running BepInEx IL2CPP / Il2CppInterop, the useful managed entry
points are the public/internal methods on the types above, plus the
MonoBehaviour lifecycle methods.

Practical notes:

- Public methods on `PlayerControl`, `AmongUsClient`, `GameData`, `RoleManager`,
  `ShipStatus`, `MeetingHud`, `LobbyBehaviour`, `CustomNetworkTransform`,
  `PlayerPhysics`, `ChatController`, `HudManager`, `StaffMenuController`,
  `PendingWarningPopup`, `VoiceDebugGui`, and the staff tools types are the
  normal interop targets.
- Private methods can still matter, but they may not be reachable through the
  interop surface depending on visibility. `StaffMenuController.Update` is the
  clearest example: it is the F5 gate, but it is private, so Harmony patching
  may need a different public per-frame anchor if you cannot reach `Update`
  directly.
- Static fields and singletons are useful. `GameData.Instance`, `RoleManager.Instance`,
  `AmongUsClient.Instance`, `StaffSystem` static helpers, `StaffMenuController.Instance`,
  `PendingWarningPopup` singleton are all the normal "global state" targets.

---

## How this maps to the exploit list

- RPC 97 relay → `AmongUsGameBridge.RelayToHost` + `HandleStaffHostActionRelayRpc`
- Type-11 kick / type-15 disconnect / type-2 start → `InnerNetServer.HandleMessage`
- Alert popup → `PlayerControl.RpcBroadcastSystemAlert` (send) +
  `ChatPopupController.ShowWarning` (UI)
- SYSTEM ALERT via `\x01` → `PlayerControl.HandleRpc` case 13
- Rich-text chat → send-side `CharacterValidator` bypass + `RpcSendChat`-adjacent
  send paths
- Meeting rig → `MeetingHud.HandleRpc`
- Winners / map swap / sabotage / maze / elevator → `ShipHolder` / `ShipStatus` /
  map-specific status handlers
- Teleport/freeze → `CustomNetworkTransform.HandleRpc`
- Task rewrite → `GameData.HandleRpc`
- Vent/ladder → `PlayerPhysics.HandleRpc`
- Role flip → `PlayerControl.HandleRpc` case 21 + `SetRole` path
- Murder bypass → `PlayerControl.HandleRpc` case 12 + `MurderPlayer`
- Banner/SFX → `PlayerControl.HandleRpc` case 92 + `StaffFx.Apply`
- Persistent warning → `PlayerControl.HandleRpc` case 93 + `PendingWarningStore.Add`
  + `PendingWarningPopup.OnGUI`
- Role abilities → `PlayerControl.HandleRpc` case 25 + `RoleBehaviour.HandleRpc`
- Voice → `PlayerControl.HandleVoice` + voice RPC set

---

## Open hook questions worth checking

1. Which per-frame methods are public enough to Harmony-patch reliably in the
   Il2CppInterop surface, and which are not. `StaffMenuController.Update` is the
   clearest example of "logic is here but visibility may block a direct patch".
2. Whether `HandleVoice` / voice RPC 29 is safe to hook without destabilizing
   the audio pipeline.
3. Whether the staff backend HTTP paths are reachable from the managed surface
   in a way you can intercept cleanly, or whether the relevant call sites are
   binary-only.
4. Whether any important send/recv path is implemented purely in the binary with
   no managed stub, which would move the harness target from C# methods to
   disassembly in `GameAssembly.so`.
