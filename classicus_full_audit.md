# Classic Us 2026.9.5 — Full Network-Surface Audit

Audit of **every inbound network path** in the stock 2026.9.5 Linux build
(`GameAssembly.so`, Unity 2022.3.62f3, IL2CPP x64, metadata v31.1).
Same code confirmed present in 2026.9.2. All findings are **static** (disassembly +
resolved symbols); dynamic confirmation status noted per item.

Coverage: 13 inbound dispatchers decoded end-to-end → every live call-id / message-type
slot classified. This is the authoritative superset of `classicus_exploits.txt`.

---

## 1. Architecture recap (who trusts whom)

- The **room authority runs an `InnerNetServer` instance** — in a player-hosted room that is
  the host's client process; online rooms reach the same code on the lobby/matchmaker
  backend (`178.156.171.131`). Client↔authority traffic is Hazel TCP.
- Attackers talk to the authority through **`InnerNetServer.HandleMessage`** (connection-level
  messages) and to peers through **object RPCs** inside GameData containers.
- One systemic flaw: the receiver **executes what the packet claims** — there is no per-packet
  sender proof. Whether that matters depends on which slot you hit.

Confidence legend: **[static]** verified in disassembly; **[dyn?]** static read but
runtime semantics need a live test to confirm impact depth.

---

## 2. InnerNetServer.HandleMessage — client → room authority (host-side)

`0x125d060`, jump table @ `0x6a17d4`, 16 slots, **9 live**. Inbound from any connected client.
`msgType` = first payload byte.

| type | case | action | sender check? | verdict |
|---|---|---|---|---|
| 0 | 0x125d0e5 | build reply writer (Write 0x20), send back to sender | none | harmless ack |
| 1 | 0x125d1f3 | `JoinGame(server, sender)` | none visible at dispatch | protocol join; auth is upstream (matchmaker) |
| 2 | 0x125d135 | `StartGame(server, reader)` — sets started flag **and rebroadcasts the caller's packet verbatim** | **none — sender not even passed** | **[static] any member can flip the room into started state and inject the broadcast payload → force-start / state desync** |
| 3 | 0x125d21b | `ClientDisconnect(server, sender)` | none (self-removal, benign) | ok |
| 4,7,9,10,12,13,14 | — | dropped (default 0x125d498) | — | dead slots |
| 5 | 0x125d2ae | relay: `Broadcast(server, copy of whole packet)` | **sender must be in the player list** | **[static] membership-gated echo primitive** — content never validated; anything the server will echo can be made to look server-originated to peers |
| 6 | 0x125d15d | relay: ReadPackedInt32 → `SendTo(server, copy of whole packet, targetId)` | **sender must be in the player list** | same echo primitive, targeted at one client |
| 8 | 0x125d243 | `EndGame(server, reader, sender)` | ✅ **host-gated inside: `sender.id == server.hostId` (0x125de16)** | properly protected |
| 11 | 0x125d26e | ReadPackedInt32 victimId + bool → `KickPlayer(server, victimId, bool)` | **none — victim picked from packet** | **[static] forged kick of any connected client incl. the host** (your original symptom). `KickPlayer` 0x125e400 scans players, no host/self check |
| 15 | 0x125d33a | ReadPackedInt32 clientId + **ReadString reason** → `DisconnectPlayer(server, clientId, reason)` | **none** | **[static] second, independent kick primitive — arbitrary reason string from the attacker → spoofed disconnect text on the victim** (`DisconnectPlayer` 0x125e880, sends msg 0xf + closes) |

**New vs the 5-vector list:** types **15** (custom-reason disconnect) and **2** (force-start +
payload injection) were not previously catalogued. Type 11 is the documented "type-11 kick".

---

## 3. PlayerControl.HandleRpc — the big object-RPC switch (98 slots, 43 live)

`0x10ebfb0`, table ~`0x6a0c2c`. Call ids shared with the object addressed in the packet
(`this` = the targeted PlayerControl; custom singleton handlers for id 89–97).
**No case validates who sent it.**

