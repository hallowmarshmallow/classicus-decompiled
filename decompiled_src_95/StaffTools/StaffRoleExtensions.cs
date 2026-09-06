namespace StaffTools;

public static class StaffRoleExtensions
{
	public static int Level(StaffRole role)
	{
		return 0;
	}

	public static bool IsStaff(StaffRole role)
	{
		return false;
	}

	public static bool CanSeeFullEmail(StaffRole role)
	{
		return false;
	}

	public static bool CanSeeHwid(StaffRole role)
	{
		return false;
	}

	public static bool AtLeast(StaffRole role, StaffRole other)
	{
		return false;
	}
}
