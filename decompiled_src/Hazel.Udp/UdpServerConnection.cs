using System.Net;

namespace Hazel.Udp;

internal sealed class UdpServerConnection : UdpConnection
{
	private UdpConnectionListener _003CListener_003Ek__BackingField;

	public UdpConnectionListener Listener
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

	internal UdpServerConnection(UdpConnectionListener listener, IPEndPoint endPoint, IPMode IPMode, ILogger logger)
	{
		throw null;
	}

	protected override void WriteBytesToConnection(SmartBuffer bytes, int length)
	{
		throw null;
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
		throw null;
	}

	protected override bool SendDisconnect(MessageWriter data = null)
	{
		throw null;
	}

	protected override void Dispose(bool disposing)
	{
		throw null;
	}
}
