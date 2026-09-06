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
	}

	~UdpConnectionListener()
	{
	}

	private void ManageReliablePackets(object state)
	{
	}

	public override void Start()
	{
	}

	private void StartListeningForData()
	{
	}

	private void ReadCallback(IAsyncResult result)
	{
	}

	internal void SendData(SmartBuffer bytes, int length, EndPoint endPoint)
	{
	}

	private void SendCallback(IAsyncResult result)
	{
	}

	internal void SendDataSync(byte[] bytes, int length, EndPoint endPoint)
	{
	}

	internal void RemoveConnectionTo(EndPoint endPoint)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
