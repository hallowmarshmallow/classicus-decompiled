# Classic Us (2026.9.5) — full decompiled + binary audit

This is a fresh deep pass over the whole managed codebase
(`decompiled_src_95`, 1088 C# skeletons) plus the binary annotations
we already built in `classicus_exploits.txt` and the annotated dumps.
Goal: give you a clean, categorized view of every interesting surface
(exploits, UI, API/hooks) without the old noise.

Layout:
- `exploits/` — network surfaces and any-player / host-execute vectors
- `ui/` — every IMGUI and pop-up path in the decompiled source
- `api_harness/` — every hookable API surface: RPC send/recv,
  per-frame Update/FixedUpdate, HTTP/staff services, and the places
  BepInEx/Harmony can actually touch

Source of truth for names/fields/methods: `decompiled_src_95/*.cs`.
Source of truth for holes/gates: the annotated binary dumps + the
preceding exploit pass. Where the decompiled skeletons are stubs
(cpps2IL strips bodies), I lean on the binary annotations and note it.

---

## What I scanned to build this

1. Every `.cs` file in `decompiled_src_95` for:
   - `HandleRpc` implementations (13 handlers found)
   - IMGUI entry points (`OnGUI`, `GUILayout`, `GUI.Draw`, `EditorGUILayout`, `EditorGUI`, `IMGUI`)
   - per-frame lifecycle (`Update`/`FixedUpdate`/`LateUpdate`, `StartCoroutine`, `Application.Quit`, settings flow)
   - room flow (`JoinRoom`/`CreateRoom`/`RefreshLobby`/`FindAGameManager`/`GameDiscovery`)
   - network/service surfaces (`StartRpc`/`SendRpc`/`RpcBroadcast`/`PlayFromUrl`/HTTP/staff endpoints)
   - staff/consolespecific paths (`StaffMenuController`, `PendingWarningPopup`, `AmongUsGameBridge`, `SessionManager`)
2. The annotated binary dump sections in `classicus_exploits.txt` for actual
   dispatch tables, gate instructions, wire payloads, and known missing pieces
   (Binary-only findings are marked `[binary]` where the decompiled source is a stub.)
3. The previous exploit inventory in `classicus_exploits.txt` (exploits 1-24) to
   avoid re-deriving the same holes and to cross-check the new scan.

---

## Big picture, in one line

Classic Us 2026.9.5 is a P2P-hosted Unity game. Authority lives inside
the host's client. Every interesting state transition is driven by one of:

- `InnerNetServer.HandleMessage` on the host (wire types, including kick/start)
- some object's `HandleRpc(byte callId, MessageReader)` on whichever client the
  RPC is addressed to (including the host itself)
- the F5 staff console / `StaffMenuController` / `StaffSystem` on any client that
  has a role field set
- IMGUI pop-ups (`PendingWarningPopup`, `ChatPopupController`, staff banners, voice debug)
- HTTP/staff services compiled into the client (`StaffServices`, `SessionManager`,
  `AccountService`, `Announcement`, in-app updater)

The exploit class is almost always the same: a packet claims something about the
world (who should die, who should win, who should be staff, what the map should be)
and the receiver trusts it with little or no sender/host/session check.

---

## Where to look next if you want more

1. RoleRpc id 25 — still the biggest un-enumerated surface. The decompiled
   skeleton says `HandleRpc(MessageReader reader, int rpc)` on `RoleBehaviour`, and
   the binary says case 25 reads a sub-id and dispatches through the target's
   `RoleBehaviour` vtable. The stock `RoleBehaviour` subclasses in the 9.5 build
   (`ImpostorRole`, `CrewmateRole`, ghost variants) barely override anything, but
   any mod role with a real override is a fresh attack surface. Worth dumping the
   vtable slot and every override of `HandleRpc` across all role classes, including
   any mod-provided ones.
2. Voice RPCs — `VoiceFrameRpc`, `VoiceHelloRpc`, `VoiceStateRpc`, `VoiceMapGeometryRpc`
   exist in `Comms.Modules.Voice.Networking`. The binary notes RPC 29 `HandleVoice`
   carries binary Opus payloads. Not fuzzed yet.
3. The staff server / HTTP client surface — `StaffServices`, `SessionManager`,
   `AccountService`, `AmongUsGameBridge` are all in the decompiled source. Several
   were flagged earlier as worth testing against the live endpoint (session token
   handling, plaintext HTTP, auto-login path). Closed server, so some of that stays
   a "test against live" item.
4. Anything Unity lifecycle that touches `PlayerPrefs`, disk writes, or asset loading
   — `PendingWarningStore` already showed a persistent disk-write pop-up path. Worth
   walking every other `PlayerPrefs`/`persistentDataPath`/`Application.persistentDataPath`
   writer for similar "leave a trace on the victim's machine" patterns.

---

This folder is the new scratch space for that continued work.
