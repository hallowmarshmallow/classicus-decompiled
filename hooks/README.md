# hooks/

This folder is the overall hook map for the game's networking and authority surface.

## What this folder is for

It describes where control enters the system and where trust decisions are made. The point
is not to list every function name, but to show the shape of the hook points that matter for
exploits and fixes.

## Two authority layers

There are two distinct layers to think about:

- the external HTTP services the client talks to for account/identity and lobby/game-connect
- the in-room authority that runs inside the host client during a hosted lobby

Those two layers fail in different ways.

## External service hooks

These are the points where the client hands data to the service:

- account registration and login-style flows
- device/auto-login flows
- profile, stats, rank, and other account reads/writes
- lobby discovery and game-connect requests

The security-relevant questions here are:

- what does the server trust from the client
- what can a client supply or replay
- what is public vs authenticated
- whether the channel protects the data in transit

## In-room authority hooks

These are the points where the host client processes incoming packets and affects room state:

- InnerNetServer message types
- PlayerControl RPC dispatch
- per-object HandleRpc dispatchers for things like meetings, ship status, lobby behavior,
  game data, player physics, and networking transforms

The security-relevant questions here are:

- who is allowed to trigger this effect
- whether the sender is authenticated or inferred
- whether the action is host-only or peer-triggerable
- whether the action changes shared state or only local state

For the deeper map of the role-ability layer and the surrounding room-state hooks, see:

- hooks/role_ability_dispatch.md
- hooks/inroom_authority_hooks.md

## Why the map matters

A lot of the exploit surface comes from a mismatch between “this action is powerful” and
“this action is gated by the sender being the real authority.”

When a powerful action is reachable through a hook that does not properly check the sender,
you get the kinds of exploits documented in `exploits/index.md`.

When an external service trusts a client-supplied device identity too much, you get the
account/auth problems described in `ui_and_api/`.

## Fix orientation

Good hook design tends to look like this:

- every privileged action has a clear actor
- the actor is verified, not assumed
- the verification happens on the authority side, not only on the caller side
- public data is public on purpose, not by accident
- writes are authenticated and validated every time

If a hook is meant to be public, make it public deliberately. If it is meant to be
privileged, make the privilege check real.

## Related folders

- `exploits/` — the concrete abuse vectors that come out of these hooks
- `ui_and_api/` — the client UI and HTTP/API surfaces that feed into them
