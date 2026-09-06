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
		}
		remove
		{
		}
	}

	public event Action<HazelInternalErrors> OnInternalError
	{
		add
		{
		}
		remove
		{
		}
	}

	public ConnectionListener()
	{
	}

	public abstract void Start();

	protected void InvokeNewConnection(MessageReader msg, Connection connection)
	{
	}

	protected void InvokeInternalError(HazelInternalErrors reason)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private SmartBuffer _003C_002Ector_003Eb__13_0()
	{
		return null;
	}
}
