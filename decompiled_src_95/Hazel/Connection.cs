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
			return _003CEndPoint_003Ek__BackingField;
		}
		protected set
		{
			_003CEndPoint_003Ek__BackingField = value;
		}
	}

	public IPMode IPMode
	{
		get
		{
			return _003CIPMode_003Ek__BackingField;
		}
		protected set
		{
			_003CIPMode_003Ek__BackingField = value;
		}
	}

	public ConnectionStatistics Statistics
	{
		get
		{
			return _003CStatistics_003Ek__BackingField;
		}
		protected set
		{
			_003CStatistics_003Ek__BackingField = value;
		}
	}

	public ConnectionState State
	{
		get
		{
			return default(ConnectionState);
		}
		protected set
		{
		}
	}

	public event Action<DataReceivedEventArgs> DataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandler<DisconnectedEventArgs> Disconnected
	{
		add
		{
		}
		remove
		{
		}
	}

	protected virtual void SetState(ConnectionState state)
	{
	}

	public abstract SendErrors Send(MessageWriter msg);

	public abstract void ConnectAsync(byte[] bytes = null);

	protected void InvokeDataReceived(MessageReader msg, SendOption sendOption)
	{
	}

	protected void InvokeDisconnected(string e, MessageReader reader)
	{
	}

	public abstract void Disconnect(string reason, MessageWriter writer = null);

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
