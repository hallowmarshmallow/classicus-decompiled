# In-room authority hooks

This is the map of the room-authority hook points that matter most when thinking about
any-player escalation. It is not a full RPC catalog. It is the set of hooks where a bad
packet can change shared room state or feed another system’s logic.

## The core pattern

Every in-room authority hook has the same basic failure mode:

- a packet arrives addressed to some object
- the object processes the packet
- the object may trust the packet’s content too much
- the result changes shared state or feeds another system

That is why the deep work is not only “which RPCs exist,” but “what does each RPC feed.”

## PlayerControl

PlayerControl is the main dispatcher people think of first.
It includes the high-profile gameplay RPCs:

- murder
- role set
- role RPC
- chat / alert
- cosmetic and state overrides
- cooldown / timer manipulation
- start-game related signals

The important thing here is that PlayerControl is not only a single action surface.
It is a routing surface: some of its RPCs influence other authority systems indirectly.

## PlayerControl RPC 25 and role ability dispatch

This is the deepest hook in the player layer.
See `hooks/role_ability_dispatch.md`.

The key point in the in-room map is that RPC 25 is special because it does not just change
a field on the targeted player. It hands the packet to the targeted player’s role behavior.
That means the effect depends on the target’s role, and it can be a doorway into role-
specific logic that is not obviously powerful from the RPC id alone.

## MeetingHud

MeetingHud is a meeting-state authority object.
Its RPCs cover:

- meeting close
- vote cast
- vote clear
- voting complete

The dangerous part is that meeting state is shared and influential.
Meetings decide who gets discussed, who gets voted, and who gets exiled.
If the meeting object trusts attacker input, the attacker can shape the meeting outcome.

This hook matters because a rigged meeting can be combined with other things:
- fake votes can change who is under pressure
- forced results can change exile outcomes
- meeting state can be used to mask or redirect other actions

## GameData

GameData is the round-state backbone.
It is where player info, task state, death state, and task counts live.
Its RPC surface includes task-setting behavior.

This hook matters because GameData is not just a viewer.
It is the source of truth the rest of the game reads from.
If task state or player state can be driven by a peer packet, then downstream logic—
including win checks and task-driven events—may be affected.

The deep point is that task state is a cross-cutting signal.
Changing it is not only a bookkeeping issue; it can distort how the room evaluates
progress.

## ShipStatus

ShipStatus is the ship/system authority.
Its RPC surface includes:

- close doors by type
- repair/system interact
- set winners

This is important because ship status is where sabotage and repair logic and win
declaration live.
If the system-interact channel is peer-triggerable without proper authority, then
sabotage-like or repair-like effects can be invoked outside the normal role flow.

The “set winners” path is also high-impact because it is a game-end signal.
Win declaration should be an authority decision, not a packet the room accepts casually.

## ShipHolder

ShipHolder is the ship-instance routing object.
It can forward unhandled RPCs to the active ShipStatus.
That means ShipHolder is not just its own hook; it is also an indirect path into ship
behavior.

This matters for map swaps and any other ship-level transition that is reachable through
the holder.
It also matters because indirect routing can make an exploit look smaller than it is:
a packet sent to the holder can end up acting on the ship.

## PlayerPhysics

PlayerPhysics is the movement/vent/ladder hook.
Its RPCs include:

- enter vent
- exit vent
- climb ladder

The deep issue is not only “move the player.”
It is that vent/ladder state is part of gameplay flow.
If a client can force vent or ladder transitions on another player, that can create
desync, cheese, or movement-based abuse.

This hook becomes more interesting when combined with role behavior, because venting and
movement are sometimes tied to role capability decisions in other parts of the code.

## CustomNetworkTransform

CustomNetworkTransform is the position/sequence hook.
Its RPC can snap a target’s position and sequence id.

The deep issue is authority over position.
If a peer can set another player’s position or burn their sequence counter, the attacker
can create movement abuse, freezing, or desync.

This hook is also important because position is often used by other systems indirectly.
If one hook changes where a player appears to be, other logic may make decisions based on
that apparent position.

## InnerNetServer message types

The server message layer is the other category of hook.
These are the room-level control messages that can do things like:

- kick/disconnect
- start game
- other server-level transitions

These are important because they are not tied to a single player object in the same way as
the per-object RPCs. They are room-control primitives.
If the server message handler does not check sender authority, the attacker can touch room
controls directly.

This is where kick and forced-start style issues live.

## The chaining view

The in-room authority map should be read as a graph, not a list.

For example:

- player role dispatch can change what role behavior is in play
- role behavior can affect who can do what in meetings, vents, kills, or systems
- meetings can decide exile or pressure
- GameData can decide task progress and death state
- ShipStatus can decide systems and winners
- position/physics can affect apparent gameplay circumstances

A single weak hook can be annoying.
A chain of weak hooks can be game-breaking.

That is why the deep pass should focus on the interfaces between these hooks, not just the
hooks in isolation.

## Fix shape for the whole layer

The consistent fix pattern across this layer is:

- identify which hooks are authority-changing
- verify the sender before honoring the change
- do not let a peer packet act as a direct instruction to another player’s role behavior,
  meeting state, task state, ship state, or position
- keep public/cosmetic hooks separate from authoritative state hooks
- prefer host-only or server-mediated decisions for anything that changes shared room
  outcome

The goal is not to remove networking.
The goal is to stop the room from treating peer packets as authority.
