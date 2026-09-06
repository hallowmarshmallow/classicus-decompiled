using Hazel;
using UnityEngine;

public class MedicRole : RoleBehaviour
{
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public PlayerControl target;

		public _003C_003Ec__DisplayClass31_0()
		{
			throw null;
		}

		internal bool _003CRevive_003Eb__0(DeadBody deadBody)
		{
			throw null;
		}
	}

	public AbilityButtonSettings MedicSettings;

	public VanillaButtonManager reviveButton;

	private PlayerControl targetPlayer;

	private float _003CReviveTimer_003Ek__BackingField;

	private float _003CReviveCooldown_003Ek__BackingField;

	private bool _003CRevivedCanTalk_003Ek__BackingField;

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

	public override bool PreKillCheck
	{
		get
		{
			throw null;
		}
	}

	public float ReviveTimer
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

	public float ReviveCooldown
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

	public bool RevivedCanTalk
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

	public bool IsCoolingDown
	{
		get
		{
			throw null;
		}
	}

	public bool CanUse
	{
		get
		{
			throw null;
		}
	}

	public bool CanUseNoCD
	{
		get
		{
			throw null;
		}
	}

	public bool CanCooldown
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

	public void RpcRevivePlayer(PlayerControl target)
	{
		throw null;
	}

	public void Revive(PlayerControl target)
	{
		throw null;
	}

	public void CheckRevive()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	public override bool CheckMurder(PlayerControl t)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpcCall)
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	public PlayerControl GetTarget()
	{
		throw null;
	}

	public void UpdateReviveTimer(float deltaTime)
	{
		throw null;
	}

	private void SetReviveButtonState(Color buttonColor, float desaturation)
	{
		throw null;
	}

	private void UpdateCooldownUI(float deltaTime)
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public MedicRole()
	{
		throw null;
	}
}
