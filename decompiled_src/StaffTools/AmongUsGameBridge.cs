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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_1()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_2()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_3()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_4()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_5()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_6()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_7()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__50_9()
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_10(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_11(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_12(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_13(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_14(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_15(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_16(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_17(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_18(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_19(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_35(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_36(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_20(string n)
		{
			throw null;
		}

		internal string _003CDispatch_003Eb__50_21(string n)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_22(PlayerControl a, PlayerControl b)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_23(PlayerControl a, PlayerControl b)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_24(PlayerControl a, PlayerControl b)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_25(PlayerControl a, PlayerControl b)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_26(PlayerControl a, PlayerControl b)
		{
			throw null;
		}

		internal void _003CDispatch_003Eb__50_27(PlayerControl a, PlayerControl b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass50_0()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__0()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__8()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_1
	{
		public PlayerControl t;

		public _003C_003Ec__DisplayClass50_1()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__28()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_2
	{
		public PlayerControl t;

		public _003C_003Ec__DisplayClass50_2()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__29()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_3
	{
		public PlayerControl t;

		public _003C_003Ec__DisplayClass50_3()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__30()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_4
	{
		public PlayerControl t;

		public _003C_003Ec__DisplayClass50_4()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__31()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_5
	{
		public int kd;

		public _003C_003Ec__DisplayClass50_5()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__32()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_6
	{
		public int dt;

		public _003C_003Ec__DisplayClass50_6()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__33()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_7
	{
		public int vt;

		public _003C_003Ec__DisplayClass50_7()
		{
			throw null;
		}

		internal GameActionResult _003CDispatch_003Eb__34()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoBounce_003Ed__115(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoDrift_003Ed__118(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoFlashColors_003Ed__121(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoLaunch_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		private Vector2 _003Cstart_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoLaunch_003Ed__77(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoLaunchDir_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		public Vector2 offset;

		private Vector2 _003Cstart_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoLaunchDir_003Ed__114(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoOrbit_003Ed__120(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoPingpong_003Ed__116(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoRevertSpeed_003Ed__109(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoRevertVisionAfter_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public PlayerControl t;

		public AmongUsGameBridge _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoRevertVisionAfter_003Ed__112(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoShake_003Ed__119(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoSpin_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float duration;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoSpin_003Ed__76(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoUnfreezeAfter_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public AmongUsGameBridge _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoUnfreezeAfter_003Ed__122(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoUploadAndBroadcastAudio_003Ed__56(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoZigzag_003Ed__117(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

	public AmongUsGameBridge()
	{
		throw null;
	}

	private static GameActionResult RunAsHost(GameAction action, CommandContext ctx, Func<GameActionResult> exec)
	{
		throw null;
	}

	private static bool RelayToHost(GameAction action, CommandContext ctx)
	{
		throw null;
	}

	public static void HandleStaffHostActionRelayRpc(MessageReader reader)
	{
		throw null;
	}

	public IEnumerable<GamePlayer> Players()
	{
		throw null;
	}

	public GameActionResult Execute(GameAction action, CommandContext ctx)
	{
		throw null;
	}

	private GameActionResult Dispatch(GameAction action, CommandContext ctx)
	{
		throw null;
	}

	private GameActionResult KickOrBan(CommandContext ctx, bool ban)
	{
		throw null;
	}

	private GameActionResult RequestUnban(CommandContext ctx)
	{
		throw null;
	}

	private GameActionResult PlayLobbyMusic(CommandContext ctx)
	{
		throw null;
	}

	private GameActionResult PlaySoundAction(CommandContext ctx)
	{
		throw null;
	}

	private static GameActionResult StopSoundsAction()
	{
		throw null;
	}

	private static IEnumerator CoUploadAndBroadcastAudio(string path, PlayerControl me, byte rpcId, Action<string> onLocalPlay, string label)
	{
		throw null;
	}

	private static string ExtractJsonStringField(string json, string field)
	{
		throw null;
	}

	private GameActionResult ToggleMute(CommandContext ctx, bool mute)
	{
		throw null;
	}

	private GameActionResult SetMoveable(CommandContext ctx, bool value)
	{
		throw null;
	}

	private GameActionResult SetMoveableAll(bool value)
	{
		throw null;
	}

	private GameActionResult Teleport(CommandContext ctx)
	{
		throw null;
	}

	private GameActionResult KickAll()
	{
		throw null;
	}

	private static int KickEveryone()
	{
		throw null;
	}

	private GameActionResult ShutdownServer()
	{
		throw null;
	}

	private GameActionResult RestartServer()
	{
		throw null;
	}

	private GameActionResult Shuffle()
	{
		throw null;
	}

	private GameActionResult Scatter(float radius, string verb)
	{
		throw null;
	}

	private GameActionResult ForceSync()
	{
		throw null;
	}

	private GameActionResult SystemAlert(CommandContext ctx, string prefix)
	{
		throw null;
	}

	private static void SetVisible(PlayerControl p, bool visible)
	{
		throw null;
	}

	private static void Snap(PlayerControl pc, Vector2 pos)
	{
		throw null;
	}

	private PlayerControl Require(CommandContext ctx, out GameActionResult fail)
	{
		throw null;
	}

	private static void Banner(string message, Color color)
	{
		throw null;
	}

	private static void Run(IEnumerator co)
	{
		throw null;
	}

	private static IEnumerator CoSpin(Transform t, float duration)
	{
		throw null;
	}

	private static IEnumerator CoLaunch(PlayerControl p)
	{
		throw null;
	}

	private static string DescribePositions()
	{
		throw null;
	}

	private static string DescribeServer(CommandContext ctx)
	{
		throw null;
	}

	private static string ModeName(byte id)
	{
		throw null;
	}

	private static int CountPlayers()
	{
		throw null;
	}

	private static bool TryParseColor(string s, out byte id)
	{
		throw null;
	}

	private static PlayerControl FindPlayer(string query)
	{
		throw null;
	}

	private static string Name(PlayerControl p)
	{
		throw null;
	}

	private static GamePlayer ToGamePlayer(PlayerControl pc)
	{
		throw null;
	}

	private static void SendFx(byte targetPlayerId, string message, Color color, byte soundId)
	{
		throw null;
	}

	private static void SendWarnRpc(byte targetPlayerId, string staffName, string reason)
	{
		throw null;
	}

	private static void FxAll(string message, Color color, byte soundId = 0)
	{
		throw null;
	}

	private static void FxTarget(PlayerControl t, string message, Color color, byte soundId = 0)
	{
		throw null;
	}

	private static void SfxAll(byte soundId)
	{
		throw null;
	}

	private static void SfxTarget(PlayerControl t, byte soundId)
	{
		throw null;
	}

	private GameActionResult FakePopupTarget(CommandContext ctx, string message, Color color, byte soundId = 0)
	{
		throw null;
	}

	private static GameActionResult FakePopupAll(string message, Color color, byte soundId = 0)
	{
		throw null;
	}

	private static GameActionResult BroadcastRandom(string[] pool, string prefix = null)
	{
		throw null;
	}

	private static PlayerControl RandomAlivePlayer(PlayerControl exclude = null)
	{
		throw null;
	}

	private static bool TwoRandomAlivePlayers(out PlayerControl a, out PlayerControl b)
	{
		throw null;
	}

	private GameActionResult SwapField(Action<PlayerControl, PlayerControl> apply, string label)
	{
		throw null;
	}

	private GameActionResult ApplyNameTransform(CommandContext ctx, Func<string, string> transform)
	{
		throw null;
	}

	private static string ReverseText(string s)
	{
		throw null;
	}

	private static string UpsideDownText(string s)
	{
		throw null;
	}

	private static string Spongebobify(string s)
	{
		throw null;
	}

	private static string Zalgofy(string s)
	{
		throw null;
	}

	private GameActionResult ApplyScale(CommandContext ctx, float sx, float sy)
	{
		throw null;
	}

	private GameActionResult ApplyScaleAll(float sx, float sy, string verb)
	{
		throw null;
	}

	private GameActionResult ApplySpeedMultiplier(CommandContext ctx, float multiplier, float duration)
	{
		throw null;
	}

	private IEnumerator CoRevertSpeed(PlayerControl t, float baseSpeed, float duration)
	{
		throw null;
	}

	private GameActionResult ApplySpeedMultiplierAll(float multiplier, float duration, string verb)
	{
		throw null;
	}

	private GameActionResult ApplyVisionAll(float value, string verb)
	{
		throw null;
	}

	private IEnumerator CoRevertVisionAfter(PlayerControl t, float seconds)
	{
		throw null;
	}

	private GameActionResult ResetVisionAllPlayers()
	{
		throw null;
	}

	private static IEnumerator CoLaunchDir(PlayerControl p, Vector2 offset)
	{
		throw null;
	}

	private static IEnumerator CoBounce(PlayerControl p, int bounces, float height)
	{
		throw null;
	}

	private static IEnumerator CoPingpong(PlayerControl p, int cycles, float distance)
	{
		throw null;
	}

	private static IEnumerator CoZigzag(PlayerControl p, int steps, float distance)
	{
		throw null;
	}

	private static IEnumerator CoDrift(PlayerControl p, float duration, float speed)
	{
		throw null;
	}

	private static IEnumerator CoShake(PlayerControl p, float duration)
	{
		throw null;
	}

	private static IEnumerator CoOrbit(PlayerControl p, Vector2 center, float radius, float duration)
	{
		throw null;
	}

	private static IEnumerator CoFlashColors(PlayerControl p, float duration)
	{
		throw null;
	}

	private IEnumerator CoUnfreezeAfter(float seconds)
	{
		throw null;
	}

	private GameActionResult EmoteAll()
	{
		throw null;
	}

	private static string RandomHatId()
	{
		throw null;
	}

	private static string RandomPetId()
	{
		throw null;
	}

	private static string RandomSkinId()
	{
		throw null;
	}

	private static GameActionResult ForceSabotage(CommandContext ctx)
	{
		throw null;
	}

	private static GameActionResult FixSabotage()
	{
		throw null;
	}

	private static GameActionResult ToggleDoorsAction()
	{
		throw null;
	}

	private static GameActionResult SyncOptions(string detail)
	{
		throw null;
	}

	static AmongUsGameBridge()
	{
		throw null;
	}
}
