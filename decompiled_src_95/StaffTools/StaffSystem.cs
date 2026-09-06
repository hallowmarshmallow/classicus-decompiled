namespace StaffTools;

public sealed class StaffSystem
{
	private readonly StaffServices _services;

	private readonly CommandRegistry _registry;

	private readonly CommandDispatcher _dispatcher;

	private readonly SessionManager _sessions;

	private readonly IPasswordHasher _hasher;

	private readonly string _pepper;

	private readonly bool _useIp;

	public CommandRegistry Registry => null;

	public StaffSystem(StaffSystemOptions options)
	{
	}

	public CommandResult ExecuteWithSession(string sessionToken, string rawInput)
	{
		return null;
	}

	public StaffRole ResolveRosterRole(string rawHwid)
	{
		return default(StaffRole);
	}

	public AuthResult AuthenticateWithRole(StaffRole role, string label, string rawHwid, string ip = null)
	{
		return null;
	}
}
