using System.Collections.Generic;

namespace KlassicHideNSeek;

internal sealed class HnSDeathPopup
{
	private struct ActivePopup
	{
		internal string PlayerName;

		internal int DeathCount;

		internal float SpawnTime;
	}

	private static readonly List<ActivePopup> activePopups;

	private static int totalDeaths;

	internal static void Reset()
	{
	}

	internal static void OnPlayerDeath(PlayerControl victim)
	{
	}

	private static float ScaleFor(float elapsed)
	{
		return 0f;
	}

	internal static void CollectPopups(List<string> lines, List<float> scales)
	{
	}
}
