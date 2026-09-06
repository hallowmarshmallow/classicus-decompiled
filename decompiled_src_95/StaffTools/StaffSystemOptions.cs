using System;

namespace StaffTools;

public sealed class StaffSystemOptions
{
	public IStaffStore Store;

	public IGameBridge Bridge;

	public IPasswordHasher Hasher;

	public string LogFilePath;

	public string Pepper;

	public bool UseIpSimilarity;

	public int RateLimitMaxActions;

	public TimeSpan RateLimitWindow;

	public TimeSpan SessionLifetime;
}
