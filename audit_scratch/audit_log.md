# Audit log — audit_scratch deep pass

Date: fresh pass over the 2026.9.5 decompiled source + existing binary annotations.
Scope: `decompiled_src_95` (1088 C# skeletons) plus `classicus_exploits.txt` and the
annotated dumps as the source of truth for holes/gates.

What was scanned:

- All `.cs` files for `HandleRpc` implementations.
  Result: 13 managed types touch `HandleRpc`; the main one is `PlayerControl`
  with a 98-slot switch (0..97).
- All `.cs` files for IMGUI-family references.
  Result: 8 files reference `OnGUI`/`GUILayout`/`GUI.Draw`/`EditorGUILayout`/
  `EditorGUI`/`IMGUI`. Only a handful are real game UI.
- All `.cs` files for per-frame lifecycle / settings / quit flow.
  Result: a large set (~400 files) touch `Update`/`FixedUpdate`/`LateUpdate`/
  `StartCoroutine`/`Application.Quit`/settings/save; most are generic component
  behavior, not core harnesses.
- All `.cs` files for room flow / lobby / discovery.
  Result: ~22 files touch the room/lobby/discovery flow.
- All `.cs` files for HTTP / staff service / remote call clients.
  Result: ~20 files touch HTTP/remote/staff-service clients.
- All `.cs` files for RPC send helpers.
  Result: a small set, dominated by `InnerNetClient`, `PlayerControl`, and the
  staff audio send types.

What this pass confirmed:

- The managed dispatch surface is small and enumerable.
- The biggest remaining mystery is not a missing RPC id; it is role abilities
  via `RoleBehaviour.HandleRpc` / `PlayerControl.HandleRpc` id 25, voice RPC 29,
  and the live-server-dependent staff backend behavior.

What is still binary-only and not fully resolved by the decompiled source:

- Exact bodies of many `HandleRpc` case blocks (decompiled skeletons are stubs).
- Exact vtable slot / sub-id behavior for `RoleBehaviour.HandleRpc`.
- Exact voice frame format for RPC 29.
- Live-server-dependent staff backend trust decisions.

Folders created:

- `exploits/` — network/dispatch surfaces + known exploits 1-24 + new surfaces
- `ui/` — IMGUI + pop-up + lobby/HUD surfaces
- `api_harness/` — RPC send/recv + per-frame + HTTP/staff + interop entry points
