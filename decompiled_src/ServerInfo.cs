using System;
using Hazel;

[Serializable]
public class ServerInfo
{
	public string Name;

	public string Ip;

	public ushort Port;

	public bool Vanilla;

	public int Players;

	public int ConnectionFailures;

	public string TranslateName
	{
		get
		{
			throw null;
		}
	}

	public ServerInfo()
	{
		throw null;
	}

	public ServerInfo(string name, string ip, ushort port, bool vanilla)
	{
		throw null;
	}

	internal static ServerInfo Deserialize(MessageReader parts)
	{
		throw null;
	}

	public override int GetHashCode()
	{
		throw null;
	}

	public override bool Equals(object obj)
	{
		throw null;
	}
}
