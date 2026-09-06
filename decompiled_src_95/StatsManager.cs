using System;
using System.IO;

public class StatsManager
{
	public struct Snapshot
	{
		public uint BodiesReported;

		public uint EmergenciesCalled;

		public uint TasksCompleted;

		public uint CompletedAllTasks;

		public uint SabsFixed;

		public uint ImpostorKills;

		public uint TimesMurdered;

		public uint TimesEjected;

		public uint CrewmateStreak;

		public uint TimesImpostor;

		public uint TimesCrewmate;

		public uint GamesStarted;

		public uint GamesFinished;

		public uint[] WinReasons;

		public uint[] LoseReasons;

		public uint WinsBy(GameOverReason reason)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public bool changed;

		internal uint _003CMergeFromBase64_003Eb__0(uint local, uint incoming)
		{
			return 0u;
		}
	}

	public static StatsManager Instance;

	private static Action m_StatsChanged;

	private bool loadedStats;

	private uint bodiesReported;

	private uint emergenciesCalls;

	private uint tasksCompleted;

	private uint completedAllTasks;

	private uint sabsFixed;

	private uint impostorKills;

	private uint timesMurdered;

	private uint timesEjected;

	private uint crewmateStreak;

	private uint timesImpostor;

	private uint timesCrewmate;

	private uint gamesStarted;

	private uint gamesFinished;

	private float banPoints;

	private long lastGameStarted;

	private uint[] WinReasons;

	private uint[] DrawReasons;

	private uint[] LoseReasons;

	public uint BodiesReported
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint EmergenciesCalled
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint TasksCompleted
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint CompletedAllTasks
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint SabsFixed
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint ImpostorKills
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint TimesMurdered
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint TimesEjected
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint CrewmateStreak
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint TimesImpostor
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint TimesCrewmate
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint GamesStarted
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint GamesFinished
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public float BanPoints
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public DateTime LastGameStarted
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public float BanMinutes => 0f;

	public bool AmBanned => false;

	public int BanMinutesLeft => 0;

	public static event Action StatsChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public void AddDrawReason(GameOverReason reason)
	{
	}

	public void AddWinReason(GameOverReason reason)
	{
	}

	public uint GetWinReason(GameOverReason reason)
	{
		return 0u;
	}

	public void AddLoseReason(GameOverReason reason)
	{
	}

	protected virtual void LoadStats()
	{
	}

	public string ExportBase64()
	{
		return null;
	}

	public static bool TryParseBase64(string blob, out Snapshot snapshot)
	{
		snapshot = default(Snapshot);
		return false;
	}

	private static uint[] ReadCounters(BinaryReader r, int count)
	{
		return null;
	}

	public bool MergeFromBase64(string blob)
	{
		return false;
	}

	protected virtual void SaveStats()
	{
	}
}
