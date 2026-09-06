using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp;

public class UdpBroadcastListener : IDisposable
{
	private Socket socket;

	private EndPoint endpoint;

	private Action<string> logger;

	private byte[] buffer;

	private List<BroadcastPacket> packets;

	private bool _003CRunning_003Ek__BackingField;

	public bool Running
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

	public UdpBroadcastListener(int port, Action<string> logger = null)
	{
		throw null;
	}

	public void StartListen()
	{
		throw null;
	}

	private void HandleData(IAsyncResult result)
	{
		throw null;
	}

	public BroadcastPacket[] GetPackets()
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}
}
