namespace StaffTools;

public sealed class CommandDispatcher
{
	private readonly CommandRegistry _registry;

	private readonly StaffServices _services;

	private readonly RateLimiter _rateLimiter;

	public CommandDispatcher(CommandRegistry registry, StaffServices services, RateLimiter rateLimiter)
	{
	}

	public CommandResult Execute(StaffAccount executor, string rawInput)
	{
		return null;
	}

	private CommandResult Reject(StaffAccount executor, string command, string target, ActionResult result, string detail)
	{
		return null;
	}
}
