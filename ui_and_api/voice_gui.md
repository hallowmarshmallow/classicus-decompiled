# Voice GUI and voice path

## What this covers

This is the in-client voice UI and the surrounding audio-pipeline shape that the
decompiled code exposes. It is not a claim about what the live voice server does
beyond what the client's own code implies.

## UI role

- The voice UI is the local control surface for mute, push-to-talk, and related
  local playback/sending state.
- As with most in-game UIs, the client can show, hide, and toggle local state, but
  the important question for security is which voice behaviors are validated outside
  the client.

## Local pipeline

- The client code includes local audio capture, buffering, noise suppression, and
  playback reference handling.
- That means the client is doing real work on the audio path, not just forwarding a
  raw stream untouched.

## Where authority matters

- Voice abuse is only a server/room issue when the room authority or voice relay
  trusts the client too much.
- For example, if a client can assert who is talking, who is muted, or what stream
  belongs to whom, and the room just accepts that, then the voice path becomes another
  client-controlled input.
- The more the room authority has to infer from peer-supplied state, the more room
  there is for spoofing, muting abuse, or identity confusion.

## Relay shape

- The game's comms voice work includes relay-style bridging concepts. If voice
  control actions can be relayed or forwarded through the same kind of host-dependent
  path as other staff/chat commands, then voice UI actions can inherit the same class
  of trust problems.
- That does not mean voice is automatically exploitable. It means the voice surface
  should be audited with the same question applied everywhere else: who is allowed to
  cause this effect, and is that checked on the authority side?

## Fix shape

- Voice state that affects other players should be validated or inferred by the
  authority, not taken verbatim from a peer.
- Mute/kick/ban-style voice moderation should follow the same auth model as other
  moderation actions.
- If there is a voice relay, it should authenticate the source of each action, not
  just pass through whatever the client requests.

## What is not in scope here

- This folder documents the client-side shape. The live voice server behavior is a
  separate question and would need its own verification against the real service.
