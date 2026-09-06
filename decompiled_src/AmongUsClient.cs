using System;
using System.Collections;
using System.Collections.Generic;
using InnerNet;
using UnityEngine.SceneManagement;

public class AmongUsClient : InnerNetClient
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PlayerControl> _003C_003E9__10_0;

		public static Func<PlayerControl, bool> _003C_003E9__18_0;

		public static Func<PlayerControl, bool> _003C_003E9__21_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CResetGameplaySessionState_003Eb__10_0(PlayerControl player)
		{
			throw null;
		}

		internal bool _003CCoStartGame_003Eb__18_0(PlayerControl p)
		{
			throw null;
		}

		internal bool _003CTryStartGame_003Eb__21_0(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003CCoBroadcastManager_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		private int _003ClastPlayerCount_003E5__2;

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

		public _003CCoBroadcastManager_003Ed__42(int _003C_003E1__state)
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

	private sealed class _003CCoEndGame_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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

		public _003CCoEndGame_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CCoRecoverMissingStartGame_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		private float _003Cwaited_003E5__2;

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

		public _003CCoRecoverMissingStartGame_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoRetrySetShip_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShipHolder shipHolder;

		public string map;

		private float _003CretryDelay_003E5__2;

		private int _003Cretry_003E5__3;

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

		public _003CCoRetrySetShip_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CCoSceneChangeSweep_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string fromName;

		public string toName;

		private long _003CgfxBefore_003E5__2;

		private long _003CnatBefore_003E5__3;

		private long _003CmonoBefore_003E5__4;

		private int _003CtexBefore_003E5__5;

		private float _003CstartedAt_003E5__6;

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

		public _003CCoSceneChangeSweep_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CCoStartGame_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		private float _003CdataWaitTimeout_003E5__2;

		private float _003CdataWait_003E5__3;

		private float _003CnextDataLog_003E5__4;

		private float _003ChostReadyTimeout_003E5__5;

		private float _003Ctimer_003E5__6;

		private float _003CnextProgressLog_003E5__7;

		private float _003CnextRepair_003E5__8;

		private string _003Cmap_003E5__9;

		private ShipHolder _003CshipHolder_003E5__10;

		private bool _003CstopWaiting_003E5__11;

		private float _003CnextReadyLog_003E5__12;

		private float _003ClocalStartDataWait_003E5__13;

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

		public _003CCoStartGame_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CCreatePlayer_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientData clientData;

		public AmongUsClient _003C_003E4__this;

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

		public _003CCreatePlayer_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CTryStartGame_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

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

		public _003CTryStartGame_003Ed__21(int _003C_003E1__state)
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

	public const int FakeClientId = 2147483646;

	public static readonly HashSet<byte> StaffDummyIds;

	private const string SceneSweepTag = "[MapMemory/SceneSweep]";

	private const string SceneSweepOwner = "AmongUsClient.OnActiveSceneChange";

	private const float SceneSweepCooldownSeconds = 20f;

	private bool sceneSweepHooked;

	public static AmongUsClient Instance;

	public GameModes GameMode;

	public string OnlineScene;

	public string MainMenuScene;

	public GameData GameDataPrefab;

	public PlayerControl PlayerPrefab;

	public ShipHolder ShipHolderPrefab;

	public bool disableEnd;

	public string TutorialMapName;

	public float SpawnRadius;

	public DiscoveryState discoverState;

	public List<IDisconnectHandler> DisconnectHandlers;

	public List<IGameListHandler> GameListHandlers;

	public void Awake()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	private void HookSceneChangeSweep()
	{
		throw null;
	}

	private void UnhookSceneChangeSweep()
	{
		throw null;
	}

	private bool IsGameplayScene(string sceneName)
	{
		throw null;
	}

	private void OnActiveSceneChange(Scene from, Scene to)
	{
		throw null;
	}

	private IEnumerator CoSceneChangeSweep(string fromName, string toName)
	{
		throw null;
	}

	protected override byte[] GetConnectionData()
	{
		throw null;
	}

	public void StartGame()
	{
		throw null;
	}

	public void ExitGame(DisconnectReasons reason = DisconnectReasons.ExitGame)
	{
		throw null;
	}

	private void ResetGameplaySessionState(bool clearDisconnectHandlers)
	{
		throw null;
	}

	public new void DisconnectSilently()
	{
		throw null;
	}

	public new void Connect(MatchMakerModes mode)
	{
		throw null;
	}

	protected override void OnGetGameList(List<GameListing> availableGames)
	{
		throw null;
	}

	protected override void OnGameCreated(string gameIdString)
	{
		throw null;
	}

	protected override void OnWaitForHost(string gameIdString)
	{
		throw null;
	}

	protected override void OnStartGame()
	{
		throw null;
	}

	private static string DescribeClientForLoadLog(ClientData c)
	{
		throw null;
	}

	private IEnumerator CoStartGame()
	{
		throw null;
	}

	private IEnumerator CoRecoverMissingStartGame()
	{
		throw null;
	}

	private bool StillWaitingForIntro()
	{
		throw null;
	}

	public IEnumerator TryStartGame()
	{
		throw null;
	}

	public void KickNotJoinedPlayers()
	{
		throw null;
	}

	protected override void OnBecomeHost()
	{
		throw null;
	}

	private void AdoptOrphanedDummies()
	{
		throw null;
	}

	protected override void OnGameEnd(GameOverReason gameOverReason, bool showAd)
	{
		throw null;
	}

	public bool DoesMapExist(int mapId)
	{
		throw null;
	}

	public IEnumerator CoEndGame()
	{
		throw null;
	}

	protected override void OnPlayerJoined(ClientData data)
	{
		throw null;
	}

	protected override void OnAutoRejoin(int gameId)
	{
		throw null;
	}

	protected override void OnGameJoined(string gameIdString, ClientData data)
	{
		throw null;
	}

	public void PlayerControlLeft(PlayerControl character, DisconnectReasons reason)
	{
		throw null;
	}

	protected override void OnPlayerLeft(ClientData data, DisconnectReasons reason)
	{
		throw null;
	}

	protected override void OnDisconnected()
	{
		throw null;
	}

	protected override void OnPlayerChangedScene(ClientData client, string currentScene)
	{
		throw null;
	}

	public void SpawnTester()
	{
		throw null;
	}

	public PlayerControl SpawnDummy(bool hostile)
	{
		throw null;
	}

	public int RemoveStaffDummies()
	{
		throw null;
	}

	private IEnumerator CreatePlayer(ClientData clientData)
	{
		throw null;
	}

	private IEnumerator CoRetrySetShip(ShipHolder shipHolder, string map)
	{
		throw null;
	}

	private IEnumerator CoBroadcastManager()
	{
		throw null;
	}

	public AmongUsClient()
	{
		throw null;
	}

	static AmongUsClient()
	{
		throw null;
	}
}
