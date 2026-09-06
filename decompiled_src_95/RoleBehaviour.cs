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

	public virtual string roleDisplayName => null;

	public virtual string roleDescription => null;

	public virtual string roleDescriptionShort => null;

	public virtual int RoleChance
	{
		get
		{
			return _003CRoleChance_003Ek__BackingField;
		}
		set
		{
			_003CRoleChance_003Ek__BackingField = value;
		}
	}

	public virtual bool PreKillCheck => false;

	public virtual bool IsDead => _003CIsDead_003Ek__BackingField;

	public virtual RoleBehaviour OverrideGhostRole
	{
		get
		{
			return _003COverrideGhostRole_003Ek__BackingField;
		}
		private set
		{
			_003COverrideGhostRole_003Ek__BackingField = value;
		}
	}

	public virtual bool IsSpecial => _003CIsSpecial_003Ek__BackingField;

	public virtual bool IsEnabled => false;

	public virtual bool ShouldDoTasks => false;

	public virtual WinnerMessage WinnerMessage
	{
		get
		{
			return _003CWinnerMessage_003Ek__BackingField;
		}
		set
		{
			_003CWinnerMessage_003Ek__BackingField = value;
		}
	}

	public virtual bool IsAffectedByComms => false;

	public virtual string KillAbilityImageName => null;

	public virtual string KillAbilityName => null;

	protected bool CommsSabotaged => false;

	public RoleBehaviour DefaultGhostRole => null;

	public virtual AudioClip IntroSound => null;

	public virtual Color TeamColor => default(Color);

	public string RoleName => null;

	public virtual float KillCooldown => 0f;

	public virtual void OnMeetingCalled()
	{
	}

	public virtual void OnMeetingStart()
	{
	}

	public virtual void OnVotingComplete()
	{
	}

	public virtual void UpdateSystemAffected(SystemTypes systemType, byte amount)
	{
	}

	public virtual void SetHudActive(bool active)
	{
	}

	public virtual void OnVote(PlayerControl voteTarget)
	{
	}

	public virtual void OnVotedBy(PlayerControl voter)
	{
	}

	public virtual void OnTaskComplete(PlayerTask task)
	{
	}

	public virtual void OnUseConsole(Console console, PlayerTask task)
	{
	}

	public virtual void OnUseMapConsole(MapConsole console)
	{
	}

	public virtual void OnUseSystemConsole(SystemConsole console)
	{
	}

	public virtual void OnUseVent(Vent vent, bool entering)
	{
	}

	public virtual void OnWrapUp()
	{
	}

	public virtual bool HideVote(PlayerVoteArea votedPlayer)
	{
		return false;
	}

	public virtual void OnAssign(PlayerControl player)
	{
	}

	public virtual void ConfigureRole()
	{
	}

	public bool IsEnemyTeam(RoleTeamTypes team)
	{
		return false;
	}

	public virtual void OnGameStart()
	{
	}

	public virtual void OnEnterVent(Vent vent)
	{
	}

	public virtual void OnCoEnterVent(int ventId)
	{
	}

	public virtual void OnExitVent(int ventId)
	{
	}

	public virtual void UpdateSystem(SystemTypes systemType, byte amount)
	{
	}

	public virtual string GetGhostRole()
	{
		return null;
	}

	public virtual bool OnCoEnterVentOthers(PlayerPhysics vented, int ventId)
	{
		return false;
	}

	public virtual bool CheckMurder(PlayerControl target)
	{
		return false;
	}

	public virtual bool CheckMurderAsTarget()
	{
		return false;
	}

	public virtual bool CheckMurderGlobal(PlayerControl murderer, PlayerControl target)
	{
		return false;
	}

	public virtual bool OnCheckReportDeadBody(PlayerControl reporter, GameData.PlayerInfo deadBody, PlayerControl killer)
	{
		return false;
	}

	public virtual void OnMurder(PlayerControl target)
	{
	}

	public virtual void OnMurdered(DeathReason reason, PlayerControl killer = null)
	{
	}

	public virtual void OnDeath(DeathReason reason, PlayerControl killer = null)
	{
	}

	public virtual void OnExiled()
	{
	}

	public virtual void HandleRpc(MessageReader reader, int rpc)
	{
	}

	public virtual void OnFixedUpdate()
	{
	}

	public virtual void SetTarget()
	{
	}

	public void SetKillTimer(float time)
	{
	}
}
