# Dispatch truth — source + binary merged

This is the working truth table for the dispatch/RPC surface in 2026.9.5.
It merges two sources:

1. **source signatures** from `decompiled_src_95/*.cs`
2. **binary annotations** from `classicus_exploits.txt` and the annotated dumps

Why merge them: the source tells you what types and methods exist. The binary
tells you what those methods actually do with the wire, because almost every
dispatch body in the 9.5 managed source is a stub.

Reality check from the scan:
- 1088 C# files in `decompiled_src_95`
- 9639 method signatures detected
- 564 stub methods detected across the whole source
- 81 stubs in dispatch-relevant files
- Only `Hazel/MessageReader.cs` and `InnerNet/MessageExtensions.cs` contain real
  non-trivial Read* wire parsing in source

So the managed source is the **surface catalog**, and the binary annotations are
the **behavior catalog**. Neither alone is enough.

---

## InnerNetObject hierarchy — the RPC-addressable net objects

These are the managed types that derive `InnerNetObject`. They are the objects
that RPCs are addressed to.

- `PlayerControl : InnerNetObject` — the big one
- `PlayerPhysics : InnerNetObject`
- `CustomNetworkTransform : InnerNetObject`
- `GameData : InnerNetObject, IDisconnectHandler`
- `LobbyBehaviour : InnerNetObject`
- `MeetingHud : InnerNetObject, IDisconnectHandler`
- `ShipHolder : InnerNetObject`
- `ShipStatus : InnerNetObject` (base; subclasses per map)
  - `SkeldStatus`
  - `MiraStatus`
  - `PolusShipStatus`
  - `BackroomShipStatus`
  - `SubmergedStatus`
  - `AirshipStatus`
  - `LevelImposter/LIShipStatus`
- `VoteBanSystem : InnerNetObject`
- `AmongUsClient : InnerNetClient` (not InnerNetObject, but still a network object)

Source reality:
- Almost every one of these has a stub `HandleRpc(byte callId, MessageReader reader)`.
- `ShipStatus.HandleRpc` itself is ALSO a stub in source. The map subclasses
  (`BackroomShipStatus`, `SubmergedStatus`, etc.) are also stubs or near-stubs.
- The only non-trivial helper signatures that survive in source for the dispatch
  objects are things like `RpcSetShip`, `RpcSetWinners`, `RpcRepairSystem`,
  `RpcCloseDoorsOfType`, `RpcEnterVent`, `RpcExitVent`, `RpcSnapTo`, `CastVote`,
  `SetTasks`, `SetRole`, `MurderPlayer`, `HandleVoice`, etc. The underlying
  `HandleRpc` cases that call these helpers are binary-only.

---

## PlayerControl.HandleRpc — the 98-slot switch

- Source: `public override void HandleRpc(byte callId, MessageReader reader)` at
  line 1300. Body is a stub.
- Binary annotation: 98 slots, 0..97, jump table at `0x6A0C2C` (from classicus_exploits.txt).
- Source also has the real helper signatures for many of the cases:
  - `RpcSendChat`, `RpcBroadcastSystemAlert`, `RpcSendChatNote`
  - `RpcStartGame`, `StartGame`
  - `RpcSetRole`, `SetRole`
  - `MurderPlayer`
  - `RpcMurderPlayer`
  - `CmdCheckMurder`, `CheckMurder`
  - `RpcEnterVent`, `RpcExitVent`, `CoEnterVent`, `CoExitVent`
  - `RpcSnapTo`, `SnapTo`
  - `SetTasks`, `RpcSetTasks`
  - `HandleVoice`
- Binary annotation: case 25 routes to `RoleBehaviour.HandleRpc(reader, rpc)` on
  the target player's role object, with no sender gate in the case block.

Source-stub vs binary-only:
- The helpers are real in source, but the dispatch wiring (which callId goes to
  which helper, with which arguments, with which gate) is binary-only.

---

## Other object dispatchers (source stubs, binary bodies)

All of these have stub `HandleRpc` bodies in source. The binary annotations
carry the real shapes:

- `ShipStatus.HandleRpc` — sabotage/doors/winners
  - helper signatures in source: `CloseDoorsOfType`, `RepairSystem`, `RpcCloseDoorsOfType`,
    `RpcRepairSystem`, `SetWinners`, `RpcSetWinners`, `StartShields`, `EndGameForSabotage`,
    `ClearCriticalSabotages`
  - binary: id 0 doors, id 1 repair/sabotage, id 2 winners
