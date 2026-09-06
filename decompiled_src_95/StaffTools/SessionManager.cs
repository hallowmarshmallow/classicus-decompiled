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
	}

	public Session Issue(StaffAccount account, string ipHash)
	{
		return null;
	}

	public Session Resolve(string token)
	{
		return null;
	}

	public void Revoke(string token)
	{
	}

	public void RevokeAllFor(string accountId)
	{
	}

	private static string NewToken()
	{
		return null;
	}
}
