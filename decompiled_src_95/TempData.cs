using System.Collections.Generic;
using UnityEngine;

public static class TempData
{
	public static DeathReason LastDeathReason;

	public static GameOverReason EndReason;

	public static bool showAd;

	public static List<WinningPlayerData> winners;

	public static List<WinningPlayerData> customWinners;

	public static string customEndReason;

	public static AudioClip customEndAudio;

	public static bool DidHumansWin(GameOverReason reason)
	{
		return false;
	}
}
