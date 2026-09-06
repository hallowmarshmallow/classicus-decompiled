public static class TaskPerf
{
	private static bool sampling;

	private static int taskCount;

	private static float taskTotalSeconds;

	private static float taskWorstSeconds;

	private static NormalPlayerTask taskWorstTask;

	private static float lookupSeconds;

	private static bool pendingOpen;

	private static float pendingStartedAt;

	private static NormalPlayerTask pendingTask;

	public static float Now()
	{
		throw null;
	}

	public static int Ms(float startedAt)
	{
		throw null;
	}

	public static int MsOf(float seconds)
	{
		throw null;
	}

	public static void Log(string line)
	{
		throw null;
	}

	public static void OpenTaskSample()
	{
		throw null;
	}

	public static float MarkLookupStart()
	{
		throw null;
	}

	public static void MarkLookupEnd(float lookupStartedAt, NormalPlayerTask resolved)
	{
		throw null;
	}

	public static void SealPending()
	{
		throw null;
	}

	private static void ClosePending(float endedAt)
	{
		throw null;
	}

	public static string CloseTaskSample()
	{
		throw null;
	}
}
