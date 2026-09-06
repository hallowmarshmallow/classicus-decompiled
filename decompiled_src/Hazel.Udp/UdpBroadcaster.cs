using System;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp;

public class UdpBroadcaster : IDisposable
{
	private struct SocketBroadcast
	{
		public Socket Socket;

		public IPEndPoint Broadcast;

		public SocketBroadcast(Socket socket, IPEndPoint broadcast)
		{
			throw null;
		}
	}

	private SocketBroadcast[] socketBroadcasts;

	private byte[] data;

	private Action<string> logger;

	public UdpBroadcaster(int port, Action<string> logger = null)
	{
		throw null;
	}

	private static Socket CreateSocket(IPEndPoint endPoint)
	{
		throw null;
	}

	public void SetData(string data)
	{
		throw null;
	}

	public void Broadcast()
	{
		throw null;
	}

	private void FinishSendTo(IAsyncResult evt)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}
}
