using System.Collections.Generic;

public static class RunnerMatchStats
{
	public class DeathRecord
	{
		public byte PlayerId;

		public string PlayerName;

		public float SurvivalSeconds;
	}

	private static readonly List<DeathRecord> _deaths;

	public static byte LocalPlayerId;

	public static bool AnyDeaths => false;

	public static int PlacementCount => 0;

	public static int LocalPlace => 0;

	public static void BeginMatch()
	{
	}

	public static void RecordDeath(byte playerId, float survivalSeconds = -1f)
	{
	}

	public static int GetPlace(byte playerId)
	{
		return 0;
	}

	public static DeathRecord GetByPlace(int place)
	{
		return null;
	}

	public static string FormatTime(float seconds)
	{
		return null;
	}

	public static string Ordinal(int place)
	{
		return null;
	}
}
