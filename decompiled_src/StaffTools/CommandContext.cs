namespace StaffTools;

public sealed class CommandContext
{
	public StaffAccount Executor;

	public string Command;

	public string[] Args;

	public StaffServices Services;

	public string Target
	{
		get
		{
			throw null;
		}
	}

	public string Arg(int index)
	{
		throw null;
	}

	public string Rest(int fromIndex)
	{
		throw null;
	}

	public CommandContext()
	{
		throw null;
	}
}
