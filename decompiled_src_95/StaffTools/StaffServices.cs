namespace StaffTools;

public sealed class StaffServices
{
	public IStaffStore Store;

	public AuditLog Log;

	public AltDetector Alts;

	public SessionManager Sessions;

	public IPasswordHasher Hasher;

	public IGameBridge Bridge;

	public StaffState State;

	public string Pepper;

	public bool UseIpSimilarity;
}
