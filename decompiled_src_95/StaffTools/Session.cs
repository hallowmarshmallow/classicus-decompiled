using System;

namespace StaffTools;

public sealed class Session
{
	public string Token;

	public string AccountId;

	public long Epoch;

	public string IpHash;

	public DateTime IssuedUtc;

	public DateTime ExpiresUtc;
}
