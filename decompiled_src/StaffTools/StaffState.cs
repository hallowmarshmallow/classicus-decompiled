using System.Collections.Generic;

namespace StaffTools;

public sealed class StaffState
{
	public bool SecureMode;

	public bool DebugMode;

	public bool MaintenanceMode;

	public bool LobbyLocked;

	public string LobbyName;

	public int MaxPlayers;

	public readonly HashSet<string> BannedHwidHashes;

	public StaffState()
	{
		throw null;
	}
}
