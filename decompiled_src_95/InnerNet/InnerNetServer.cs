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
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, string> _003C_003E9__22_0;

		internal string _003CConnection_DataSentRaw_003Eb__22_0(byte b)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public InnerNetServer _003C_003E4__this;

		public Player client;

		internal void _003COnServerConnect_003Eb__0(DataReceivedEventArgs e)
		{
		}

		internal void _003COnServerConnect_003Eb__1(object _003Cp0_003E, DisconnectedEventArgs _003Cp1_003E)
		{
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
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public float delay;

		public Player player;

		internal Task _003CForceCloseConnection_003Eb__0()
		{
			return null;
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
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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

	public MemoryConnectionListener MemoryListener => null;

	public override void OnDestroy()
	{
	}

	public void StartAsServer()
	{
	}

	public void StartAsLocalServer()
	{
	}

	private void OnInternalError(HazelInternalErrors errorType)
	{
	}

	public void StopServer()
	{
	}

	public static bool IsCompatibleVersion(int version)
	{
		return false;
	}

	private void OnServerConnect(NewConnectionEventArgs evt)
	{
	}

	private static void SendIncorrectVersion(Connection connection)
	{
	}

	public static void SerializeDisconnect(Connection connection, DisconnectReasons reason, string message = "")
	{
	}

	private void Connection_DataSentRaw(byte[] data, int length)
	{
	}

	private void OnDataReceived(Player client, DataReceivedEventArgs evt)
	{
	}

	private void HandleMessage(Player client, MessageReader reader, SendOption sendOption)
	{
	}

	private void KickPlayer(int targetId, bool ban)
	{
	}

	protected void ForceCloseConnection(Player player, float delay = 0.5f)
	{
	}

	private void DisconnectPlayer(int targetId, string reason)
	{
	}

	protected void JoinGame(Player client)
	{
	}

	private void HandleRejoin(Player client)
	{
	}

	private void HandleNewGameJoin(Player client)
	{
	}

	private void EndGame(MessageReader message, Player source)
	{
	}

	private void StartGame(MessageReader message, Player source)
	{
	}

	private void ClientDisconnect(Player client)
	{
	}

	protected void SendTo(MessageWriter msg, int targetId)
	{
	}

	protected void Broadcast(MessageWriter msg, Player source)
	{
	}

	private void BroadcastJoinMessage(Player client, MessageWriter msg)
	{
	}

	private void WriteJoinedMessage(Player client, MessageWriter msg, bool clear)
	{
	}

	private int GetMaxPlayers()
	{
		return 0;
	}
}
