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

		internal bool _003CResetGameplaySessionState_003Eb__10_0(PlayerControl player)
		{
			return false;
		}

		internal bool _003CCoStartGame_003Eb__18_0(PlayerControl p)
		{
			return false;
		}

		internal bool _003CTryStartGame_003Eb__21_0(PlayerControl p)
		{
			return false;
		}
	}

	private sealed class _003CCoBroadcastManager_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		private int _003ClastPlayerCount_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBroadcastManager_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CCoEndGame_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoEndGame_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CCoRecoverMissingStartGame_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		private float _003Cwaited_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRecoverMissingStartGame_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoRetrySetShip_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShipHolder shipHolder;

		public string map;

		private float _003CretryDelay_003E5__2;

		private int _003Cretry_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRetrySetShip_003Ed__40(int _003C_003E1__state)
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSceneChangeSweep_003Ed__6(int _003C_003E1__state)
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartGame_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CCreatePlayer_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientData clientData;

		public AmongUsClient _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreatePlayer_003Ed__39(int _003C_003E1__state)
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

	private sealed class _003CTryStartGame_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmongUsClient _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryStartGame_003Ed__21(int _003C_003E1__state)
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
	}

	public override void OnDestroy()
	{
	}

	private void HookSceneChangeSweep()
	{
	}

	private void UnhookSceneChangeSweep()
	{
	}

	private bool IsGameplayScene(string sceneName)
	{
		return false;
	}

	private void OnActiveSceneChange(Scene from, Scene to)
	{
	}

	private IEnumerator CoSceneChangeSweep(string fromName, string toName)
	{
		return null;
	}

	protected override byte[] GetConnectionData()
	{
		return null;
	}

	public void StartGame()
	{
	}

	public void ExitGame(DisconnectReasons reason = DisconnectReasons.ExitGame)
	{
	}

	private void ResetGameplaySessionState(bool clearDisconnectHandlers)
	{
	}

	public new void DisconnectSilently()
	{
	}

	public new void Connect(MatchMakerModes mode)
	{
	}

	protected override void OnGetGameList(List<GameListing> availableGames)
	{
	}

	protected override void OnGameCreated(string gameIdString)
	{
	}

	protected override void OnWaitForHost(string gameIdString)
	{
	}

	protected override void OnStartGame()
	{
	}

	private static string DescribeClientForLoadLog(ClientData c)
	{
		return null;
	}

	private IEnumerator CoStartGame()
	{
		return null;
	}

	private IEnumerator CoRecoverMissingStartGame()
	{
		return null;
	}

	private bool StillWaitingForIntro()
	{
		return false;
	}

	public IEnumerator TryStartGame()
	{
		return null;
	}

	public void KickNotJoinedPlayers()
	{
	}

	protected override void OnBecomeHost()
	{
	}

	private void AdoptOrphanedDummies()
	{
	}

	protected override void OnGameEnd(GameOverReason gameOverReason, bool showAd)
	{
	}

	public bool DoesMapExist(int mapId)
	{
		return false;
	}

	public IEnumerator CoEndGame()
	{
		return null;
	}

	protected override void OnPlayerJoined(ClientData data)
	{
	}

	protected override void OnGameJoined(string gameIdString, ClientData data)
	{
	}

	public void PlayerControlLeft(PlayerControl character, DisconnectReasons reason)
	{
	}

	protected override void OnPlayerLeft(ClientData data, DisconnectReasons reason)
	{
	}

	protected override void OnDisconnected()
	{
	}

	protected override void OnPlayerChangedScene(ClientData client, string currentScene)
	{
	}

	public void SpawnTester()
	{
	}

	public PlayerControl SpawnDummy(bool hostile)
	{
		return null;
	}

	public int RemoveStaffDummies()
	{
		return 0;
	}

	private IEnumerator CreatePlayer(ClientData clientData)
	{
		return null;
	}

	private IEnumerator CoRetrySetShip(ShipHolder shipHolder, string map)
	{
		return null;
	}

	private IEnumerator CoBroadcastManager()
	{
		return null;
	}
}
