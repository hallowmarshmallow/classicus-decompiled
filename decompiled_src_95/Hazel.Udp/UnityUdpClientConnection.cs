using System;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp;

public class UnityUdpClientConnection : UdpConnection
{
	public int ReceiveBufferSize;

	private Socket socket;

	public UnityUdpClientConnection(ILogger logger, IPEndPoint remoteEndPoint, IPMode ipMode = IPMode.IPv4)
		: base(null)
	{
	}

	~UnityUdpClientConnection()
	{
	}

	public void FixedUpdate()
	{
	}

	protected virtual void RestartConnection()
	{
	}

	protected virtual void ResendPacketsIfNeeded()
	{
	}

	protected override void WriteBytesToConnection(SmartBuffer bytes, int length)
	{
	}

	private void WriteBytesToConnectionReal(SmartBuffer bytes, int length)
	{
	}

	protected virtual void WriteBytesToConnectionSync(SmartBuffer bytes, int length)
	{
	}

	private void HandleSendTo(IAsyncResult result)
	{
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
	}

	private void StartListeningForData()
	{
	}

	private void ReadCallback(IAsyncResult result)
	{
	}

	protected override bool SendDisconnect(MessageWriter data = null)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void _003CConnectAsync_003Eb__12_0()
	{
	}
}
