using InnerNet;

public class MeetingRoomManager : IDisconnectHandler
{
	public static readonly MeetingRoomManager Instance;

	private PlayerControl reporter;

	private GameData.PlayerInfo target;

	public void AssignSelf(PlayerControl reporter, GameData.PlayerInfo target)
	{
		throw null;
	}

	public void RemoveSelf()
	{
		throw null;
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
		throw null;
	}

	public void HandleDisconnect()
	{
		throw null;
	}

	public MeetingRoomManager()
	{
		throw null;
	}

	static MeetingRoomManager()
	{
		throw null;
	}
}
