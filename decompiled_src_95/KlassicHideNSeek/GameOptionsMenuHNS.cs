using System.Collections.Generic;

namespace KlassicHideNSeek;

public static class GameOptionsMenuHNS
{
	private static readonly Dictionary<StringNames, string> HnSTitles;

	public static List<GameData.PlayerInfo> GetSeekerCandidates()
	{
		return null;
	}

	public static int GetSeekerSelectionIndex(List<GameData.PlayerInfo> candidates)
	{
		return 0;
	}

	public static string GetHnSTitle(StringNames title)
	{
		return null;
	}

	public static void ApplyCustomTitles(OptionBehaviour[] children)
	{
	}
}
