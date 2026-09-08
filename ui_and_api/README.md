# ui_and_api/

This folder is the static reverse-engineering reference for the in-client UI and
the HTTP/API surface that is compiled into the stock build.

## What is here

- `staff_console.md` — F5 console, role gating, refresh, relay relationship.
- `voice_gui.md` — Comms voice UI/session shape and what is client vs server driven.
- `account_api.md` — account/identity endpoints the client targets and the auth shape.
- `lobby_api.md` — lobby/service endpoints the client uses to discover rooms.
- `relay_and_host_authority.md` — RPC 97 relay, RunAsHost split, and why client→host
  authority matters in P2P hosting.

## What this folder is for

It documents the UI and API pieces that interact with the exploit surface, not just
the room RPCs. The goal is to make the attack surface legible: which UIs touch auth,
which APIs touch identity/lobby state, and where the client trusts data that should
be verified.

## Important

- Most of this is off-line reversing of the client binary. Where something depends on
  the live server, that is noted explicitly.
- Live server test results are stored in `pentest_scratch/` and `audit_scratch/`, not
  inferred here.
