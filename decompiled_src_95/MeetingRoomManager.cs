using InnerNet;

public class MeetingRoomManager : IDisconnectHandler
{
	public static readonly MeetingRoomManager Instance;

	private PlayerControl reporter;

	private GameData.PlayerInfo target;

	public void AssignSelf(PlayerControl reporter, GameData.PlayerInfo target)
	{
	}

	public void RemoveSelf()
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}
}
