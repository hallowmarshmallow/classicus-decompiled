#!/usr/bin/env python3
"""Decode IL2CPP switch jump tables from GameAssembly.so.

For each function RVA given on argv (label=rva hex), disassembles a window,
locates RIP-relative indirect jump tables, decodes case ranges, and prints
each live case's opening instructions annotated with resolved callee names.

Usage:
  python3 tools/sweep_tables.py 0x10ebfb0:PlayerControl.HandleRpc 0xfd55b0:RoleBehaviour.HandleRpc ... > out.txt
"""
import json, os, re, subprocess, sys, struct, tempfile

GAME = "Classic Us 2026.9.5 Linux/Classic Us 2026.9.5 Linux/GameAssembly.so"
ANNOT = "annotate95.py"

meth = {}
for m in json.load(open('il2cpp_dump_95/script.json'))['ScriptMethod']:
    meth[m['Address']] = m['Name']

def disasm(start, stop):
    p = subprocess.run(
        ["objdump", "-d", "--start-address=%d" % start, "--stop-address=%d" % stop, GAME],
        capture_output=True, text=True)
    return p.stdout

def annotate_text(text):
    with tempfile.NamedTemporaryFile('w', suffix='.txt', delete=False) as f:
        f.write(text)
        tmp = f.name
    try:
        p = subprocess.run([sys.executable, ANNOT, tmp], capture_output=True, text=True)
        return p.stdout
    finally:
        os.unlink(tmp)

def read_bin(addr, n):
    with open(GAME, "rb") as f:
        f.seek(addr)
        return f.read(n)

def find_jmptable(lines):
    """Find RIP-relative indirect jumps: 'jmpq *0xHEX(%rip)'. Return (table_addr, instr_addr)."""
    for ln in lines:
        m = re.search(r'^\s*([0-9a-f]+):\s+ff\s+25\s+([0-9a-f]+)', ln)  # ff 25 = jmpq *disp(%rip)
        if m:
            ins = int(m.group(1), 16)
            disp = int(m.group(2), 16)
            return ins + 6 + disp, ins
    return None, None

def decode_table(taddr, fn_lo, fn_hi, max_entries=256):
    """IL2CPP switch tables: int32 offsets relative to table base. Return {idx: target}."""
    out = {}
    raw = read_bin(taddr, max_entries * 4)
    for i in range(max_entries):
        rel = struct.unpack_from('<i', raw, i * 4)[0]
        tgt = taddr + rel
        if tgt == taddr:
            break  # sentinel
        out[i] = tgt
    # sanity: at least 3 targets inside function window
    good = [v for v in out.values() if fn_lo <= v < fn_hi]
    return out if len(good) >= 3 else {}

def build_case_map(lines, table_entries):
    """Group consecutive instruction lines by address so we can slice case blocks."""
    addr_line = {}
    for ln in lines:
        m = re.match(r'^\s*([0-9a-f]+):', ln)
        if m:
            addr_line[int(m.group(1), 16)] = ln
    return addr_line

def main():
    tasks = []
    for a in sys.argv[1:]:
        label, rva_s = a.split('=', 1)
        rva = int(rva_s, 16)
        tasks.append((label, rva))

    for label, rva in tasks:
        print("\n" + "=" * 90)
        print(f"FUNCTION {label} @ 0x{rva:x}")
        print("=" * 90)
        fn_lo, fn_hi = rva, rva + 0xA000
        text = disasm(fn_lo, fn_hi)
        ann = annotate_text(text)
        lines = ann.splitlines()
        taddr, _ = find_jmptable(lines)
        if taddr is None:
            print("  !! no RIP-relative jmp-table found; likely an if-chain dispatcher")
            print(ann[:4000])
            continue
        entries = decode_table(taddr, fn_lo, fn_hi)
        if not entries:
            print(f"  !! table at 0x{taddr:x} did not decode; raw head:")
            print(read_bin(taddr, 64).hex())
            continue
        print(f"  jmp-table @ 0x{taddr:x}, {len(entries)} entries")
        addr_line = build_case_map(lines, entries)
        # group targets by case-block start
        seen = {}
        for idx, tgt in sorted(entries.items()):
            if tgt not in seen:
                seen[tgt] = []
            seen[tgt].append(idx)
        # find contiguous runs of ids per target, print
        for tgt, ids in sorted(seen.items()):
            ids.sort()
            runs = []
            s = p = ids[0]
            for i in ids[1:]:
                if i == p + 1:
                    p = i
                else:
                    runs.append((s, p)); s = p = i
            runs.append((s, p))
            rng = ",".join(f"{a}" if a == b else f"{a}-{b}" for a, b in runs)
            print(f"\n  --- ids [{rng}] -> case @ 0x{tgt:x} ---")
            # print first 14 instruction lines of this case
            cnt = 0
            for a in sorted(addr_line):
                if a >= tgt and cnt < 14:
                    print("   " + addr_line[a])
                    cnt += 1
                elif a >= tgt and cnt >= 14:
                    break

if __name__ == '__main__':
    main()
