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

	public string TranslateName => null;

	public ServerInfo()
	{
	}

	public ServerInfo(string name, string ip, ushort port, bool vanilla)
	{
	}

	internal static ServerInfo Deserialize(MessageReader parts)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
