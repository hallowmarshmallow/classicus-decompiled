using System.Collections.Generic;

public static class Constants
{
	public enum ProductionTypes
	{
		Release,
		Staging,
		Beta,
		Development,
		QA,
		UAT,
		Hotfix,
		Demo,
		Sandbox,
		Integration
	}

	public static readonly string[] PlayStationControllers;

	public static bool CanUseMods;

	public static bool ModsCheckDone;

	public static bool ModsFolderEdited;

	public static List<RecentTab.ModItem> modItems;

	public static readonly int ShipOnlyMask;

	public static readonly int ShipAndObjectsMask;

	public static readonly int ShipAndAllObjectsMask;

	public static readonly int NotShipMask;

	public static readonly int Usables;

	public static readonly int PlayersOnlyMask;

	public static readonly int LivingPlayersOnlyMask;

	public static readonly int ShadowMask;

	public static readonly int[] CompatVersions;

	public static readonly string RoleOptionsPath;

	private static int _broadcastVersion;

	internal static int GetBroadcastVersion()
	{
		return 0;
	}

	internal static int ParseBroadcastVersion(string raw)
	{
		return 0;
	}

	private static bool TryReadLeadingInt(string token, out int value)
	{
		value = default(int);
		return false;
	}

	public static int GetVersion(int year, int month, int day, int rev)
	{
		return 0;
	}

	public static int CompareVersions(string localVersion, string remoteVersion)
	{
		return 0;
	}

	private static int[] ParseVersionParts(string version)
	{
		return null;
	}

	public static bool ShouldPlaySfx()
	{
		return false;
	}

	public static string ModsFolder()
	{
		return null;
	}
}