- `ShipHolder.HandleRpc` — forwards to active ShipStatus
  - source helpers: `SetShip`, `RpcSetShip`
  - binary: id 30 map swap
- `BackroomShipStatus.HandleRpc` — maze regen on top of ShipStatus
  - source helpers: `RpcSyncMaze`, `StartMaze`, `maze` field, `WaitForPlayer`,
    `AddSystems`, `CheckTaskCompletion`, `AddTasksFromList`
  - binary: id 3 maze rows/cols/seed/scale
- `SubmergedStatus.HandleRpc` — elevator doors on top of ShipStatus
  - source helpers: `SetElevDoorStatus`, `AllElevators`, `RunSubCutscene`, `GoToSpawnLocation`,
    `AddSystems`
  - binary: id 3 elevator status
- `MeetingHud.HandleRpc` — meeting close/vote/clear/complete
  - source helpers: `CastVote`, `CmdCastVote`, `VotingComplete`, `RpcVotingComplete`,
    `VoterState.Deserialize`
  - binary: id 0 close, id 1 cast vote, id 2 clear vote, id 3 voting complete
- `VoteBanSystem.HandleRpc` — vote-ban path
  - source: stub
  - binary: reads source+target from wire, tail-jumps to `AddVote`, no sender check
    (patched in 9.5)
- `GameData.HandleRpc` — task-list path
  - source helpers: `SetTasks`, `RpcSetTasks`
  - binary: id 29 SetTasks(playerId, taskTypeIds)
- `LobbyBehaviour.HandleRpc` — lobby closecountdown path
  - source: stub (plus real `Update`, `FixedUpdate`, `OnDestroy`)
  - binary: id 71 ForceStartCountdown
- `CustomNetworkTransform.HandleRpc` — teleport/freeze snap
  - source helpers: `SnapTo`, `RpcSnapTo`, `OwnerFixedUpdate`, `RemoteFixedUpdate`,
    `FixedUpdate`
  - binary: id 21 ReadVector2 + ReadUInt16 -> SnapTo
- `PlayerPhysics.HandleRpc` — vent/ladder
  - source helpers: `RpcEnterVent`, `RpcExitVent`, `CoEnterVent`, `CoExitVent`,
    `EnterVent`, `ExitVent`, `ExitVentScary`, `SetEnterVent`, `SetExitVent`
  - binary: id 0 enter vent, id 1 exit vent, id 2 climb ladder
- `InnerNetServer.HandleMessage` — wire-type dispatch on host
  - source helpers: `KickPlayer`, `DisconnectPlayer`, `StartGame`, `SendTo`, `Broadcast`,
    `BroadcastJoinMessage`, `JoinGame`, `HandleRejoin`, `HandleNewGameJoin`, `EndGame`,
    `ClientDisconnect`
  - binary: type 2 start, type 8 endgame (gated), type 11 kick (patched), type 15
    disconnect with reason (open)
- `InnerNetClient.HandleMessage` — client-side message dispatch
  - source helpers: `SendRpc`, `StartRpc`, `SendRpcImmediately`, `StartRpcImmediately`,
    `CoHandleSpawn`, `HandleGameDataInner`, `DeferMessage`, `KickPlayer`, `KickPlayerAnyway`,
    `SendStartGame`
  - binary: the real type dispatch is binary-only

---

## RoleRpc id 25 — the role-ability channel

- Source: `RoleBehaviour.HandleRpc(MessageReader reader, int rpc)` at line 243.
  Body is a stub.
- Source also gives you the full role-behaviour interface:
  - `CanVent`, `CanUseKillButton`, `CanSabotage`
  - `CheckMurder`, `CheckMurderAsTarget`, `CheckMurderGlobal`
  - `OnMurder`, `OnMurdered`, `OnEnterVent`, `OnExitVent`, `OnCoEnterVent`,
    `OnCoEnterVentOthers`, `OnVotingComplete`, `OnMeetingCalled`, `OnMeetingStart`,
    `OnVote`, `OnVotedBy`, `OnTaskComplete`, `OnUseConsole`, `OnUseMapConsole`,
    `OnUseSystemConsole`, `OnAssign`, `ConfigureRole`, `OnGameStart`, `UpdateSystem`,
    `UpdateSystemAffected`, `SetKillTimer`, `GetGhostRole`, `HideVote`, `WinnerMessage`,
    `TeamColor`, `IntroSound`, `KillAbilityName`, `KillAbilityImageName`
  - `roleCodeName`, `roleId`, `roleDisplayName`, `roleDescription`, `RoleChance`,
    `IsDead`, `IsSpecial`, `IsEnabled`, `ShouldDoTasks`, `IsEnemyTeam`, `OverrideGhostRole`
