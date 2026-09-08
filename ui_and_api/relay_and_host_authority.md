# Relay and host authority

## The core model

Classic Us uses player-hosted rooms. In that model, the room authority is not a separate
server process you can patch independently; it runs inside the host's client. That is the
single most important thing to understand about the exploit surface.

If the authority lives in the host client, then:

- a malicious peer sends a packet to the host
- the host's client processes it
- if the host's client trusts the packet too much, the attacker gets the host's authority

That is the pattern behind the room RPC exploits.

## RunAsHost split

Staff actions have a host/non-host split in the client. If the acting staff member is the
host, the action can run locally. If not, the client can relay the action to the host.

That split is deliberate and useful for legit remote staff moderation. The problem is the
receiving side. The host accepted the relay and executed it without re-validating that the
relay really came from an authorized staff session.

That is why the relay became an exploit: the design assumed the relay itself was trustworthy
because it came from a staff client, but the host never checked that assumption in the way
that matters.

## RPC 97 relay

RPC 97 is the staff-action relay path. A client sends an action id, label, and arguments.
The host builds a staff-context object from those bytes and dispatches the action.

The critical failure is that the host trusted attacker-chosen bytes to represent a real
staff actor. If the host had verified the sender's staff session before executing the action,
the relay could still be useful without being exploitable.

## Why this keeps recurring

The same theme shows up across the room RPC surface:

- the packet says “I am this kind of action”
- the host runs it
- the host does not sufficiently check whether the sender is authorized for that action

That is the root issue for the room-side exploits. The client is full of actions that are
fine when triggered by the right authority, but unsafe when a peer can trigger them directly.

## Why patching only the client is messy

Because hosting is client-side, protecting players depends on the host running a patched
binary. That is a harder deployment problem than fixing a centralized server, because every
host matters, not just one backend.

It also means client-only moderation features can be undercut by the hosting model itself.
A feature that is supposed to help staff can become a weapon if the host trusts the wrong
thing.

## Fix shape

- The host should verify authority before acting on any privileged request.
- For remote staff actions, that means checking the real staff session, not just accepting
  the relay payload.
- For room state changes, that means host-only or server-backed authority for things like
  starts, kicks, role changes, winners, and system sabotage.
- The cleaner architectural fix is to move authority to a server that can authenticate
  actors consistently, instead of letting every host client be the source of truth.

## Practical summary

The relay is the clearest example of the broader disease: the host trusted a client-supplied
idea of who was acting, and the hosting model made that trust matter. Most of the serious
room exploits are different symptoms of the same underlying problem.
