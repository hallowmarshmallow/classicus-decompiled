using System;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp;

public class UdpBroadcaster : IDisposable
{
	private struct SocketBroadcast(Socket socket, IPEndPoint broadcast)
	{
		public Socket Socket = null;

		public IPEndPoint Broadcast = null;
	}

	private SocketBroadcast[] socketBroadcasts;

	private byte[] data;

	private Action<string> logger;

	public UdpBroadcaster(int port, Action<string> logger = null)
	{
	}

	private static Socket CreateSocket(IPEndPoint endPoint)
	{
		return null;
	}

	public void SetData(string data)
	{
	}

	public void Broadcast()
	{
	}

	private void FinishSendTo(IAsyncResult evt)
	{
	}

	public void Dispose()
	{
	}
}
