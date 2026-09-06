using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;
using UnityEngine.Networking;

namespace StaffTools;

public sealed class AmongUsGameBridge : IGameBridge
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameActionResult> _003C_003E9__50_1;

		public static Func<GameActionResult> _003C_003E9__50_2;

		public static Func<GameActionResult> _003C_003E9__50_3;

		public static Func<GameActionResult> _003C_003E9__50_4;

		public static Func<GameActionResult> _003C_003E9__50_5;

		public static Func<GameActionResult> _003C_003E9__50_6;

		public static Func<GameActionResult> _003C_003E9__50_7;

		public static Func<GameActionResult> _003C_003E9__50_9;

		public static Func<string, string> _003C_003E9__50_10;

		public static Func<string, string> _003C_003E9__50_11;

		public static Func<string, string> _003C_003E9__50_12;

		public static Func<string, string> _003C_003E9__50_13;

		public static Func<string, string> _003C_003E9__50_14;

		public static Func<string, string> _003C_003E9__50_15;

		public static Func<string, string> _003C_003E9__50_16;

		public static Func<string, string> _003C_003E9__50_17;

		public static Func<string, string> _003C_003E9__50_18;

		public static Func<string, string> _003C_003E9__50_19;

		public static Func<string, string> _003C_003E9__50_35;

		public static Func<string, string> _003C_003E9__50_36;

		public static Func<string, string> _003C_003E9__50_20;

		public static Func<string, string> _003C_003E9__50_21;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_22;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_23;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_24;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_25;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_26;

		public static Action<PlayerControl, PlayerControl> _003C_003E9__50_27;

		internal GameActionResult _003CDispatch_003Eb__50_1()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_2()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_3()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_4()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_5()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_6()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_7()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_9()
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_10(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_11(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_12(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_13(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_14(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_15(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_16(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_17(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_18(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_19(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_35(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_36(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_20(string n)
		{
			return null;
		}

		internal string _003CDispatch_003Eb__50_21(string n)
		{
			return null;
		}

		internal void _003CDispatch_003Eb__50_22(PlayerControl a, PlayerControl b)
		{
		}

		internal void _003CDispatch_003Eb__50_23(PlayerControl a, PlayerControl b)
		{
		}

		internal void _003CDispatch_003Eb__50_24(PlayerControl a, PlayerControl b)
		{
		}

		internal void _003CDispatch_003Eb__50_25(PlayerControl a, PlayerControl b)
		{
		}

		internal void _003CDispatch_003Eb__50_26(PlayerControl a, PlayerControl b)
		{
		}

		internal void _003CDispatch_003Eb__50_27(PlayerControl a, PlayerControl b)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public CommandContext ctx;

		internal GameActionResult _003CDispatch_003Eb__0()
		{
			return null;
		}

		internal GameActionResult _003CDispatch_003Eb__8()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_1
	{
		public PlayerControl t;

		internal GameActionResult _003CDispatch_003Eb__28()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_2
	{
		public PlayerControl t;

		internal GameActionResult _003CDispatch_003Eb__29()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_3
	{
		public PlayerControl t;

		internal GameActionResult _003CDispatch_003Eb__30()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_4
	{
		public PlayerControl t;

		internal GameActionResult _003CDispatch_003Eb__31()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_5
	{
		public int kd;

		internal GameActionResult _003CDispatch_003Eb__32()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_6
	{
		public int dt;

		internal GameActionResult _003CDispatch_003Eb__33()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_7
	{
		public int vt;

		internal GameActionResult _003CDispatch_003Eb__34()
		{
			return null;
		}
	}

	private sealed class _003CCoBounce_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float height;

		public int bounces;

		private Vector2 _003Cstart_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBounce_003Ed__115(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoDrift_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float speed;

		public float duration;

		private Vector2 _003Cdir_003E5__2;

		private float _003Celapsed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDrift_003Ed__118(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoFlashColors_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float duration;

		private byte _003Corig_003E5__2;

		private float _003Celapsed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFlashColors_003Ed__121(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoLaunch_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		private Vector2 _003Cstart_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoLaunch_003Ed__77(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoLaunchDir_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public Vector2 offset;

		private Vector2 _003Cstart_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoLaunchDir_003Ed__114(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoOrbit_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float radius;

		public Vector2 center;

		public float duration;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoOrbit_003Ed__120(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoPingpong_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float distance;

		public int cycles;

		private Vector2 _003Cstart_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPingpong_003Ed__116(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoRevertSpeed_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public PlayerControl t;

		public float baseSpeed;

		public AmongUsGameBridge _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRevertSpeed_003Ed__109(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoRevertVisionAfter_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public PlayerControl t;

		public AmongUsGameBridge _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRevertVisionAfter_003Ed__112(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoShake_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float duration;

		private Vector2 _003Cstart_003E5__2;

		private float _003Celapsed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShake_003Ed__119(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoSpin_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float duration;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSpin_003Ed__76(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoUnfreezeAfter_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public AmongUsGameBridge _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoUnfreezeAfter_003Ed__122(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoUploadAndBroadcastAudio_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public string label;

		public PlayerControl me;

		public byte rpcId;

		public Action<string> onLocalPlay;

		private string _003Cip_003E5__2;

		private ushort _003Cport_003E5__3;

		private UnityWebRequest _003Creq_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoUploadAndBroadcastAudio_003Ed__56(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoZigzag_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public float distance;

		public int steps;

		private Vector2 _003Cpos_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoZigzag_003Ed__117(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static AmongUsGameBridge _instance;

	private readonly Dictionary<byte, string> _origName;

	private readonly Dictionary<byte, float> _origSpeed;

	private readonly Dictionary<byte, float> _origVision;

	private readonly Dictionary<byte, Vector3> _origScale;

	private readonly HashSet<byte> _muted;

	private readonly HashSet<byte> _ghosts;

	private bool _showHitboxes;

	private bool _noclip;

	private bool _vanished;

	private bool _reverseAudioAll;

	private static readonly string[] Jokes;

	private static readonly string[] Facts;

	private static readonly string[] Quotes;

	private static readonly string[] Insults;

	private static readonly string[] Compliments;

	private static readonly string[] Riddles;

	private static readonly string[] Horoscopes;

	private static readonly string[] EightBall;

	private static readonly string[] Fortunes;

	private static readonly string[] Titles;

	private static readonly string[] Nicknames;

	private static readonly string[] Awards;

	private static readonly string[] RainbowTags;

	private static readonly Dictionary<char, char> UpsideDownMap;

	private static readonly SystemTypes[] DoorRooms;

	private static GameActionResult RunAsHost(GameAction action, CommandContext ctx, Func<GameActionResult> exec)
	{
		return null;
	}

	private static bool RelayToHost(GameAction action, CommandContext ctx)
	{
		return false;
	}

	public static void HandleStaffHostActionRelayRpc(MessageReader reader)
	{
	}

	public IEnumerable<GamePlayer> Players()
	{
		return null;
	}

	public GameActionResult Execute(GameAction action, CommandContext ctx)
	{
		return null;
	}

	private GameActionResult Dispatch(GameAction action, CommandContext ctx)
	{
		return null;
	}

	private GameActionResult KickOrBan(CommandContext ctx, bool ban)
	{
		return null;
	}

	private GameActionResult RequestUnban(CommandContext ctx)
	{
		return null;
	}

	private GameActionResult PlayLobbyMusic(CommandContext ctx)
	{
		return null;
	}

	private GameActionResult PlaySoundAction(CommandContext ctx)
	{
		return null;
	}

	private static GameActionResult StopSoundsAction()
	{
		return null;
	}

	private static IEnumerator CoUploadAndBroadcastAudio(string path, PlayerControl me, byte rpcId, Action<string> onLocalPlay, string label)
	{
		return null;
	}

	private static string ExtractJsonStringField(string json, string field)
	{
		return null;
	}

	private GameActionResult ToggleMute(CommandContext ctx, bool mute)
	{
		return null;
	}

	private GameActionResult SetMoveable(CommandContext ctx, bool value)
	{
		return null;
	}

	private GameActionResult SetMoveableAll(bool value)
	{
		return null;
	}

	private GameActionResult Teleport(CommandContext ctx)
	{
		return null;
	}

	private GameActionResult KickAll()
	{
		return null;
	}

	private static int KickEveryone()
	{
		return 0;
	}

	private GameActionResult ShutdownServer()
	{
		return null;
	}

	private GameActionResult RestartServer()
	{
		return null;
	}

	private GameActionResult Shuffle()
	{
		return null;
	}

	private GameActionResult Scatter(float radius, string verb)
	{
		return null;
	}

	private GameActionResult ForceSync()
	{
		return null;
	}

	private GameActionResult SystemAlert(CommandContext ctx, string prefix)
	{
		return null;
	}

	private static void SetVisible(PlayerControl p, bool visible)
	{
	}

	private static void Snap(PlayerControl pc, Vector2 pos)
	{
	}

	private PlayerControl Require(CommandContext ctx, out GameActionResult fail)
	{
		fail = null;
		return null;
	}

	private static void Banner(string message, Color color)
	{
	}

	private static void Run(IEnumerator co)
	{
	}

	private static IEnumerator CoSpin(Transform t, float duration)
	{
		return null;
	}

	private static IEnumerator CoLaunch(PlayerControl p)
	{
		return null;
	}

	private static string DescribePositions()
	{
		return null;
	}

	private static string DescribeServer(CommandContext ctx)
	{
		return null;
	}

	private static string ModeName(byte id)
	{
		return null;
	}

	private static int CountPlayers()
	{
		return 0;
	}

	private static bool TryParseColor(string s, out byte id)
	{
		id = default(byte);
		return false;
	}

	private static PlayerControl FindPlayer(string query)
	{
		return null;
	}

	private static string Name(PlayerControl p)
	{
		return null;
	}

	private static GamePlayer ToGamePlayer(PlayerControl pc)
	{
		return null;
	}

	private static void SendFx(byte targetPlayerId, string message, Color color, byte soundId)
	{
	}

	private static void SendWarnRpc(byte targetPlayerId, string staffName, string reason)
	{
	}

	private static void FxAll(string message, Color color, byte soundId = 0)
	{
	}

	private static void FxTarget(PlayerControl t, string message, Color color, byte soundId = 0)
	{
	}

	private static void SfxAll(byte soundId)
	{
	}

	private static void SfxTarget(PlayerControl t, byte soundId)
	{
	}

	private GameActionResult FakePopupTarget(CommandContext ctx, string message, Color color, byte soundId = 0)
	{
		return null;
	}

	private static GameActionResult FakePopupAll(string message, Color color, byte soundId = 0)
	{
		return null;
	}

	private static GameActionResult BroadcastRandom(string[] pool, string prefix = null)
	{
		return null;
	}

	private static PlayerControl RandomAlivePlayer(PlayerControl exclude = null)
	{
		return null;
	}

	private static bool TwoRandomAlivePlayers(out PlayerControl a, out PlayerControl b)
	{
		a = null;
		b = null;
		return false;
	}

	private GameActionResult SwapField(Action<PlayerControl, PlayerControl> apply, string label)
	{
		return null;
	}

	private GameActionResult ApplyNameTransform(CommandContext ctx, Func<string, string> transform)
	{
		return null;
	}

	private static string ReverseText(string s)
	{
		return null;
	}

	private static string UpsideDownText(string s)
	{
		return null;
	}

	private static string Spongebobify(string s)
	{
		return null;
	}

	private static string Zalgofy(string s)
	{
		return null;
	}

	private GameActionResult ApplyScale(CommandContext ctx, float sx, float sy)
	{
		return null;
	}

	private GameActionResult ApplyScaleAll(float sx, float sy, string verb)
	{
		return null;
	}

	private GameActionResult ApplySpeedMultiplier(CommandContext ctx, float multiplier, float duration)
	{
		return null;
	}

	private IEnumerator CoRevertSpeed(PlayerControl t, float baseSpeed, float duration)
	{
		return null;
	}

	private GameActionResult ApplySpeedMultiplierAll(float multiplier, float duration, string verb)
	{
		return null;
	}

	private GameActionResult ApplyVisionAll(float value, string verb)
	{
		return null;
	}

	private IEnumerator CoRevertVisionAfter(PlayerControl t, float seconds)
	{
		return null;
	}

	private GameActionResult ResetVisionAllPlayers()
	{
		return null;
	}

	private static IEnumerator CoLaunchDir(PlayerControl p, Vector2 offset)
	{
		return null;
	}

	private static IEnumerator CoBounce(PlayerControl p, int bounces, float height)
	{
		return null;
	}

	private static IEnumerator CoPingpong(PlayerControl p, int cycles, float distance)
	{
		return null;
	}

	private static IEnumerator CoZigzag(PlayerControl p, int steps, float distance)
	{
		return null;
	}

	private static IEnumerator CoDrift(PlayerControl p, float duration, float speed)
	{
		return null;
	}

	private static IEnumerator CoShake(PlayerControl p, float duration)
	{
		return null;
	}

	private static IEnumerator CoOrbit(PlayerControl p, Vector2 center, float radius, float duration)
	{
		return null;
	}

	private static IEnumerator CoFlashColors(PlayerControl p, float duration)
	{
		return null;
	}

	private IEnumerator CoUnfreezeAfter(float seconds)
	{
		return null;
	}

	private GameActionResult EmoteAll()
	{
		return null;
	}

	private static string RandomHatId()
	{
		return null;
	}

	private static string RandomPetId()
	{
		return null;
	}

	private static string RandomSkinId()
	{
		return null;
	}

	private static GameActionResult ForceSabotage(CommandContext ctx)
	{
		return null;
	}

	private static GameActionResult FixSabotage()
	{
		return null;
	}

	private static GameActionResult ToggleDoorsAction()
	{
		return null;
	}

	private static GameActionResult SyncOptions(string detail)
	{
		return null;
	}
}
