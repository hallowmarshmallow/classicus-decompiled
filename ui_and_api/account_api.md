# Account / identity API (client-facing shape)

## What this documents

This is the account/identity API surface that the stock client is built to talk to.
It describes the endpoint shapes and auth model visible from the client side, and the
trust implications of those shapes. It is not a full serverInternals spec, and live
server behavior should be verified against the real service when possible.

## Endpoint shape

The client is built around a small account API that includes registration, login-style
flows, auto-login/device flows, logout, password change, password recovery, profile,
stats, rank, and related account operations.

There is also a separate lobby/game-connect side on the service. The two are related
but not the same: one is account/identity oriented, the other is room discovery and
game-connect oriented.

## Auth shape

The auth model in the client-visible API is heavily device-shaped. That means a lot of
the account flow is organized around a device identity rather than around a classic
username/password session alone.

That design has a direct security consequence: if the server treats a client-supplied
device value as a strong credential, then whoever can produce or capture that value has
a much easier time presenting themselves as the account's device.

## Device identity

The device identity used by the game is derived deterministically from local machine
data on the client. That is the core problem: it is not a secret the server issues and
binds in a strong way; it is something the client can compute and send.

If the server only checks that the device string looks right, then the auth model is
only as strong as the secrecy and uniqueness of that derived value.

## Channel concerns

The client targets the service over plaintext HTTP to a raw IP. That has two problems:

- traffic can be observed on the network path
- credentials and session material can be exposed to on-path inspection or manipulation

If staff auth, session tokens, or account-modifying requests travel that way, then the
transport itself is part of the attack surface.

## Write-path concerns

Account-modify endpoints are the high-value targets. Any endpoint that changes email,
name, password, device binding, session, flags, or moderation state needs real
server-side verification.

A client-visible account API that accepts device/token-shaped requests and then only
rate-limits them is not the same as one that actually validates the actor for every
write. Rate limiting is a mitigation, not an authorization model.

## Leakage concerns

Unauthenticated reads are a separate problem from writes. If profile, rank, or lobby
metadata is enumerable without a real session, that makes targeting and correlation
easier even before any write exploitation.

## Fix shape

- Move the account/identity flow away from “client-supplied device string = credential.”
- Bind sessions to something the server can verify, and do not let the client dictate
  the device identity as the primary trust anchor.
- Protect the channel with TLS and use a real hostname, not a raw IP in plaintext.
- Authenticate every write endpoint properly; do not rely on rate limiting alone.
- Decide what is public and what is not, and restrict the public surface accordingly.

## Live-server note

Some of the strongest conclusions here depend on how the server actually behaves, not
just on the client shape. The client says what the game is built to send; the server
decides what it trusts. When they disagree, the server behavior is what matters.
