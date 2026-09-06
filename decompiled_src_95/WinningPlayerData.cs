using UnityEngine;

public class WinningPlayerData
{
	public byte Id;

	public string Name;

	public bool IsDead;

	public bool IsImpostor;

	public int ColorId;

	public string SkinId;

	public string HatId;

	public string PetId;

	public Color TeamColor;

	public bool IsYou;

	public WinnerMessage WinMessage;

	public WinningPlayerData()
	{
	}

	public WinningPlayerData(GameData.PlayerInfo player)
	{
	}

	private static bool IsUnset(string id)
	{
		return false;
	}

	private static string ResolveHat(GameData.PlayerInfo player)
	{
		return null;
	}

	private static string ResolveSkin(GameData.PlayerInfo player)
	{
		return null;
	}

	private static string ResolvePet(GameData.PlayerInfo player)
	{
		return null;
	}
}
