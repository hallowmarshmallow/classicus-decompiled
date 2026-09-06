using System;
using System.Collections.Generic;

namespace StaffTools;

public sealed class SessionManager
{
	private readonly Dictionary<string, Session> _sessions;

	private readonly TimeSpan _lifetime;

	private readonly object _gate;

	public SessionManager(TimeSpan lifetime)
	{
		throw null;
	}

	public Session Issue(StaffAccount account, string ipHash)
	{
		throw null;
	}

	public Session Resolve(string token)
	{
		throw null;
	}

	public void Revoke(string token)
	{
		throw null;
	}

	public void RevokeAllFor(string accountId)
	{
		throw null;
	}

	private static string NewToken()
	{
		throw null;
	}
}
