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
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public bool changed;

		public _003C_003Ec__DisplayClass87_0()
		{
			throw null;
		}

		internal uint _003CMergeFromBase64_003Eb__0(uint local, uint incoming)
		{
			throw null;
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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint EmergenciesCalled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint TasksCompleted
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint CompletedAllTasks
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint SabsFixed
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint ImpostorKills
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint TimesMurdered
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint TimesEjected
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint CrewmateStreak
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint TimesImpostor
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint TimesCrewmate
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint GamesStarted
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public uint GamesFinished
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public float BanPoints
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public DateTime LastGameStarted
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public float BanMinutes
	{
		get
		{
			throw null;
		}
	}

	public bool AmBanned
	{
		get
		{
			throw null;
		}
	}

	public int BanMinutesLeft
	{
		get
		{
			throw null;
		}
	}

	public static event Action StatsChanged
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public void AddDrawReason(GameOverReason reason)
	{
		throw null;
	}

	public void AddWinReason(GameOverReason reason)
	{
		throw null;
	}

	public uint GetWinReason(GameOverReason reason)
	{
		throw null;
	}

	public void AddLoseReason(GameOverReason reason)
	{
		throw null;
	}

	protected virtual void LoadStats()
	{
		throw null;
	}

	public string ExportBase64()
	{
		throw null;
	}

	public static bool TryParseBase64(string blob, out Snapshot snapshot)
	{
		throw null;
	}

	private static uint[] ReadCounters(BinaryReader r, int count)
	{
		throw null;
	}

	public bool MergeFromBase64(string blob)
	{
		throw null;
	}

	protected virtual void SaveStats()
	{
		throw null;
	}

	public StatsManager()
	{
		throw null;
	}

	static StatsManager()
	{
		throw null;
	}
}
