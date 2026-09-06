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
		throw null;
	}

	internal static void OnPlayerDeath(PlayerControl victim)
	{
		throw null;
	}

	private static float ScaleFor(float elapsed)
	{
		throw null;
	}

	internal static void CollectPopups(List<string> lines, List<float> scales)
	{
		throw null;
	}

	static HnSDeathPopup()
	{
		throw null;
	}
}
