# Network and authority hook map

This is the high-level map of where the game accepts input and where it exercises
authority. It is organized by layer, because the external services and the in-room
authority are different trust domains.

## Layer 1: external service hooks

These are the points where the client sends data to the service side of the network.

### Account/identity hooks

- registration
- login-style authentication
- device/auto-login
- logout
- password change
- password recovery
- profile read
- stats and rank synchronization
- account-modify operations

The key question for each one is whether the server treats the request as authenticated
and authorized, or whether it trusts client-supplied identity too much.

### Lobby/game-connect hooks

- lobby discovery
- lobby filtering/querying
- room connection requests

The key question here is how much metadata is exposed, and whether discovery is public by
design or public by omission.

### Why this layer matters

If the external service trusts a client-supplied device identity as a credential, then the
auth model is only as strong as that device value and the channel it travels over. If the
channel is plaintext HTTP to a raw IP, then the transport is also part of the attack surface.

## Layer 2: in-room authority hooks

These are the points where the host client processes incoming room traffic and changes shared
state.

### Server message hooks

- kick/disconnect-style messages
- start/end-style messages
- relay-style messages
- other server-level control messages

The key question is whether the sender is checked. If a message can change room state and the
host does not confirm that the sender is the real authority for that change, the message is a
candidate exploit.

### Player RPC hooks

- chat and alert paths
- cosmetic and state overrides
- role-related RPCs
- meeting RPCs
- ship/shipholder RPCs
- lobby behavior RPCs
- game data RPCs
- physics/transform RPCs
- map-specific system RPCs
- staff-fx and warning RPCs

The key question is the same in every case: is the action accepted because the sender is
authorized, or because the packet simply arrived?

### Per-object dispatcher hooks

Several objects have their own HandleRpc-style dispatchers. That means authority is not only
in one big switch; it is spread across objects that each process some subset of actions.

That distribution is important because it can hide weak checks. An object may look harmless in
isolation, but if it changes shared state and trusts the sender too much, it is still a problem.

## Where trust breaks

Trust breaks in two common ways.

First, the client says “I am doing X” and the authority accepts it without verifying that the
client is allowed to do X. This is the room-side pattern behind most of the serious exploits.

Second, the client says “this is my device/account/session” and the server accepts it because
the shape looks right, not because it was properly verified. This is the account/service pattern
behind the device-auth concerns.

Both are authorization failures, but they happen at different layers.

## Local vs shared effects

A useful way to classify hooks is by effect scope:

- local-only effects: affect only the sending client's own view or state
- peer-shared effects: affect other clients through the host
- authority state effects: change the room's real state on the host

The most dangerous hooks are the ones that change authority state and are reachable by
unauthenticated peers.

## Fix-oriented summary

A defensible hook map looks like this:

- external services authenticate their actors properly, especially for writes
- device identity is not used as a bare credential
- sensitive data is not exposed through unauthenticated reads unless that is intentional
- in-room authority checks the sender before acting on privileged requests
- powerful room actions are host-only or server-backed, not peer-triggerable
- public features are public on purpose, and private features are protected on the authority
  side, not only on the client UI side

That is the shape to aim for, and it is the shape that the current exploit list shows the game
failing in several places.
