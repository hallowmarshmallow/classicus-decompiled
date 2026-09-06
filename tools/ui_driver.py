#!/usr/bin/env python3
"""Owns Xvfb + game processes inside ONE tool call (children are reaped between
calls here, and background jobs that outlive the command swallow its output).

All spawned processes are children of this process and are killed before it
prints/exits, so stdout is never held open by a ghost.

Usage:
  python3 tools/ui_driver.py menu <gameexe>          # boot to main menu, OCR dump
  python3 tools/ui_driver.py shell <script.py>       # run a prepared phase script
"""
import subprocess, sys, time, os, json, re

DISPLAY = ":77"

def run(cmd, **kw):
    return subprocess.run(cmd, shell=True, capture_output=True, text=True, **kw)

def xdo(*args):
    return run(f"DISPLAY={DISPLAY} xdotool {' '.join(args)}")

def wait_window(proc, timeout):
    t0 = time.time()
    while time.time() - t0 < timeout and proc.poll() is None:
        out = xdo("search --onlyvisible --name '.*' getwindowname %@ 2>/dev/null").stdout
        if out.strip():
            return out.strip().splitlines()
        time.sleep(3)
    return []

def ocr_words(tag):
    run(f"DISPLAY={DISPLAY} scrot /tmp/ui_{tag}.png")
    run(f"tesseract /tmp/ui_{tag}.png /tmp/ui_{tag} tsv 2>/dev/null")
    words = []
    try:
        for line in open(f"/tmp/ui_{tag}.tsv").read().splitlines()[1:]:
            f = line.split("\t")
            if len(f) >= 12 and f[11].strip():
                words.append((f[11].strip(), int(f[10]), int(f[6]), int(f[7]), int(f[8]), int(f[9])))
    except Exception:
        pass
    return words

def boot_game(exe, tag):
    d = os.path.dirname(exe)
    log = open(f"/tmp/cu_{tag}.log", "w")
    return subprocess.Popen(
        ["env", f"DISPLAY={DISPLAY}", "LIBGL_ALWAYS_SOFTWARE=1", os.path.abspath(exe),
         "-logFile", f"/tmp/cu_{tag}.log"],
        cwd=d, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)

def phase_menu(exe):
    xvfb = None
    game = None
    try:
        run("pkill -f 'Xvfb :77' >/dev/null 2>&1; pkill -f classicus2026 >/dev/null 2>&1")
        time.sleep(1)
        xvfb = subprocess.Popen(["Xvfb", ":77", "-screen", "0", "1280x800x24", "-nolisten", "tcp"],
                                stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
        time.sleep(2)
        game = boot_game(exe, "menu")
        wins = wait_window(game, 130)
        time.sleep(8)  # let menu settle / announcement popup render
        words = ocr_words("menu")
        print("WINDOWS:", wins)
        print("OCR WORDS (x,y conf text):")
        for w in sorted(words, key=lambda w: (w[2], w[3])):
            print(f"  {w[2]:4d},{w[3]:4d} conf={w[1]:3d} {w[0]}")
    finally:
        for p in (game, xvfb):
            if p: p.kill()
    return 0

if __name__ == "__main__":
    cmd = sys.argv[1]
    if cmd == "menu":
        sys.exit(phase_menu(sys.argv[2]))
