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

		internal MessageWriter _003CCoConnect_003Eb__83_1(HazelInternalErrors error)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public GameOverReason reason;

		public bool showAd;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_1
	{
		public ClientData myClient;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_2
	{
		public ClientData client;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_3
	{
		public MessageReader subReader2;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__7()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_4
	{
		public MessageReader subReader;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__8()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_5
	{
		public List<GameListing> roomDataList;

		public InnerNetClient _003C_003E4__this;

		internal void _003CHandleMessage_003Eb__9()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass118_0
	{
		public int clientId;

		internal bool _003CGetOrCreateClient_003Eb__0(ClientData c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public DisconnectReasons reason;

		internal void _003CRemovePlayer_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public int clientId;

		internal bool _003CGetClient_003Eb__0(ClientData c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public int clientId;

		internal bool _003CGetRecentClient_003Eb__0(ClientData c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public string sceneName;

		internal void _003CCoSendSceneChange_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public uint spawnId;

		internal bool _003CCoHandleSpawn_003Eb__0(InnerNetObject f)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass158_0
	{
		public InnerNetClient _003C_003E4__this;

		public ClientData client;

		public string targetScene;

		internal void _003CHandleGameDataInner_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public InnerNetClient _003C_003E4__this;

		public MessageReader copy;

		internal void _003CDeferMessage_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public InnerNetClient _003C_003E4__this;

		public DisconnectReasons reason;

		public string stringReason;

		internal void _003CEnqueueDisconnect_003Eb__0()
		{
		}
	}

	private sealed class _003CCoConnect_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoConnect_003Ed__83(int _003C_003E1__state)
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

	private sealed class _003CCoConnect_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public MatchMakerModes mode;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoConnect_003Ed__87(int _003C_003E1__state)
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

	private sealed class _003CCoHandleSpawn_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MessageReader reader;

		public InnerNetClient _003C_003E4__this;

		private _003C_003Ec__DisplayClass156_0 _003C_003E8__1;

		private int _003CownerId_003E5__2;

		private int _003Cframes_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoHandleSpawn_003Ed__156(int _003C_003E1__state)
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

	private sealed class _003CCoSendSceneChange_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public string sceneName;

		private _003C_003Ec__DisplayClass149_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSendSceneChange_003Ed__149(int _003C_003E1__state)
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

	private sealed class _003CHandleGameDataInner_003Ed__158 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		public MessageReader reader;

		public int cnt;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleGameDataInner_003Ed__158(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitForConnectionOrFail_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerNetClient _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForConnectionOrFail_003Ed__88(int _003C_003E1__state)
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

	private sealed class _003CWaitWithTimeout_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

		public InnerNetClient _003C_003E4__this;

		public string errorMessage;

		private bool _003Cfailed_003E5__2;

		private float _003Ctimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitWithTimeout_003Ed__89(int _003C_003E1__state)
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

	private bool AmConnected => false;

	public bool IsFullyConnected => false;

	public string CurrentEndpointAddress => null;

	public int CurrentEndpointPort => 0;

	public int Ping => 0;

	public int BytesSent => 0;

	public int BytesGot => 0;

	public bool AmHost => false;

	public bool AmClient => false;

	public bool IsGamePublic
	{
		get
		{
			return _003CIsGamePublic_003Ek__BackingField;
		}
		private set
		{
			_003CIsGamePublic_003Ek__BackingField = value;
		}
	}

	public bool IsGameStarted => false;

	public bool IsGameOver => false;

	public InnerNetObject GetSpawnable(int index)
	{
		return null;
	}

	public void SetEndpoint(string addr, ushort port)
	{
	}

	private static string BuildWebSocketUrl(string addr, int port)
	{
		return null;
	}

	public virtual void Start()
	{
	}

	private void SendOrDisconnect(MessageWriter msg)
	{
	}

	public ClientData GetHost()
	{
		return null;
	}

	public int GetClientIdFromCharacter(InnerNetObject character)
	{
		return 0;
	}

	public void GetAllClients(List<ClientData> buffer)
	{
	}

	public virtual void OnDestroy()
	{
	}

	public void DisconnectSilently()
	{
	}

	private void EnsureStreamsAllocated()
	{
	}

	private void PrepareGameStreams()
	{
	}

	public IEnumerator CoConnect()
	{
		return null;
	}

	private void Connection_DataReceivedRaw(byte[] data, SendOption option)
	{
	}

	public void Connect(MatchMakerModes mode)
	{
	}

	private IEnumerator CoConnect(MatchMakerModes mode)
	{
		return null;
	}

	public IEnumerator WaitForConnectionOrFail()
	{
		return null;
	}

	private IEnumerator WaitWithTimeout(Func<bool> success, string errorMessage)
	{
		return null;
	}

	public void Update()
	{
	}

	private static string ServerWentAwayText()
	{
		return null;
	}

	private static bool HasWorkingInternet()
	{
		return false;
	}

	private static bool IsLinkTimeout(string reason)
	{
		return false;
	}

	private static string ConnectionLostText()
	{
		return null;
	}

	private void OnDisconnect(object sender, DisconnectedEventArgs e)
	{
	}

	public void HandleDisconnect(DisconnectReasons reason, string stringReason = null)
	{
	}

	public void EnqueueDisconnect(DisconnectReasons reason, string stringReason = null)
	{
	}

	protected void DisconnectInternal(DisconnectReasons reason, string stringReason = null)
	{
	}

	public void HostGame(IBytesSerializable settings)
	{
	}

	public void JoinGame()
	{
	}

	public bool CanBan()
	{
		return false;
	}

	public bool CanKick()
	{
		return false;
	}

	public void KickPlayer(int clientId, bool ban)
	{
	}

	public void KickPlayerAnyway(int clientId, bool ban)
	{
	}

	public void ReportPlayer(int clientId, string reason)
	{
	}

	public MessageWriter StartEndGame()
	{
		return null;
	}

	public void FinishEndGame(MessageWriter msg)
	{
	}

	public void SendLateRejection(int targetId, DisconnectReasons reason)
	{
	}

	public void SendCustomRejection(int targetId, string reason)
	{
	}

	protected void SendClientReady()
	{
	}

	protected void SendStartGame()
	{
	}

	public void RequestGameList()
	{
	}

	public void RequestFriendCode()
	{
	}

	public void ChangeGamePublic(bool isPublic)
	{
	}

	private void OnMessageReceived(DataReceivedEventArgs e)
	{
	}

	private void HandleMessage(MessageReader reader, SendOption sendOption)
	{
	}

	private static string AddressToString(uint address)
	{
		return null;
	}

	private ClientData GetOrCreateClient(int clientId)
	{
		return null;
	}

	private void RemovePlayer(int playerIdThatLeft, DisconnectReasons reason)
	{
	}

	protected virtual void OnApplicationPause(bool pause)
	{
	}

	private bool FocusLossCanDisconnect()
	{
		return false;
	}

	private void WaitToDisconnect(object state)
	{
	}

	protected void SendInitialData(int clientId)
	{
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
		return null;
	}

	public ClientData GetClient(int clientId)
	{
		return null;
	}

	public ClientData GetRecentClient(int clientId)
	{
		return null;
	}

	private bool SendAllStreamedObjects()
	{
		return false;
	}

	protected void UpdateCachedClients(ClientData clientData, PlayerControl character)
	{
	}

	private void FixedUpdate()
	{
	}

	public T FindObjectByNetId<T>(uint netId) where T : InnerNetObject
	{
		return null;
	}

	public void SendRpcImmediately(uint targetNetId, byte callId, SendOption option)
	{
	}

	public MessageWriter StartRpcImmediately(uint targetNetId, byte callId, SendOption option, int targetClientId = -1)
	{
		return null;
	}

	public void FinishRpcImmediately(MessageWriter msg)
	{
	}

	public void SendRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
	{
	}

	public MessageWriter StartRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
	{
		return null;
	}

	private void SendSceneChange(string sceneName)
	{
	}

	private IEnumerator CoSendSceneChange(string sceneName)
	{
		return null;
	}

	public void Spawn(InnerNetObject netObjParent, int ownerId = -2, SpawnFlags flags = SpawnFlags.None)
	{
	}

	private void WriteSpawnMessage(InnerNetObject netObjParent, int ownerId, SpawnFlags flags, MessageWriter msg)
	{
	}

	public void Despawn(InnerNetObject objToDespawn)
	{
	}

	private bool AddNetObject(InnerNetObject obj)
	{
		return false;
	}

	public void RemoveNetObject(InnerNetObject obj)
	{
	}

	public void RemoveUnownedObjects()
	{
	}

	private IEnumerator CoHandleSpawn(MessageReader reader)
	{
		return null;
	}

	private void HandleGameData(MessageReader parentReader)
	{
	}

	private IEnumerator HandleGameDataInner(MessageReader reader, int cnt)
	{
		return null;
	}

	private void DeferMessage(int cnt, MessageReader reader, string logMsg)
	{
	}

	private void _003CStart_003Eb__74_0(Scene oldScene, Scene scene)
	{
	}

	private bool _003CCoConnect_003Eb__83_0()
	{
		return false;
	}

	private bool _003CCoConnect_003Eb__87_0()
	{
		return false;
	}

	private bool _003CCoConnect_003Eb__87_1()
	{
		return false;
	}

	private bool _003CCoConnect_003Eb__87_2()
	{
		return false;
	}

	private void _003CHandleMessage_003Eb__116_0()
	{
	}

	private void _003CHandleMessage_003Eb__116_1()
	{
	}

	private void _003CHandleMessage_003Eb__116_3()
	{
	}

	private void _003CHandleMessage_003Eb__116_6()
	{
	}

	private void _003CHandleMessage_003Eb__116_10()
	{
	}

	private void _003CHandleMessage_003Eb__116_11()
	{
	}
}
