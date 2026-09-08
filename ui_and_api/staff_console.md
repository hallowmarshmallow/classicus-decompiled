# Staff console (in-client admin CLI)

## What it is

The staff console is an in-client admin interface implemented by
`StaffTools.StaffMenuController`. It is present for everyone at game start, but
the actual execution path is supposed to be gated.

## Open path

- The console is tied to F5 in the stock build's console-open wiring.
- The controller updates every frame and polls for the open key once the local
  role state allows it.
- Opening is a local UI action; opening alone does not execute anything.

## Execution gate

- Console commands are executed through the command dispatcher, not through chat.
- The dispatcher checks staff status, permission bands, and rate limiting before
  it runs a command.
- That is the intended legitiate path for staff actions entered in the console.

## Role refresh

- The local role used by the console is refreshed from local state on a timer.
- That refresh combines a roster-derived role with a name-tag-prefix role check.
- Because the role can be derived from local name information, the console's access
  depends on client-visible identity signals, not only on a server-verified session.

## Why it matters for exploits

- The console itself is not the main exploit. The main exploit is anything that lets
  a client reach an execution path that should have been staff-only.
- The relay path is the clearest example: non-host staff actions were designed to be
  relayed to the host through RPC 97, but the host side did not re-validate that the
  relay sender was real staff.
- So a weak console gate is dangerous mainly when there is also a weak execution or
  relay path.

## Full command surface (from 9.5 string literal table)

The binary ships the entire remote staff command set as literals, including
commands not shown in any in-game menu:

Account / ban:
- `/ban_hwid <player>`, `/unban_hwid <player>`, `/unban <hwid|ip|id>`
- `/flag_account <player>`, `/unflag_account <player>`, `/list_flagged_accounts`
- `/lock_account <player>`, `/unlock_account <player>`, `/verify_account <player>`
- `/audit_account <player>` ("Full account audit."), `/show_hwid <player>` ("dev only")
- `/force_password_reset <player>` ("Force a password reset.")

Lobby / game:
- `/force_start_game`, `/lock_lobby`, `/unlock_lobby`, `/set_lobby_name <name>`
- `/end_game_crew`, `/end_game_impostor`, `/reopen_game`, `/shutdown_game`
- `/troll_fake_ghost_popup <player>`, `/ghost_mode <player>`
- `/set_kill_distance`, `/reset_kill_distance`, `/safeguard_room` (blocks kills in a room)
- `/spawn_runner_bot` (hostile runner-AI dummies, host only), `/remove_dummies` (host only)
- `/replay_movement <player>` (movement hologram)

Server:
- `/server_status`, `/restart_server`, `/shutdown_server`

Audio:
- `/lobby-music <mp3 file path>`, `/lobby-music/upload?hwid=` (staff-gated, live 401 without staff),
  `/play_sound`, `/stop_sounds` ("loops for everyone (lobby + in-game)")

Relay/authority strings (9.5):
- `relayed to host - action will apply momentarily` - client confirmed send
- `no host to relay to` - client could not relay
- `state ignored: non-host sender` - host-side rejection message, exists in 9.5
- `hello blocked: host missing` - voice hello guard
- `Tried to spawn while not host:` - spawn guard
- `Remove all staff-spawned dummies. Host only.` - dummy spawns are host-gated
- `[DevPet] Kill move requires host.`
- `[LobbyCloseCountdown] Staff-only action denied - you are not staff.`

Anti-cheat strings (9.5):
- `[AntiHackImpostorButton] Not in a lobby or in-game session. Ignoring.`
- `[WineDetector] Wine/Proton detected - online play blocked (shared HWID would
  collide accounts).` - online play is blocked under Wine/Proton
- `[LobbyInputWatchdog] input dead in lobby for ...` + `report failed:`

## Fix shape

- Console access should depend on a server-verified staff session, not only on a
  locally stored role field.
- Any command execution path that can cross the network should re-check authorization
  on the receiving side.
- Rate limiting and permission bands are good, but they do not replace sender
  authentication.

## Local-only note

- A locally crafted staff store can satisfy in-process staff checks on a machine that
  the game trusts as host. That is a host-local issue, not a remote lobby exploit by
  itself.
