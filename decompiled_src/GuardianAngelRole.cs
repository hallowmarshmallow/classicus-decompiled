using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class GuardianAngelRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Protect,
		ShowProtected
	}

	private sealed class _003CNotifyGAProtect_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CNotifyGAProtect_003Ed__39(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public AbilityButtonSettings abilitySettings;

	public PlayerPhysics.BodyTypes OgBodyType;

	private float _003CProtectTimer_003Ek__BackingField;

	private float _003CProtectDuration_003Ek__BackingField;

	private float _003CProtectCooldown_003Ek__BackingField;

	public Dictionary<PlayerControl, DateTime> ProtectedPlayers;

	private bool LastKillProtected;

	public EffectAnimation ProtectAnim;

	public EffectAnimation OnGoingProtectAnim;

	public PlayerBody GuardianAngelBody;

	private VanillaButtonManager protectButton;

	private PlayerControl targetPlayer;

	public override bool IsEnabled
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

	public override string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public override bool IsDead
	{
		get
		{
			throw null;
		}
	}

	public override bool IsSpecial
	{
		get
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

	public float ProtectTimer
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

	public float ProtectDuration
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

	public float ProtectCooldown
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

	public void RpcProtectPlayer(PlayerControl target)
	{
		throw null;
	}

	public void Protect(PlayerControl target)
	{
		throw null;
	}

	public void CheckProtect()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	public override void OnMeetingCalled()
	{
		throw null;
	}

	public IEnumerator NotifyGAProtect()
	{
		throw null;
	}

	public override bool CheckMurderGlobal(PlayerControl murderer, PlayerControl target)
	{
		throw null;
	}

	public void RpcShowProtected(PlayerControl target, PlayerControl[] received)
	{
		throw null;
	}

	public void ShowProtected(PlayerControl target)
	{
		throw null;
	}

	public void SetProtectOverlay(PlayerControl target, bool state, int colorId)
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

	public void OnDestroy()
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public GuardianAngelRole()
	{
		throw null;
	}
}
