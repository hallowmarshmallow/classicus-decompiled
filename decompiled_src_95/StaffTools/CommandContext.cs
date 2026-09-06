namespace StaffTools;

public sealed class CommandContext
{
	public StaffAccount Executor;

	public string Command;

	public string[] Args;

	public StaffServices Services;

	public string Target => null;

	public string Arg(int index)
	{
		return null;
	}

	public string Rest(int fromIndex)
	{
		return null;
	}
}
