using System;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp;

public class UnityUdpClientConnection : UdpConnection
{
	public int ReceiveBufferSize;

	private Socket socket;

	public UnityUdpClientConnection(ILogger logger, IPEndPoint remoteEndPoint, IPMode ipMode = IPMode.IPv4)
	{
		throw null;
	}

	~UnityUdpClientConnection()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	protected virtual void RestartConnection()
	{
		throw null;
	}

	protected virtual void ResendPacketsIfNeeded()
	{
		throw null;
	}

	protected override void WriteBytesToConnection(SmartBuffer bytes, int length)
	{
		throw null;
	}

	private void WriteBytesToConnectionReal(SmartBuffer bytes, int length)
	{
		throw null;
	}

	protected virtual void WriteBytesToConnectionSync(SmartBuffer bytes, int length)
	{
		throw null;
	}

	private void HandleSendTo(IAsyncResult result)
	{
		throw null;
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
		throw null;
	}

	private void StartListeningForData()
	{
		throw null;
	}

	private void ReadCallback(IAsyncResult result)
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

	private void _003CConnectAsync_003Eb__12_0()
	{
		throw null;
	}
}
