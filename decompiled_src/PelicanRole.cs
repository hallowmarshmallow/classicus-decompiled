using System.Collections.Generic;
using Hazel;

public class PelicanRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Swallow,
		Vomit
	}

	public List<GameData.PlayerInfo> swallowedPlayers;

	private FollowerCamera _cachedFollowerCam;

	public override bool IsEnabled
	{
		get
		{
			throw null;
		}
	}

	public override string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public override string roleDisplayName
	{
		get
		{
			throw null;
		}
	}

	public override string KillAbilityName
	{
		get
		{
			throw null;
		}
	}

	public override string KillAbilityImageName
	{
		get
		{
			throw null;
		}
	}

	public string SwallowedText
	{
		get
		{
			throw null;
		}
	}

	public override void ConfigureRole()
	{
		throw null;
	}

	public void RpcSwallowPlayer(PlayerControl target)
	{
		throw null;
	}

	public void RpcVomitPlayer(PlayerControl target, bool remove)
	{
		throw null;
	}

	public override bool CheckMurder(PlayerControl t)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public void SwallowPlayer(PlayerControl target)
	{
		throw null;
	}

	public void VomitPlayer(PlayerControl target, bool remove)
	{
		throw null;
	}

	public void VomitAll()
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	public override void OnGameStart()
	{
		throw null;
	}

	public override void OnMeetingCalled()
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public PelicanRole()
	{
		throw null;
	}
}