| id | handler (resolved) | effect when spoofed | severity |
|---|---|---|---|
| 0 | PlayAnimation(byte) | force any emote/death anim on target | low |
| 1 | CompleteTask(packed uint) | mark tasks complete for that player | mid (cheat / crew-win tampering if host tallies blindly) |
| 2 | SyncSettings (bytes) | apply attacker settings to local view | low-mid (visual/desync) |
| 3 | SetInfected | **dead — routes to epilogue** (not handled inbound) | — |
| 4 | Exiled | exiled/dead state + anim on target | mid **[dyn?]** |
| 5 | CheckName(string) | name-change request path | low |
| 6 | SetName(string) | **rename any player incl. host on every peer** | mid (impersonation) **[dyn?]** |
| 7 | CheckColor(byte) | color request path | low |
| 8 | SetColor(byte) | force color change | low |
| 9 | SetHat(string) | force hat | low |
| 10 | SetSkin(string) | force skin | low |
| 11 | ReportDeadBody — ReadByte → GetPlayerById → report path | **meeting-trigger channel (fake body-report)** | mid **[dyn?]** |
| 12 | MurderPlayer(NetObject killer) | **fake kill on the victim's client** (anim; real death depends on GameData authority) | high if it applies death, else mid **[dyn?]** |
| 13 | SendChat(string) | chat injection; "\x01"-prefixed = **SYSTEM ALERT popup on every client** (exploit #5 — alert mode of SendChat) | high (social engineering) |
| 14 | TimesImpostor | **dead — routes to epilogue** | — |
| 15 | StartMeeting — ReadByte → GetPlayerById → meeting path | force a meeting on recipients **[dyn?]** | mid |
| 16 | SetScanner(bool, byte) | scanner/medbay state spoof | low |
| 17 | SendChatNote(byte, note) | chat-note/emoji spoof | low |
| 18 | SetPet(string) | force pet | low |
| 19 | SetStartCounter — packed int + sbyte | **force lobby start-countdown value** (sibling of LobbyBehaviour 71 / type-2) | mid |
| 20 | SetPlayerScale — ReadSingle → transform | **resize any player** (tiny/huge) on every peer (pass-1 "position set" was wrong) | low-mid |
| 21 | SetRole(string) | **role assignment spoof** (display/gameplay on target) | high if gameplay, mid if cosmetic **[dyn?]** |
| 22 | StartGame — direct call, no gate | **force the recipient into the game-start map load** | mid-high |
| 23 | CheckMurder(NetObject killer) | murder-validation entry | high **[dyn?]** |
| 24 | SetCooldown/SetKillTimer(float) | zero/set kill cooldown of any player | mid (cheat) |
| 25 | RoleRpc — ReadInt32 sub-id → role dispatch | **per-role ability channel** (shoot/shield/drag/…); sub-handlers not yet enumerated — likely unauthenticated | **high [audit gap]** |
| 26 | SyncRoleSettings — bytes → FromCompressedBytes → ReadJson | apply attacker role-options/JSON | low-mid (desync) |
| 28 | SyncRoleOption — ReadString(s) | per-role option write | low |
| 29 | HandleVoice(reader) | **voice-chat frame injection** (Opus payload parse → fuzz target) | mid **[dyn?]** |
| 81 | MapManager map-load path | Runner-mode map control | mid **[dyn?]** |
| 82 | HandleBotSync | runner-bot sync (takes senderId) | mid |
| 83 | HandleBotKill | **forged bot kill** (exploit #4) | high in Runner mode |
| 84–87 | RunnerPowerups Spawn/CollectRequest/Apply/ShieldBlock | forge powerup state/kills | mid (Runner mode) |
| 89 | StaffLobbyMusicBroadcast.PlayFromUrl(string) | **force every client to stream an attacker URL** | **high: IP harvesting + audio abuse** |
| 90–91 | runner-bot cluster (singleton-guarded) | bot state | mid |
| 92–93 | byte+string(+string) custom audio/sound events | custom audio w/ name → same URL risk | high **[dyn?]** |
| 94 | StaffCustomSoundPlayer.PlayFromUrl(string) | **same as 89: arbitrary URL streamed by all clients** | **high: IP harvesting** |
| 95 | StopAll | cut audio | low |
| 96 | DevPetCosmetic.HandlePetTransformRpc | pet teleport | low |
| 97 | **HandleStaffHostActionRelayRpc** | **forged full staff-command execution on host** (exploit #1) | **critical** |

**New finding — remote-audio cluster (89/92/93/94/95):** the handlers are
`StaffLobbyMusicBroadcast.PlayFromUrl` / `StaffCustomSoundPlayer.PlayFromUrl` /
`StopAll`, dispatched with **zero auth**. A lobby member can make *every client*
HTTP-fetch an arbitrary URL — attacker-controlled server logs each victim's IP
(audible + deanonymizing), or blast loud/embedded audio. 95 kills the noise.

**Pass-2 corrections (via the PlayerControl `RpcCalls` enum + case targets):**
call-id names are now exact. 3/14 dead; 11 = ReportDeadBody; 13 = SendChat
(alert mode is the "\x01" prefix); 15 = StartMeeting; 19 = SetStartCounter;
20 = SetPlayerScale (NOT teleport); 22 = StartGame (no gate — force-start
family with LobbyBehaviour 71 + server type 2); 25 = RoleRpc sub-dispatch
(an un-enumerated per-role ability surface); 26/28 = role-settings writers.

---

## 4. Other HandleRpc implementations (per-object-type switches)

| object | rva | live ids | notes |
|---|---|---|---|
| RoleBehaviour | 0xfd55b0 | — | empty stub (roles use PlayerControl space) |
| BackroomShipStatus | 0x1006360 | 3 (+base) | id 3 = ReadInt32×3 (rows/cols/seed) + ReadSingle (scale) → `MazeGenerator.GenerateDefaultMaze` (0x10a2540) — **maze regen, no gate** |
| CustomNetworkTransform | 0x1030560 | 21 | id 21 = ReadVector2 + ReadUInt16 → `SnapTo(pos, sid)` (0x102f030); only gate = isActiveAndEnabled + `SidGreaterThan` — **teleport/freeze anyone** |
| GameData | 0x1059880 | 29 | id 29 = ReadByte(playerId) + ReadBytesAndSize → `SetTasks` (0x10583b0) — **task-list rewrite, no gate** (corrects pass-1 "GameData blob" note) |
| LobbyBehaviour | 0x10930b0 | 71 | id 71 = ReadInt32 → FindObjectOfType → `LobbyCloseCountdown.ForceStartCountdown` (0x12c4990) — **lobby start-countdown hijack** |
| MeetingHud | 0x10c2c60 | 0–3 | 0=Close, 1=CastVote(2×byte), 2=ClearVote, 3=VotingComplete(states+exiled+tie) — **rig any meeting result** (exploits #9) |
| PlayerPhysics | 0x10f5ed0 | 0–2 | 0/1 = EnterVent/ExitVent (packed int ventId), 2 = ClimbLadder — vent/ladder spoof |
| ShipStatus | 0x112aa20 | 0–2 | 0=CloseDoorsOfType(byte), 1=RepairSystem(byte, netObj, byte), 2=SetWinners(bytes) (0x112a0b0) — reachable via ShipHolder forwarding (exploits #10/#17) |
| SubmergedStatus | 0x1148280 | 3 + base | id 3 = ReadInt32 + ReadBoolean → `SetElevDoorStatus` (0x1148160) |
| VoteBanSystem | 0x11687f0 | 0 | **vote-ban spoof (exploit #3)** — srcClient+target from packet |
| ShipHolder | 0x129b150 | 30 (+fwd) | id 30 = ReadString → `SetShip` (0x129aa60, MapManager-validated, **no host gate**) — mid-game map swap; all OTHER ids forward to the live `ShipStatus.HandleRpc` via vtable (0x129b1fe) |
| InnerNetClient.HandleMessage | 0x1252b30 | types 0–14 | server→client only (not attacker-reachable except via rogue-host/relay) |

### 4b. Pass-2 verdicts (all [static] — see `classicus_exploits.txt` exploits #9–#17)

| vector | object / id | effect when spoofed | severity |
|---|---|---|---|
| 9 | MeetingHud 3 / 1 / 0 | force any meeting result (exile/tie/skip), stuff votes as any player, force-close meetings | HIGH |
| 10 | ShipStatus 2 (via ShipHolder) | declare match winners mid-round (fake victory state) | HIGH |
| 11 | ShipHolder 30 | swap the active map mid-game / override lobby map | MED-HIGH |
| 12 | CustomNetworkTransform 21 | teleport or freeze any player (sid-burn) | HIGH |
| 13 | LobbyBehaviour 71 | force the lobby start countdown | MED |
| 14 | GameData 29 | rewrite any player's task list on the authority | MED |
| 15 | PlayerPhysics 0/1/2 | force vents/ladders on any player (desync) | LOW-MED |
| 16 | Backrooms 3 / Submerged 3 | maze regen / elevator-door block (map grief) | LOW-MED |
| 17 | ShipStatus 1 / 0 | sabotage/door system write, sender unchecked (per-map role depth **[dyn?]**) | MED-HIGH |

## 5. What is properly gated (good hygiene found)

- **EndGame (server type 8):** sender must equal the host client id.
- **Relays (server types 5/6):** sender must be a joined member.
- **Staff console path:** `IsStaff` → role bands → rate limit on the executor's client;
  not forgeable *as a UI* (the relay RPC 97 bypass was the hole).
- **Server disconnect/remove code:** mutex-disciplined, null-checked (few crash vectors).
- **Announcement / updater:** dev-GitHub controlled; no player path.

## 6. Fix status (see `patch_kick_exploits_95.py`)

- ✅ patched: RPC 97 → dropped; RPC 13 → dropped; type-11 kick → sender gate (`GameAssembly.patched.so` present in the 9.5 folder).
- ❌ open (no patch yet): type-15 forged disconnect; type-2 force-start; URL-audio RPCs 89/92/93/94/95; vote spoofs; runner-bot cluster 82–91; rename/SetRole/MurderPlayer/CompleteTask/SetKillTimer cheat family; **and the whole pass-2 object-dispatcher family** (exploits #9–#17: MeetingHud 0–3, ShipStatus 0–2 via ShipHolder, ShipHolder 30, CustomNetworkTransform 21, LobbyBehaviour 71, GameData 29, PlayerPhysics 0–2, Backrooms/Submerged 3).

## 7. Suggested runtime verification (BepInEx, attacker copy)

Extend `harness_rpc13/SystemAlertSpoof` with chat commands that fire:
1. `RpcBroadcastSystemAlert` (done — proves RPC-13 path)
2. server type-11/type-15/type-2 raw sends (needs a raw Hazel writer to the host socket —
   the full packet-injection harness) — **this is the highest-value next test**
3. `RpcSetRole`/`RpcMurderPlayer` targets to confirm [dyn?] items 12/21

Observe on a fully stock host copy: popup appears (13 ✓), victim/host kicked (11/15),
game forced to start (2), custom-URL audio plays (94) while a listener on the attacker
box logs the victim client's HTTP request (IP harvest proof).

## 8. Coverage gaps (honest)

- Dev matchmaker/lobby API internals (closed source; not auditable from the binary).
- Voice path (RPC 29) payload parsing = fuzz candidate, not yet fuzzed.
- [dyn?] items above need one live two-instance run to lock severity (esp. MeetingHud VotingComplete → exile chain, ShipStatus SetWinners read-back, RepairSystem per-map role logic, CNT snap broadcast scope).
- 9.2 → 9.5 deltas beyond the id map not re-verified per role.
