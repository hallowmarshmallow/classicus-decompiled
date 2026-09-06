using System.Collections.Generic;

namespace StaffTools;

public static class StaffRoster
{
	public static readonly List<StaffRosterEntry> Entries;

	public static StaffRosterEntry Resolve(string rawHwid, string pepper)
	{
		return null;
	}

	public static StaffRole RoleFor(string rawHwid, string pepper)
	{
		return default(StaffRole);
	}
}
