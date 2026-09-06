using System;

namespace InnerNet;

[Serializable]
public struct GameListing
{
	public string HostName;

	public int GameId;

	public string PlayerCountAndMax;

	public int ImpostorCount;

	public byte MapId;

	public uint Keywords;

	public bool ProximityChat;

	public byte GameModeId;
}
