using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hazel;
using Hazel.Memory;

namespace InnerNet;

public class InnerNetServer : DestroyableSingleton<InnerNetServer>
{
	protected class Player
	{
		private static int IdCount;

		public int Id;

		public Connection Connection;

		public LimboStates LimboState;

		public Player(Connection connection)
		{
			throw null;
		}

		static Player()
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, string> _003C_003E9__22_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal string _003CConnection_DataSentRaw_003Eb__22_0(byte b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public InnerNetServer _003C_003E4__this;

		public Player client;

		public _003C_003Ec__DisplayClass19_0()
		{
			throw null;
		}

		internal void _003COnServerConnect_003Eb__0(DataReceivedEventArgs e)
		{
			throw null;
		}

		internal void _003COnServerConnect_003Eb__1(object _003Cp0_003E, DisconnectedEventArgs _003Cp1_003E)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CForceCloseConnection_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass26_0 _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
				throw null;
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public float delay;

		public Player player;

		public _003C_003Ec__DisplayClass26_0()
		{
			throw null;
		}

		internal Task _003CForceCloseConnection_003Eb__0()
		{
			throw null;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CForceCloseConnection_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public float delay;

		public Player player;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public bool Running;

	public static bool ForceMemoryTransport;

	public const int LocalGameId = 32;

	private const int InvalidHost = -1;

	private int HostId;

	public HashSet<string> ipBans;

	public int Port;

	private GameStates GameState;

	private NetworkConnectionListener listener;

	private List<Player> Clients;

	public MemoryConnectionListener MemoryListener
	{
		get
		{
			throw null;
		}
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void StartAsServer()
	{
		throw null;
	}

	public void StartAsLocalServer()
	{
		throw null;
	}

	private void OnInternalError(HazelInternalErrors errorType)
	{
		throw null;
	}

	public void StopServer()
	{
		throw null;
	}

	public static bool IsCompatibleVersion(int version)
	{
		throw null;
	}

	private void OnServerConnect(NewConnectionEventArgs evt)
	{
		throw null;
	}

	private static void SendIncorrectVersion(Connection connection)
	{
		throw null;
	}

	public static void SerializeDisconnect(Connection connection, DisconnectReasons reason, string message = "")
	{
		throw null;
	}

	private void Connection_DataSentRaw(byte[] data, int length)
	{
		throw null;
	}

	private void OnDataReceived(Player client, DataReceivedEventArgs evt)
	{
		throw null;
	}

	private void HandleMessage(Player client, MessageReader reader, SendOption sendOption)
	{
		throw null;
	}

	private void KickPlayer(int targetId, bool ban)
	{
		throw null;
	}

	protected void ForceCloseConnection(Player player, float delay = 0.5f)
	{
		throw null;
	}

	private void DisconnectPlayer(int targetId, string reason)
	{
		throw null;
	}

	protected void JoinGame(Player client)
	{
		throw null;
	}

	private void HandleRejoin(Player client)
	{
		throw null;
	}

	private void HandleNewGameJoin(Player client)
	{
		throw null;
	}

	private void EndGame(MessageReader message, Player source)
	{
		throw null;
	}

	private void StartGame(MessageReader message, Player source)
	{
		throw null;
	}

	private void ClientDisconnect(Player client)
	{
		throw null;
	}

	protected void SendTo(MessageWriter msg, int targetId)
	{
		throw null;
	}

	protected void Broadcast(MessageWriter msg, Player source)
	{
		throw null;
	}

	private void BroadcastJoinMessage(Player client, MessageWriter msg)
	{
		throw null;
	}

	private void WriteJoinedMessage(Player client, MessageWriter msg, bool clear)
	{
		throw null;
	}

	private int GetMaxPlayers()
	{
		throw null;
	}

	public InnerNetServer()
	{
		throw null;
	}
}
