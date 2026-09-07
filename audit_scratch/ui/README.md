# UI — IMGUI + pop-up + lobby/HUD surfaces

This folder is the UI-side index for the Classic Us 2026.9.5 audit.
It is built from the decompiled source in `decompiled_src_95`, not from
behavioral guessing. If the source is a stub (cpp2IL stripped the body),
I say so and point to the binary-annotated equivalent where it exists.

Quick factual headline:
- Real IMGUI entry points in the 9.5 managed source are few and small.
  Eight files contain `OnGUI`/`GUILayout`/`GUI.Draw`/`EditorGUILayout`/
  `EditorGUI`/`IMGUI`-family references, and most of them are demo or
  utility code, not core game UI.
- The game's UI is mostly Unity GameObject/component UI + coroutine-driven
  pop-ups, not IMGUI. That matters for "can I hook it cheaply" questions,
  because a lot of interesting UI lives in normal MonoBehaviour components
  with real fields you can read or patch, not in `OnGUI` blocks.

---

## IMGUI entry points in the 9.5 managed source

Files with IMGUI-family references:

- `StaffTools/StaffMenuController.cs` — `OnGUI()` + console window drawing.
  This is the F5 staff console. The gate to even open it is the role field
  check in `Update()`, not the IMGUI.
- `StaffTools/PendingWarningPopup.cs` — `OnGUI()`. Persistent warning pop-up
  drawn after launch if `PendingWarningStore` has records.
- `Comms.Modules.Voice.Ui/VoiceDebugGui.cs` — `OnGUI()`. Voice debug drawer
  (mic list, settings), toggled via its own show flag.
- `KlassicHideNSeek/HnSPingTracker.cs` — `OnGUI()`. Hide-and-seek ping
  tracker overlay (custom game mode).
- `UnityStyleSplash.cs` — `OnGUI()`. Splash styling.
- `Rewired.Demos/ControlRemappingDemo1.cs`, `DualShock4SpecialFeaturesExample.cs`,
  `FallbackJoystickIdentificationDemo.cs` — Rewired demo IMGUI; not game UI,
  just demo code shipped in the build.

So the only "interesting" IMGUI surfaces for the game itself are:

1. F5 staff console (`StaffMenuController`)
2. Pending warning pop-up (`PendingWarningPopup`)
3. Voice debug gui (`VoiceDebugGui`)
4. HnS ping tracker (`HnSPingTracker`)

Everything else is component-based UI.

---

## Staff console UI flow (`StaffMenuController`)

This is the hidden F5 console:

- Component exists for everyone; `Bootstrap` creates a persistent
  GameObject + component at game start (`RuntimeInitializeOnLoadMethod`).
- `Update()` is the open gate: it checks `_role` before even polling F5.
- `OnGUI()` draws the console when open.
- `Submit()` drives `CommandDispatcher.Execute`, which is the only caller
  of the real auth chain (`IsStaff` + role bands + rate limiter).
- Output window is IMGUI; command input is IMGUI text field; suggestions
  are IMGUI; icon drag is IMGUI.
- Session token, HWID, roster role, next-role-check timer, and role field
  are all fields on the same object.

Important distinction: opening the panel and executing commands are different
roads. Opening is gateable by the client-side role field. Execution is gateable
by the in-process auth chain. The exploit angle is that a client can spoof the
role field (CE or rename keyword) to open the panel, but console command execution
still hits the auth chain unless the command is relayed via RPC 97 (which is a
different path, covered in exploits).

---

## Pending warning pop-up (`PendingWarningPopup`)

- `OnGUI()` draws an IMGUI box if there are pending warnings.
- `ShowIfAny()` is the entry point the game calls after loading.
- Source of records: `PendingWarningStore`, which writes JSON to disk.
- This is the UI half of exploit 24: the disk-write path is the exploit,
  the pop-up is just the rendered result on next launch.

---

## Chat alert / system popup (`ChatPopupController`)

- Not IMGUI — it's a normal MonoBehaviour component with coroutine-driven
  warning sequence.
- `ShowWarning(string warningMessage)` is the entry point for the
  "SYSTEM ALERT" popup.
- It plays a sound, shows an icon, shows the warning text, and auto-closes
  after a fixed duration.
- This is the UI half of exploit 5: the "SYSTEM ALERT" popup is driven by
  RPC 13 with the `\x01` prefix, but the popup itself is this component.

---

## Announcement pop-up (`AnnoucementPopUpGithub`)

- Dev-controlled announcement pop-up (from the dev GitHub announcement path).
- `ShowWarning()` coroutine draws the announcement.
- Not a player-exploitable UI in the normal sense; it's part of the
  dev-controlled trust domain (announcement text from dev GitHub, updater
  downloads releases). Player-exploitable? No. Supply-chain relevant? Yes.
