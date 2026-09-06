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
			return _003CRunning_003Ek__BackingField;
		}
		private set
		{
			_003CRunning_003Ek__BackingField = value;
		}
	}

	public UdpBroadcastListener(int port, Action<string> logger = null)
	{
	}

	public void StartListen()
	{
	}

	private void HandleData(IAsyncResult result)
	{
	}

	public BroadcastPacket[] GetPackets()
	{
		return null;
	}

	public void Dispose()
	{
	}
}