- Source role subclasses in the 9.5 build are stubs:
  - `CrewmateRole`, `ImpostorRole`, `CrewmateGhostRole`, `ImpostorGhostRole`
- The real role-ability logic for any given role is not in these stubs.

So for the stock 9.5 build, the managed source says:
- the role-ability channel exists
- the interface that roles can override exists
- the stock roles override almost nothing

What it does NOT say:
- whether the binary role dispatch actually trusts the reader for any role
- what sub-ids exist
- whether mod roles in a real install can override `HandleRpc` with trusted
  reader logic

That is why RoleRpc id 25 is still an open surface, not a confirmed new exploit.

---

## Staff backend / HTTP surfaces

Source reality:
- `StaffTools` has a lot of types, but almost all the real behavior is stubbed:
  - `AmongUsGameBridge.RelayToHost` is a stub
  - `AmongUsGameBridge.HandleStaffHostActionRelayRpc` is a stub
  - `CommandDispatcher` is a stub
  - `CommandRegistry` is largely stubs
  - `SessionManager`, `StaffServices`, `StaffSystem`, `StaffFx`, `PendingWarningStore`,
    `PendingWarningPopup`, `JsonFileStaffStore`, `InMemoryStaffStore`, `HwidProtector`,
    `IpProtector`, `Pbkdf2PasswordHasher`, `Sha256Util`, `StaffAccount`, `StaffRole`,
    `StaffRoster`, `StaffFx` — all stubs or near-stubs for the real behavior
- The non-stub bits in source are mostly fields, enums, and data shapes:
  - `GameAction` enum (huge, includes the troll_* actions)
  - `StaffAccount` fields, `Session` fields, `StaffRosterEntry` fields
  - `PendingWarning` data shape
  - `CommandDescriptor`, `CommandContext`, `CommandResult`, `GameActionResult`, `AuthResult`,
    `ActionResult` shapes

So the staff surface is **present** in the source as a catalog of types and data
shapes, but the actual auth/relay/command logic is binary-only or server-side.

What is definitely in source:
- the relay bridge signature `HandleStaffHostActionRelayRpc(MessageReader reader)`
- the relay send signature `RelayToHost(GameAction action, CommandContext ctx)`
- the GameAction enum with all staff/troll actions
- the staff data model classes

---

## Voice surface

Source reality:
- There is a big voice module tree in `Comms.Modules.Voice.*`, mostly audio DSP:
  - `VoiceRuntime`, `VoiceNetwork`, `VoicePacket`, `VoicePacketFlags`, `VoiceHello`,
    `VoiceLog`, `VoiceFeatureFlags`, `VoiceCapabilityRegistry`
  - `VoiceSendPipeline`, `VoiceJitterBuffer`, `RemoteVoiceStream`, `RemoteVoiceMixer`,
    `VoiceDspProcessor`, `VoicePlaybackReferenceCapture`, `VoiceSpectrumAnalyzer`
  - audio backends/suppressors: `RnNoiseSuppressor`, `WebRtcRnNoiseSuppressor`,
    `StarTrinityWebRtcApmSuppressor`, `LightweightNoiseSuppressor`, `MicrophoneCapture`,
    `OpusVoiceEncoder`, `OpusVoiceDecoder`, `FloatRingBuffer`
  - networking rpcs: `VoiceFrameRpc`, `VoiceHelloRpc`, `VoiceStateRpc`, `VoiceMapGeometryRpc`
  - UI: `VoiceDebugGui.OnGUI`
- `PlayerControl.HandleVoice(MessageReader reader)` is real in source as a signature,
  but the body is binary-only.
- `VoiceNetwork.BroadcastMapGeometryIfNeeded`, `BroadcastPolicyModeIfNeeded`,
  `BroadcastMapGeometryForCurrentGame` are real signatures in source.

So voice is a real separate surface in source, but the actual voice RPC handling
logic is binary-only.

---

## Hookable entry points — practical ranking

If you want "what can a harness actually hook cleanly from managed code", the
ranking is:

