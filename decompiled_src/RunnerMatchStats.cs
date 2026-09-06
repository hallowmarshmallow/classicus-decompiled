using System.Collections.Generic;

public static class RunnerMatchStats
{
	public class DeathRecord
	{
		public byte PlayerId;

		public string PlayerName;

		public float SurvivalSeconds;

		public DeathRecord()
		{
			throw null;
		}
	}

	private static readonly List<DeathRecord> _deaths;

	public static byte LocalPlayerId;

	public static bool AnyDeaths
	{
		get
		{
			throw null;
		}
	}

	public static int PlacementCount
	{
		get
		{
			throw null;
		}
	}

	public static int LocalPlace
	{
		get
		{
			throw null;
		}
	}

	public static void BeginMatch()
	{
		throw null;
	}

	public static void RecordDeath(byte playerId, float survivalSeconds = -1f)
	{
		throw null;
	}

	public static int GetPlace(byte playerId)
	{
		throw null;
	}

	public static DeathRecord GetByPlace(int place)
	{
		throw null;
	}

	public static string FormatTime(float seconds)
	{
		throw null;
	}

	public static string Ordinal(int place)
	{
		throw null;
	}

	static RunnerMatchStats()
	{
		throw null;
	}
}