- Worth keeping on the UI inventory only because it shares UI chrome with
  the other pop-ups and because the updater path is a separate trust concern.

---

## Voice debug GUI (`VoiceDebugGui`)

- `OnGUI()` draws a voice debug panel (mic list, settings, toggle).
- This is a debug overlay, not a core UI feature players normally see.
- Worth noting because it's one of the few IMGUI surfaces that touches the
  voice subsystem, which is otherwise mostly UDP/Opus/audio pipeline code.

---

## Hide-and-seek ping tracker (`HnSPingTracker`)

- `OnGUI()` draws the HnS ping tracker overlay.
- Custom game mode UI, overlays the ping tracking for that mode.

---

## Non-IMGUI pop/UI pieces that matter

These are not IMGUI, but they're the real UI paths that interact with the
exploit surfaces or are worth hooking:

### Chat (`ChatController`)

- Chat input lives here, plus the chat bubble UI.
- `SendChat` is the typed-chat path that goes through `CharacterValidator`
  on the send side (input-box filter), but forged packets bypass that.
- Chat box blocks symbols in the UI; the wire does not.
- This is the send-side UI for normal chat, and why exploit 18 (rich-text
  chat) is a send-path bypass rather than an input issue.

### Chat pop-up / notification chrome (`NotificationPopper`, `ChatPopupController`)

- `NotificationPopper` — small notification text pop-ups.
- `ChatPopupController` — the SYSTEM ALERT style pop-up.
- These are the "screen text that looks official" surfaces.

### Lobby / room flow UI

Managed files touching the room list / lobby / join flow:
- `FindAGameManager` — find-a-game / lobby discovery
- `GameDiscovery` — discovery flow
- `DataTabLobbyController` — lobby tab controller
- `RegionPingMenu` — region ping menu
- `ServerTracker`, `ServerListButton` — server list bits
- `CreateGameOptions`, `GameStartManager`, `HostGameButton`, `JoinGameButton` —
  create/join/start buttons
- `AmongUsClient`, `InnerNetClient`, `InnerNetServer` — the underlying network
  layer the UI talks to

This is where the room-list / lobby UI lives, and where the "list lobbies"
flow starts. Not an exploit surface by itself, but it's the UI side of the
matchmaking/lobby flow.

### In-game HUD pieces

Interesting in-game UI components:
- `HudManager` — main HUD
- `VentButton`, `UseButtonManager`, `AbilityButtonManager` — action buttons
- `AntiHackImpostorButton` — impostor kill button (contains
  `ImpostorRoleCodeName` constant)
- `PlayerVoteArea`, `PlayerTab`, `TaskPanelBehaviour`, `MeetingHud` — voting /
  tasks / meeting HUD
- `RunnerHudOverlay`, `RunnerPlayerList` — runner mode HUD

These are the visible gameplay UI bits that change when roles/states change
(e.g., kill button appearing, vent button appearing). That makes them useful
both as "what the player sees" and as "what a role-flip exploit visibly
changes."

### Settings / options UI

- `OptionsMenuBehaviour`, `GameOptionsMenu`, `GameOptionsData`
- `KeybindManager`, `KeybindButton`
- `ResolutionManager`, `CustomResolutionManager`, `FullScreenScaler`
- `SaveManager`, `PlayerPrefs` usage is widespread
- `StaffSystemOptions` — staff-side options
- `RoleOptions`, `RoleOptionsManager`

Again, not exploit surfaces by themselves, but they're where persistent
settings and the options menu live.

---

## Why this matters for hooks / testing

- IMGUI surfaces are easy to draw into from the outside if you can run an
  `OnGUI` hook, but there are only a handful of them.
- Component-based UI is what you usually want to hook: real fields, real
  methods, real coroutines. `ChatPopupController.ShowWarning`, `PendingWarningPopup`,
  `StaffMenuController.Submit`, `HudManager`, `VentButton`, `AntiHackImpostorButton`
  are all real component surfaces.
- The room-list/lobby flow is spread across `FindAGameManager`, `GameDiscovery`,
  `DataTabLobbyController`, and the network layer. Hooking chat or lobby UI
  from the outside usually means touching those components, not `OnGUI`.

---

## Open UI questions worth checking

1. Any other `OnGUI` / IMGUI surface that the decompiled source stubs hide
   but the binary exposes. The decompiled source says "8 files" — confirm
   against the binary if you suspect more.
2. Whether `VoiceDebugGui` can be toggled by anything besides its own show
   flag, or whether there is a hidden debug key that surfaces it.
3. Whether the announcement/updater path has any UI that a player can trigger
   from in-game (I believe not, but the updater + announcement path is still
   a trust-domain item worth confirming).
