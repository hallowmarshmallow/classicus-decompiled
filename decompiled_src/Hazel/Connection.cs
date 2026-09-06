using System;
using System.Net;

namespace Hazel;

public abstract class Connection : IDisposable
{
	private Action<DataReceivedEventArgs> m_DataReceived;

	public int TestLagMs;

	public int TestDropRate;

	protected int testDropCount;

	private EventHandler<DisconnectedEventArgs> m_Disconnected;

	private IPEndPoint _003CEndPoint_003Ek__BackingField;

	private IPMode _003CIPMode_003Ek__BackingField;

	private ConnectionStatistics _003CStatistics_003Ek__BackingField;

	protected ConnectionState _state;

	public IPEndPoint EndPoint
	{
		get
		{
			throw null;
		}
		protected set
		{
			throw null;
		}
	}

	public IPMode IPMode
	{
		get
		{
			throw null;
		}
		protected set
		{
			throw null;
		}
	}

	public ConnectionStatistics Statistics
	{
		get
		{
			throw null;
		}
		protected set
		{
			throw null;
		}
	}

	public ConnectionState State
	{
		get
		{
			throw null;
		}
		protected set
		{
			throw null;
		}
	}

	public event Action<DataReceivedEventArgs> DataReceived
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

	public event EventHandler<DisconnectedEventArgs> Disconnected
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

	protected virtual void SetState(ConnectionState state)
	{
		throw null;
	}

	protected Connection()
	{
		throw null;
	}

	public abstract SendErrors Send(MessageWriter msg);

	public abstract void ConnectAsync(byte[] bytes = null);

	protected void InvokeDataReceived(MessageReader msg, SendOption sendOption)
	{
		throw null;
	}

	protected void InvokeDisconnected(string e, MessageReader reader)
	{
		throw null;
	}

	public abstract void Disconnect(string reason, MessageWriter writer = null);

	public void Dispose()
	{
		throw null;
	}

	protected virtual void Dispose(bool disposing)
	{
		throw null;
	}
}
