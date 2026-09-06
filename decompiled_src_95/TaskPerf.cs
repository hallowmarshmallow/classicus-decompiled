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
		return 0f;
	}

	public static int Ms(float startedAt)
	{
		return 0;
	}

	public static int MsOf(float seconds)
	{
		return 0;
	}

	public static void Log(string line)
	{
	}

	public static void OpenTaskSample()
	{
	}

	public static float MarkLookupStart()
	{
		return 0f;
	}

	public static void MarkLookupEnd(float lookupStartedAt, NormalPlayerTask resolved)
	{
	}

	public static void SealPending()
	{
	}

	private static void ClosePending(float endedAt)
	{
	}

	public static string CloseTaskSample()
	{
		return null;
	}
}
