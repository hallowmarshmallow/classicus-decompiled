using System;
using System.Net;

namespace Hazel.Udp;

public class BroadcastPacket
{
	public string Data;

	public DateTime ReceiveTime;

	public IPEndPoint Sender;

	public BroadcastPacket(string data, IPEndPoint sender)
	{
		throw null;
	}

	public string GetAddress()
	{
		throw null;
	}
}
