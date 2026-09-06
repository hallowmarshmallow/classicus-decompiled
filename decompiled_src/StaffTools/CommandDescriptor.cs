using System;

namespace StaffTools;

public sealed class CommandDescriptor
{
	public string Name;

	public StaffRole MinRole;

	public bool Critical;

	public TimeSpan Cooldown;

	public string Usage;

	public string Description;

	public Func<CommandContext, CommandResult> Handler;

	public CommandDescriptor()
	{
		throw null;
	}
}
