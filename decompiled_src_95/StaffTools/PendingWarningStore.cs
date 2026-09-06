using System.Collections.Generic;

namespace StaffTools;

public static class PendingWarningStore
{
	private static string PathOnDisk => null;

	public static void Add(string staffName, string reason)
	{
	}

	public static List<PendingWarning> TakeAll()
	{
		return null;
	}

	private static List<PendingWarning> Load()
	{
		return null;
	}

	private static void Save(List<PendingWarning> list)
	{
	}
}
