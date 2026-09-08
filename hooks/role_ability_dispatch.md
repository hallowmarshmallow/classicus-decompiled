# Role ability dispatch (PlayerControl RPC 25) — deep hook analysis

## What this hook is

RPC 25 is the role-ability dispatch slot on `PlayerControl`.
The decompiled enum calls it `RoleRpc`.
The important shape is not “impostor vs crewmate” but “each player’s role behavior
has its own RPC handler, and RPC 25 is the generic entrance into that per-role handler.”

So this hook is unusual compared with most others:

- most RPCs act on the targeted object directly
- RPC 25 acts on the **targeted player’s role object**, using a handler chosen by that
  player’s current role

That distinction matters because it means the authority being exercised is not just
“change this player” but “run this player’s role logic with attacker-chosen input.”

## Dispatch shape

From the decompiled sources, the path is:

- `PlayerControl.HandleRpc` dispatches on `callId`
- `RoleRpc = 25`
- `StartRoleRpc(int rpcId, int target = -1)` is the sender helper for role RPCs
- the role object is `RoleBehaviour`
- `RoleBehaviour.HandleRpc(MessageReader reader, int rpc)` is the per-role entrypoint

So the class of behavior is:

1. a packet arrives addressed to a `PlayerControl`
2. the handler chooses that player’s current `RoleBehaviour`
3. the role behavior gets called with the rest of the packet as input

That means the real question is not only “who can send RPC 25,” but “what can the
targeted player’s `HandleRpc` do once it is invoked with attacker-controlled data.”

## Why this is a deep surface

The base `RoleBehaviour.HandleRpc` is virtual and empty in the base class.
Derived roles override it with their own behavior.
That means the attack surface grows with the number of roles.

If the game has many roles, and each role has its own RPC sub-dispatch, then:

- the dispatch itself may be unauthenticated
- the per-role sub-actions may or may not be checked
- the same slot can carry very different effects depending on the target’s role

That is why this is a “enumerate the roles” problem rather than a single-id problem.

## Why it matters in hosted play

In hosted play, the room authority runs in the host’s client.
If RPC 25 reaches the host and the host runs the targeted player’s role handler without
verifying the sender’s authority for that action, then the packet can influence the
targeted player’s role behavior on the authority side.

That can interact badly with other exploits:

- if role assignment is also weak, ability dispatch becomes more powerful
- if role behavior includes kill/sabotage/advancement effects, the dispatch may be a way
  to trigger role-specific logic outside the normal input flow
- if the role behavior affects shared state, the consequences are not local-only

So even if the exact per-role effects are not all enumerated yet, the hook pattern itself
is high-value.

## What is known from the client sources

The client sources make the design legible:

- roles are `RoleBehaviour` subclasses
- role assignment goes through `RoleManager.AssignRole`
- there is a `roleCodeName` concept, including `ImpostorRole`
- there is a role-options system with `RoleOptionsManager` and `RoleOptions`
- there is an impostor-button check class using `ImpostorRoleCodeName`

That tells us the role system is parametrized and data-driven, not a small fixed set of
hardcoded abilities. That increases the chance that the ability dispatch is broad.

## The real fix shape

The fix is not “block RPC 25 entirely.”
Some role-ability communication may be legitimate.
The fix is to make the dispatch authoritative and sender-verified:

- only the authorized sender should be able to invoke a target’s role ability RPC
- the authority should validate the request against the real game state before running it
- the receiver should not treat a peer packet as a direct instruction to run the role handler
- if role abilities are meant to be remote-triggered, they should be mediated by the host
  authority or by a server, with proper authentication and rate limiting

In short: the role handler should not be a public function the network can invoke on
another player’s role object.

## Why this is priority for a deep pass

This hook is one of the clearest “any-player vs any-player” escalation paths because it
turns the targeted player’s own role code into the execution context.
If an attacker can feed arbitrary input into another player’s role handler, then the
damage depends on what that role handler does.
That is exactly the kind of surface that is easy to miss if you only audit one RPC at a
time.

## Relation to the existing exploit list

This is the deeper explanation for the role-ability sub-dispatch entry in
`exploits/index.md`.
It is not just “RPC 25 exists.”
It is “RPC 25 routes into the target’s role behavior with attacker-chosen input, and that
route is part of a broader role-ability surface that has not been fully enumerated.”
