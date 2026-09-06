namespace StaffTools;

public sealed class CommandResult
{
	public bool Ok;

	public string Message;

	public ActionResult Result;

	public string Detail;

	public static CommandResult Success(string message, string detail = null)
	{
		return null;
	}

	public static CommandResult Error(string message)
	{
		return null;
	}

	public static CommandResult Denied(string message)
	{
		return null;
	}
}
