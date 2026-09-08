# Lobby / game-connect API (client-facing shape)

## What this documents

This is the lobby and game-connect side of the service that the client uses to find
and join rooms. It is separate from the account/identity API, though both are part of
the same online service.

## Discovery shape

The lobby surface is built around room discovery: listing active lobbies, filtering by
common lobby attributes, and connecting to a chosen room.

That kind of discovery is normal for a multiplayer game, but the exact amount of
metadata exposed matters. A lobby list that reveals host names, player counts, maps,
modes, and other live-room details is more informative than one that only exposes what
players need to join.

## Metadata exposure

Live lobby metadata can be useful for players, but it can also be useful for someone
who wants to target specific lobbies, hosts, or map/mode combinations.

If lobby entries expose host names and other identifying details without authentication,
then the public-facing lobby surface is doing more than simple matchmaking.

## Queryability

If the lobby catalog can be filtered many ways, that is convenient for clients but it
also makes enumeration and scraping easier if there is no access control.

A queryable public catalog is not automatically a vulnerability, but it is a surface
that should be deliberately designed rather than left open by default.

## Game-connect separation

Room discovery and room connection are not the same thing as account identity. A lobby
service can be public by design while the account service should be stricter. The risk
is when public lobby data is combined with weak account/auth behavior elsewhere.

## Fix shape

- Decide which lobby fields are public and which are not.
- If some fields are sensitive, do not return them to unauthenticated requests.
- If the catalog is meant to be public, still consider rate limits and basic abuse
  controls so it cannot be hammered or mined indiscriminately.
- Keep lobby discovery separate from account/auth trust. Discovery is not a substitute
  for verifying who can do what inside a room.

## Live-server note

The client only shows what the game is built to request. How much the server actually
returns, and to whom, is the real question. That is a server-side behavior question and
should be verified against the live service when possible.
