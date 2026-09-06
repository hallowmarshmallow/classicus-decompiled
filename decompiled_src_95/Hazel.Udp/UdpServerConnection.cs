using System.Net;

namespace Hazel.Udp;

internal sealed class UdpServerConnection : UdpConnection
{
	private UdpConnectionListener _003CListener_003Ek__BackingField;

	public UdpConnectionListener Listener
	{
		get
		{
			return _003CListener_003Ek__BackingField;
		}
		private set
		{
			_003CListener_003Ek__BackingField = value;
		}
	}

	internal UdpServerConnection(UdpConnectionListener listener, IPEndPoint endPoint, IPMode IPMode, ILogger logger)
		: base(null)
	{
	}

	protected override void WriteBytesToConnection(SmartBuffer bytes, int length)
	{
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
	}

	protected override bool SendDisconnect(MessageWriter data = null)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