1. **Real signatures on dispatch objects** that survive in source as helpers:
   - `PlayerControl.RpcSetRole`, `SetRole`, `MurderPlayer`, `RpcMurderPlayer`,
     `RpcSendChat`, `RpcBroadcastSystemAlert`, `RpcEnterVent`, `RpcExitVent`,
     `RpcSnapTo`, `SetTasks`, `RpcSetTasks`, `HandleVoice`, `RpcStartGame`, `StartGame`,
     `CmdCheckMurder`, `CheckMurder`
   - `ShipStatus.RpcSetWinners`, `SetWinners`, `RpcCloseDoorsOfType`, `CloseDoorsOfType`,
     `RpcRepairSystem`, `RepairSystem`, `StartShields`
   - `ShipHolder.SetShip`, `RpcSetShip`
   - `MeetingHud.CastVote`, `CmdCastVote`, `RpcVotingComplete`
   - `GameData.SetTasks`, `RpcSetTasks`
   - `CustomNetworkTransform.SnapTo`, `RpcSnapTo`
   - `PlayerPhysics.RpcEnterVent`, `RpcExitVent`, `CoEnterVent`, `CoExitVent`
   - `BackroomShipStatus.RpcSyncMaze`
   - `SubmergedStatus.SetElevDoorStatus`
- These are the cleanest to hook because they are real signatures in source and
  they are the actual helpers the binary dispatch calls.

2. **Per-frame lifecycle on long-lived objects**:
   - `AmongUsClient.Update`, `CoStartGame`, `TryStartGame`, `CoBroadcastManager`,
     `CoRecoverMissingStartGame`, `CoRetrySetShip`, `StartGame`, `OnStartGame`
   - `GameData.Update`, `ShipStatus.FixedUpdate`, `ShipHolder.Update`, `MeetingHud.Update`,
     `LobbyBehaviour.Update/FixedUpdate`, `HudManager.Update/FixedUpdate`, `PlayerControl.FixedUpdate`,
     `PlayerPhysics.FixedUpdate/LateUpdate`, `ChatController.Update`, `ServerTracker.Update`,
     `FindAGameManager.Update`, `RegionPingMenu.Update`, `GameDiscovery.Receive`,
   - these are useful for "run something every frame/tick in a specific phase"
     hooks.

3. **UI entry points**:
   - `StaffMenuController.Update`, `Submit`, `OnGUI`
   - `PendingWarningPopup.ShowIfAny`, `OnGUI`
   - `ChatPopupController.ShowWarning`, `OnEnable`
   - `VoiceDebugGui.OnGUI`, `Update`

4. **HTTP/service clients**:
   - `StaffLobbyMusicBroadcast.PlayFromUrl`, `StaffCustomSoundPlayer.PlayFromUrl`
   - `InAppUpdater.PerformUpdate`, `StartUpdate`
   - `AnnoucementPopUpGithub.ShowWarning`
   - `AmongUsGameBridge.CoUploadAndBroadcastAudio`, `BroadcastRandom`
   - `CustomMusicPlayer.Update`
   - `FindAGameManager.Update`, `ServerTracker.Update`, `RegionPingMenu.Update`,
     `GameDiscovery.Receive`

5. **Stubbed but still interesting**:
   - `PlayerControl.HandleRpc` — stub in source, but the dispatch table is the
     single most important target for understanding the game; you just have to
     read it from the binary annotations.
   - `AmongUsGameBridge.RelayToHost` and `HandleStaffHostActionRelayRpc` — stubs,
     but they are the exact staff-relay bridge.
   - `RoleBehaviour.HandleRpc` — stub, but it's the role-ability channel.

---

## What this pass changed versus the earlier summary

1. I confirmed that the source is not "mostly real and we missed bodies". It is
   "real signatures, stub bodies". That means a 100% managed-only audit cannot
   get past the surface catalog for dispatch logic. The binary annotations are
   required for behavior.
2. I confirmed exactly which helper signatures survive in source for each
   dispatch object. That gives you a concrete hook list even if the dispatch
   wiring is binary-only.
3. I confirmed that the role subclasses in the 9.5 build are stubs, so the
   role-ability surface is mostly "potential, depending on mod roles and binary
   dispatch", not "4 stock roles each with a big unauthenticated handler".
4. I confirmed that the staff backend code exists as types/data in source, but
   the real auth/relay/command logic is stubbed — so the staff exploits are
   really about the binary relay path and the live server, not about the
   managed staff types per se.

---

This file is the merge point for source + binary. Use it as the map for the
next passes.
