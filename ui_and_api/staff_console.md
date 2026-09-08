# Staff console (in-client admin CLI)

## What it is

The staff console is an in-client admin interface implemented by
`StaffTools.StaffMenuController`. It is present for everyone at game start, but
the actual execution path is supposed to be gated.

## Open path

- The console is tied to F5 in the stock build's console-open wiring.
- The controller updates every frame and polls for the open key once the local
  role state allows it.
- Opening is a local UI action; opening alone does not execute anything.

## Execution gate

- Console commands are executed through the command dispatcher, not through chat.
- The dispatcher checks staff status, permission bands, and rate limiting before
  it runs a command.
- That is the intended legitiate path for staff actions entered in the console.

## Role refresh

- The local role used by the console is refreshed from local state on a timer.
- That refresh combines a roster-derived role with a name-tag-prefix role check.
- Because the role can be derived from local name information, the console's access
  depends on client-visible identity signals, not only on a server-verified session.

## Why it matters for exploits

- The console itself is not the main exploit. The main exploit is anything that lets
  a client reach an execution path that should have been staff-only.
- The relay path is the clearest example: non-host staff actions were designed to be
  relayed to the host through RPC 97, but the host side did not re-validate that the
  relay sender was real staff.
- So a weak console gate is dangerous mainly when there is also a weak execution or
  relay path.

## Fix shape

- Console access should depend on a server-verified staff session, not only on a
  locally stored role field.
- Any command execution path that can cross the network should re-check authorization
  on the receiving side.
- Rate limiting and permission bands are good, but they do not replace sender
  authentication.

## Local-only note

- A locally crafted staff store can satisfy in-process staff checks on a machine that
  the game trusts as host. That is a host-local issue, not a remote lobby exploit by
  itself.
