namespace StaffTools;

public sealed class GameActionResult
{
	public bool Ok;

	public string Detail;

	public static GameActionResult Done(string detail = null)
	{
		throw null;
	}

	public static GameActionResult Fail(string detail)
	{
		throw null;
	}

	public GameActionResult()
	{
		throw null;
	}
}
