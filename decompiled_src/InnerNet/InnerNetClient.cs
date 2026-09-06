using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InnerNet;

public abstract class InnerNetClient : MonoBehaviour
{
	public enum GameStates
	{
		NotJoined,
		Joined,
		Started,
		Ended
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<HazelInternalErrors, MessageWriter> _003C_003E9__83_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal MessageWriter _003CCoConnect_003Eb__83_1(HazelInternalErrors error)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public InnerNetClient _003C_003E4__this;

		public DisconnectReasons reason;

		public string stringReason;

		public _003C_003Ec__DisplayClass104_0()
		{
			throw null;
		}

		internal void _003CEnqueueDisconnect_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public GameOverReason reason;

		public bool showAd;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_0()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__2()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_1
	{
		public ClientData myClient;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_1()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__4()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_2
	{
		public ClientData client;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_2()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__5()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_3
	{
		public MessageReader subReader2;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_3()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__7()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_4
	{
		public MessageReader subReader;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_4()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__8()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_5
	{
		public List<GameListing> roomDataList;

		public InnerNetClient _003C_003E4__this;

		public _003C_003Ec__DisplayClass123_5()
		{
			throw null;
		}

		internal void _003CHandleMessage_003Eb__9()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public int clientId;

		public _003C_003Ec__DisplayClass125_0()
		{
			throw null;
		}

		internal bool _003CGetOrCreateClient_003Eb__0(ClientData c)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public DisconnectReasons reason;

		public _003C_003Ec__DisplayClass126_0()
		{
			throw null;
		}

		internal void _003CRemovePlayer_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public int clientId;

		public _003C_003Ec__DisplayClass144_0()
		{
			throw null;
		}

		internal bool _003CGetClient_003Eb__0(ClientData c)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public int clientId;

		public _003C_003Ec__DisplayClass145_0()
		{
			throw null;
		}

		internal bool _003CGetRecentClient_003Eb__0(ClientData c)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public string sceneName;

		public _003C_003Ec__DisplayClass156_0()
		{
			throw null;
		}

		internal void _003CCoSendSceneChange_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass163_0
	{
		public uint spawnId;

		public _003C_003Ec__DisplayClass163_0()
		{
			throw null;
		}

		internal bool _003CCoHandleSpawn_003Eb__0(InnerNetObject f)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass165_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public string targetScene;

		public _003C_003Ec__DisplayClass165_0()
		{
			throw null;
		}

		internal void _003CHandleGameDataInner_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass166_0
	{
		public InnerNetClient _003C_003E4__this;

		public MessageReader copy;

		public _003C_003Ec__DisplayClass166_0()
		{
			throw null;
		}

		internal void _003CDeferMessage_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoAutoRejoin_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public int gameId;

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

		public _003CCoAutoRejoin_003Ed__102(int _003C_003E1__state)
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

	private sealed class _003CCoConnect_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

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

		public _003CCoConnect_003Ed__83(int _003C_003E1__state)
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

	private sealed class _003CCoConnect_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public MatchMakerModes mode;

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

		public _003CCoConnect_003Ed__87(int _003C_003E1__state)
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

	private sealed class _003CCoHandleSpawn_003Ed__163 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MessageReader reader;

		public InnerNetClient _003C_003E4__this;

		private _003C_003Ec__DisplayClass163_0 _003C_003E8__1;

		private int _003CownerId_003E5__2;

		private int _003Cframes_003E5__3;

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

		public _003CCoHandleSpawn_003Ed__163(int _003C_003E1__state)
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

	private sealed class _003CCoSendSceneChange_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public string sceneName;

		private _003C_003Ec__DisplayClass156_0 _003C_003E8__1;

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

		public _003CCoSendSceneChange_003Ed__156(int _003C_003E1__state)
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

	private sealed class _003CHandleGameDataInner_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public MessageReader reader;

		public int cnt;

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

		public _003CHandleGameDataInner_003Ed__165(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CWaitForConnectionOrFail_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

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

		public _003CWaitForConnectionOrFail_003Ed__88(int _003C_003E1__state)
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

	private sealed class _003CWaitWithTimeout_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

		public InnerNetClient _003C_003E4__this;

		public string errorMessage;

		private bool _003Cfailed_003E5__2;

		private float _003Ctimer_003E5__3;

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

		public _003CWaitWithTimeout_003Ed__89(int _003C_003E1__state)
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

	private static readonly DisconnectReasons[] disconnectReasons;

	public const int NoClientId = -1;

	private string networkAddress;

	private int networkPort;

	private NetworkConnection connection;

	public static bool ForceWebSocketTransport;

	public MatchMakerModes mode;

	public int GameId;

	public int TotalLobbyCount;

	public int TotalPlayerCount;

	public int HostId;

	public int ClientId;

	public List<ClientData> allClients;

	protected CircleBuffer<ClientData> recentClients;

	public DisconnectReasons LastDisconnectReason;

	public string LastCustomDisconnect;

	private readonly List<Action> PreSpawnDispatcher;

	private readonly List<Action> Dispatcher;

	public GameStates GameState;

	private List<Action> TempQueue;

	private bool appPaused;

	private bool focusLossCanDisconnect;

	public const int CurrentClient = -3;

	public const int InvalidClient = -2;

	internal const byte DataFlag = 1;

	internal const byte RpcFlag = 2;

	internal const byte SpawnFlag = 4;

	internal const byte DespawnFlag = 5;

	internal const byte SceneChangeFlag = 6;

	internal const byte ReadyFlag = 7;

	internal const byte ChangeSettingsFlag = 8;

	public float MinSendInterval;

	private uint NetIdCnt;

	private float timer;

	public InnerNetObject[] SpawnableObjects;

	public string[] SpawnableObjectPaths;

	private InnerNetObject[] resolvedSpawnables;

	private bool InOnlineScene;

	private HashSet<uint> DestroyedObjects;

	public List<InnerNetObject> allObjects;

	private Dictionary<uint, InnerNetObject> allObjectsFast;

	private MessageWriter[] Streams;

	private int StreamsGameId;

	private int msgNum;

	private bool _003CIsGamePublic_003Ek__BackingField;

	private const int MaxAutoRejoinAttempts = 2;

	private const float AutoRejoinDelaySeconds = 1.5f;

	private int autoRejoinAttempts;

	private bool AmConnected
	{
		get
		{
			throw null;
		}
	}

	public bool IsFullyConnected
	{
		get
		{
			throw null;
		}
	}

	public string CurrentEndpointAddress
	{
		get
		{
			throw null;
		}
	}

	public int CurrentEndpointPort
	{
		get
		{
			throw null;
		}
	}

	public int Ping
	{
		get
		{
			throw null;
		}
	}

	public int BytesSent
	{
		get
		{
			throw null;
		}
	}

	public int BytesGot
	{
		get
		{
			throw null;
		}
	}

	public bool AmHost
	{
		get
		{
			throw null;
		}
	}

	public bool AmClient
	{
		get
		{
			throw null;
		}
	}

	public bool IsGamePublic
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool IsGameStarted
	{
		get
		{
			throw null;
		}
	}

	public bool IsGameOver
	{
		get
		{
			throw null;
		}
	}

	public InnerNetObject GetSpawnable(int index)
	{
		throw null;
	}

	public void SetEndpoint(string addr, ushort port)
	{
		throw null;
	}

	private static string BuildWebSocketUrl(string addr, int port)
	{
		throw null;
	}

	public virtual void Start()
	{
		throw null;
	}

	private void SendOrDisconnect(MessageWriter msg)
	{
		throw null;
	}

	public ClientData GetHost()
	{
		throw null;
	}

	public int GetClientIdFromCharacter(InnerNetObject character)
	{
		throw null;
	}

	public void GetAllClients(List<ClientData> buffer)
	{
		throw null;
	}

	public virtual void OnDestroy()
	{
		throw null;
	}

	public void DisconnectSilently()
	{
		throw null;
	}

	private void EnsureStreamsAllocated()
	{
		throw null;
	}

	private void PrepareGameStreams()
	{
		throw null;
	}

	public IEnumerator CoConnect()
	{
		throw null;
	}

	private void Connection_DataReceivedRaw(byte[] data, SendOption option)
	{
		throw null;
	}

	public void Connect(MatchMakerModes mode)
	{
		throw null;
	}

	private IEnumerator CoConnect(MatchMakerModes mode)
	{
		throw null;
	}

	public IEnumerator WaitForConnectionOrFail()
	{
		throw null;
	}

	private IEnumerator WaitWithTimeout(Func<bool> success, string errorMessage)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private static string ServerWentAwayText()
	{
		throw null;
	}

	private static bool HasWorkingInternet()
	{
		throw null;
	}

	private static bool IsLinkTimeout(string reason)
	{
		throw null;
	}

	private static string ConnectionLostText()
	{
		throw null;
	}

	private void OnDisconnect(object sender, DisconnectedEventArgs e)
	{
		throw null;
	}

	private bool ShouldAutoRejoin(string stringReason)
	{
		throw null;
	}

	protected void ClearAutoRejoin()
	{
		throw null;
	}

	protected virtual void OnAutoRejoin(int gameId)
	{
		throw null;
	}

	private IEnumerator CoAutoRejoin(int gameId)
	{
		throw null;
	}

	public void HandleDisconnect(DisconnectReasons reason, string stringReason = null)
	{
		throw null;
	}

	public void EnqueueDisconnect(DisconnectReasons reason, string stringReason = null)
	{
		throw null;
	}

	protected void DisconnectInternal(DisconnectReasons reason, string stringReason = null)
	{
		throw null;
	}

	public void HostGame(IBytesSerializable settings)
	{
		throw null;
	}

	public void JoinGame()
	{
		throw null;
	}

	public bool CanBan()
	{
		throw null;
	}

	public bool CanKick()
	{
		throw null;
	}

	public void KickPlayer(int clientId, bool ban)
	{
		throw null;
	}

	public void KickPlayerAnyway(int clientId, bool ban)
	{
		throw null;
	}

	public void ReportPlayer(int clientId, string reason)
	{
		throw null;
	}

	public MessageWriter StartEndGame()
	{
		throw null;
	}

	public void FinishEndGame(MessageWriter msg)
	{
		throw null;
	}

	public void SendLateRejection(int targetId, DisconnectReasons reason)
	{
		throw null;
	}

	public void SendCustomRejection(int targetId, string reason)
	{
		throw null;
	}

	protected void SendClientReady()
	{
		throw null;
	}

	protected void SendStartGame()
	{
		throw null;
	}

	public void RequestGameList()
	{
		throw null;
	}

	public void RequestFriendCode()
	{
		throw null;
	}

	public void ChangeGamePublic(bool isPublic)
	{
		throw null;
	}

	private void OnMessageReceived(DataReceivedEventArgs e)
	{
		throw null;
	}

	private void HandleMessage(MessageReader reader, SendOption sendOption)
	{
		throw null;
	}

	private static string AddressToString(uint address)
	{
		throw null;
	}

	private ClientData GetOrCreateClient(int clientId)
	{
		throw null;
	}

	private void RemovePlayer(int playerIdThatLeft, DisconnectReasons reason)
	{
		throw null;
	}

	protected virtual void OnApplicationPause(bool pause)
	{
		throw null;
	}

	private bool FocusLossCanDisconnect()
	{
		throw null;
	}

	private void WaitToDisconnect(object state)
	{
		throw null;
	}

	protected void SendInitialData(int clientId)
	{
		throw null;
	}

	protected abstract void OnGameCreated(string gameIdString);

	protected abstract void OnGameJoined(string gameIdString, ClientData client);

	protected abstract void OnWaitForHost(string gameIdString);

	protected abstract void OnStartGame();

	protected abstract void OnGameEnd(GameOverReason reason, bool showAd);

	protected abstract void OnBecomeHost();

	protected abstract void OnPlayerJoined(ClientData client);

	protected abstract void OnPlayerChangedScene(ClientData client, string targetScene);

	protected abstract void OnPlayerLeft(ClientData client, DisconnectReasons reason);

	protected abstract void OnDisconnected();

	protected abstract void OnGetGameList(List<GameListing> availableGames);

	protected abstract byte[] GetConnectionData();

	protected ClientData FindClientById(int id)
	{
		throw null;
	}

	public ClientData GetClient(int clientId)
	{
		throw null;
	}

	public ClientData GetRecentClient(int clientId)
	{
		throw null;
	}

	private bool SendAllStreamedObjects()
	{
		throw null;
	}

	protected void UpdateCachedClients(ClientData clientData, PlayerControl character)
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	public T FindObjectByNetId<T>(uint netId) where T : InnerNetObject
	{
		throw null;
	}

	public void SendRpcImmediately(uint targetNetId, byte callId, SendOption option)
	{
		throw null;
	}

	public MessageWriter StartRpcImmediately(uint targetNetId, byte callId, SendOption option, int targetClientId = -1)
	{
		throw null;
	}

	public void FinishRpcImmediately(MessageWriter msg)
	{
		throw null;
	}

	public void SendRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
	{
		throw null;
	}

	public MessageWriter StartRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
	{
		throw null;
	}

	private void SendSceneChange(string sceneName)
	{
		throw null;
	}

	private IEnumerator CoSendSceneChange(string sceneName)
	{
		throw null;
	}

	public void Spawn(InnerNetObject netObjParent, int ownerId = -2, SpawnFlags flags = SpawnFlags.None)
	{
		throw null;
	}

	private void WriteSpawnMessage(InnerNetObject netObjParent, int ownerId, SpawnFlags flags, MessageWriter msg)
	{
		throw null;
	}

	public void Despawn(InnerNetObject objToDespawn)
	{
		throw null;
	}

	private bool AddNetObject(InnerNetObject obj)
	{
		throw null;
	}

	public void RemoveNetObject(InnerNetObject obj)
	{
		throw null;
	}

	public void RemoveUnownedObjects()
	{
		throw null;
	}

	private IEnumerator CoHandleSpawn(MessageReader reader)
	{
		throw null;
	}

	private void HandleGameData(MessageReader parentReader)
	{
		throw null;
	}

	private IEnumerator HandleGameDataInner(MessageReader reader, int cnt)
	{
		throw null;
	}

	private void DeferMessage(int cnt, MessageReader reader, string logMsg)
	{
		throw null;
	}

	protected InnerNetClient()
	{
		throw null;
	}

	static InnerNetClient()
	{
		throw null;
	}

	private void _003CStart_003Eb__74_0(Scene oldScene, Scene scene)
	{
		throw null;
	}

	private bool _003CCoConnect_003Eb__83_0()
	{
		throw null;
	}

	private bool _003CCoConnect_003Eb__87_0()
	{
		throw null;
	}

	private bool _003CCoConnect_003Eb__87_1()
	{
		throw null;
	}

	private bool _003CCoConnect_003Eb__87_2()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_0()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_1()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_3()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_6()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_10()
	{
		throw null;
	}

	private void _003CHandleMessage_003Eb__123_11()
	{
		throw null;
	}
}
