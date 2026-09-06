using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class RoleBehaviour : MonoBehaviour
{
	public string roleCodeName;

	public string roleModName;

	public ushort roleId;

	private int _003CRoleChance_003Ek__BackingField;

	public PlayerControl Player;

	private readonly bool _003CIsDead_003Ek__BackingField;

	private RoleBehaviour _003COverrideGhostRole_003Ek__BackingField;

	private readonly bool _003CIsSpecial_003Ek__BackingField;

	public Dictionary<string, RoleOption> AllOptions;

	public RoleTeamTypes[] enemyTeams;

	public RoleTeamTypes RoleTeamType;

	public bool CanUseKillButton;

	public bool CanSabotage;

	public bool CanVent;

	private WinnerMessage _003CWinnerMessage_003Ek__BackingField;

	public virtual string roleDisplayName
	{
		get
		{
			throw null;
		}
	}

	public virtual string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public virtual string roleDescriptionShort
	{
		get
		{
			throw null;
		}
	}

	public virtual int RoleChance
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public virtual bool PreKillCheck
	{
		get
		{
			throw null;
		}
	}

	public virtual bool IsDead
	{
		get
		{
			throw null;
		}
	}

	public virtual RoleBehaviour OverrideGhostRole
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public virtual bool IsSpecial
	{
		get
		{
			throw null;
		}
	}

	public virtual bool IsEnabled
	{
		get
		{
			throw null;
		}
	}

	public virtual bool ShouldDoTasks
	{
		get
		{
			throw null;
		}
	}

	public virtual WinnerMessage WinnerMessage
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public virtual bool IsAffectedByComms
	{
		get
		{
			throw null;
		}
	}

	public virtual string KillAbilityImageName
	{
		get
		{
			throw null;
		}
	}

	public virtual string KillAbilityName
	{
		get
		{
			throw null;
		}
	}

	protected bool CommsSabotaged
	{
		get
		{
			throw null;
		}
	}

	public RoleBehaviour DefaultGhostRole
	{
		get
		{
			throw null;
		}
	}

	public virtual AudioClip IntroSound
	{
		get
		{
			throw null;
		}
	}

	public virtual Color TeamColor
	{
		get
		{
			throw null;
		}
	}

	public string RoleName
	{
		get
		{
			throw null;
		}
	}

	public virtual float KillCooldown
	{
		get
		{
			throw null;
		}
	}

	public virtual void OnMeetingCalled()
	{
		throw null;
	}

	public virtual void OnMeetingStart()
	{
		throw null;
	}

	public virtual void OnVotingComplete()
	{
		throw null;
	}

	public virtual void UpdateSystemAffected(SystemTypes systemType, byte amount)
	{
		throw null;
	}

	public virtual void SetHudActive(bool active)
	{
		throw null;
	}

	public virtual void OnVote(PlayerControl voteTarget)
	{
		throw null;
	}

	public virtual void OnVotedBy(PlayerControl voter)
	{
		throw null;
	}

	public virtual void OnTaskComplete(PlayerTask task)
	{
		throw null;
	}

	public virtual void OnUseConsole(Console console, PlayerTask task)
	{
		throw null;
	}

	public virtual void OnUseMapConsole(MapConsole console)
	{
		throw null;
	}

	public virtual void OnUseSystemConsole(SystemConsole console)
	{
		throw null;
	}

	public virtual void OnUseVent(Vent vent, bool entering)
	{
		throw null;
	}

	public virtual void OnWrapUp()
	{
		throw null;
	}

	public virtual bool HideVote(PlayerVoteArea votedPlayer)
	{
		throw null;
	}

	public virtual void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public virtual void ConfigureRole()
	{
		throw null;
	}

	public bool IsEnemyTeam(RoleTeamTypes team)
	{
		throw null;
	}

	public virtual void OnGameStart()
	{
		throw null;
	}

	public virtual void OnEnterVent(Vent vent)
	{
		throw null;
	}

	public virtual void OnCoEnterVent(int ventId)
	{
		throw null;
	}

	public virtual void OnExitVent(int ventId)
	{
		throw null;
	}

	public virtual void UpdateSystem(SystemTypes systemType, byte amount)
	{
		throw null;
	}

	public virtual string GetGhostRole()
	{
		throw null;
	}

	public virtual bool OnCoEnterVentOthers(PlayerPhysics vented, int ventId)
	{
		throw null;
	}

	public virtual bool CheckMurder(PlayerControl target)
	{
		throw null;
	}

	public virtual bool CheckMurderAsTarget()
	{
		throw null;
	}

	public virtual bool CheckMurderGlobal(PlayerControl murderer, PlayerControl target)
	{
		throw null;
	}

	public virtual bool OnCheckReportDeadBody(PlayerControl reporter, GameData.PlayerInfo deadBody, PlayerControl killer)
	{
		throw null;
	}

	public virtual void OnMurder(PlayerControl target)
	{
		throw null;
	}

	public virtual void OnMurdered(DeathReason reason, PlayerControl killer = null)
	{
		throw null;
	}

	public virtual void OnDeath(DeathReason reason, PlayerControl killer = null)
	{
		throw null;
	}

	public virtual void OnExiled()
	{
		throw null;
	}

	public virtual void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public virtual void OnFixedUpdate()
	{
		throw null;
	}

	public virtual void SetTarget()
	{
		throw null;
	}

	public void SetKillTimer(float time)
	{
		throw null;
	}

	public RoleBehaviour()
	{
		throw null;
	}
}
