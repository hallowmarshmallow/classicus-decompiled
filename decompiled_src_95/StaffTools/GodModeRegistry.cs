using System.Collections.Generic;

namespace StaffTools;

public static class GodModeRegistry
{
	private static readonly HashSet<byte> _immune;

	public static bool IsImmune(byte playerId)
	{
		return false;
	}

	public static bool Toggle(byte playerId)
	{
		return false;
	}

	public static void SetAll(IEnumerable<byte> playerIds, bool on)
	{
	}
}
