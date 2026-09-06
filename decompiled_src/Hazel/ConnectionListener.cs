using System;
using System.Net;

namespace Hazel;

public abstract class ConnectionListener : IDisposable
{
	public delegate bool AcceptConnectionCheck(IPEndPoint endPoint, byte[] input, out byte[] response);

	public int ReceiveBufferSize;

	public readonly ListenerStatistics Statistics;

	protected readonly ObjectPool<SmartBuffer> bufferPool;

	public AcceptConnectionCheck AcceptConnection;

	private Action<NewConnectionEventArgs> m_NewConnection;

	private Action<HazelInternalErrors> m_OnInternalError;

	public event Action<NewConnectionEventArgs> NewConnection
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public event Action<HazelInternalErrors> OnInternalError
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public ConnectionListener()
	{
		throw null;
	}

	public abstract void Start();

	protected void InvokeNewConnection(MessageReader msg, Connection connection)
	{
		throw null;
	}

	protected void InvokeInternalError(HazelInternalErrors reason)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	protected virtual void Dispose(bool disposing)
	{
		throw null;
	}

	private SmartBuffer _003C_002Ector_003Eb__13_0()
	{
		throw null;
	}
}
