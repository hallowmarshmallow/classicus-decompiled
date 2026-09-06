namespace StaffTools;

public sealed class GameActionResult
{
	public bool Ok;

	public string Detail;

	public static GameActionResult Done(string detail = null)
	{
		return null;
	}

	public static GameActionResult Fail(string detail)
	{
		return null;
	}
}
