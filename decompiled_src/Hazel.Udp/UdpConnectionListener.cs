using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Hazel.Udp;

public class UdpConnectionListener : NetworkConnectionListener
{
	private Socket socket;

	private ILogger Logger;

	private Timer reliablePacketTimer;

	private ConcurrentDictionary<EndPoint, UdpServerConnection> allConnections;

	public UdpConnectionListener(IPEndPoint endPoint, IPMode ipMode = IPMode.IPv4, ILogger logger = null)
	{
		throw null;
	}

	~UdpConnectionListener()
	{
		throw null;
	}

	private void ManageReliablePackets(object state)
	{
		throw null;
	}

	public override void Start()
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

	internal void SendData(SmartBuffer bytes, int length, EndPoint endPoint)
	{
		throw null;
	}

	private void SendCallback(IAsyncResult result)
	{
		throw null;
	}

	internal void SendDataSync(byte[] bytes, int length, EndPoint endPoint)
	{
		throw null;
	}

	internal void RemoveConnectionTo(EndPoint endPoint)
	{
		throw null;
	}

	protected override void Dispose(bool disposing)
	{
		throw null;
	}
}
