using System;

namespace StaffTools;

public sealed class StaffAccount
{
	public string AccountId;

	public string Username;

	public StaffRole Role;

	public string Email;

	public string PasswordHash;

	public string HwidHash;

	public string IpHash;

	public string IpPrefixHash;

	public bool Flagged;

	public bool Locked;

	public bool Verified;

	public bool TwoFactorEnabled;

	public long SessionEpoch;

	public DateTime CreatedUtc;

	public DateTime? LastSeenUtc;

	public StaffAccount()
	{
		throw null;
	}
}
