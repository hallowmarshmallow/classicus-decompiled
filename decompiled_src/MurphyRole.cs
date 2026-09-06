using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public sealed class MurphyRole : RoleBehaviour
{
	public enum RpcCalls
	{
		RequestMisfortune,
		FreezePlayer
	}

	private sealed class _003CCoLockdownFreeze_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl p;

		private bool _003CwasMoveable_003E5__2;

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

		public _003CCoLockdownFreeze_003Ed__32(int _003C_003E1__state)
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

	private const float NearbyRadius = 3f;

	private const float GlitchRadius = 6f;

	private const float LockdownRadius = 4f;

	private const float LockdownSeconds = 2.5f;

	private static float _cooldownUntil;

	private float _cooldown;

	private VanillaButtonManager _button;

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

	public override string roleDescriptionShort
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

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public override void OnGameStart()
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	private void InitializeButton()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	private void UpdateCooldown()
	{
		throw null;
	}

	private void OnClicked()
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	private void ExecuteMisfortune()
	{
		throw null;
	}

	private void Backfire()
	{
		throw null;
	}

	private void LuckyKill()
	{
		throw null;
	}

	private void ChainMishap()
	{
		throw null;
	}

	private void Lockdown()
	{
		throw null;
	}

	private void BroadcastFreeze(byte targetId)
	{
		throw null;
	}

	private void ApplyFreeze(byte targetId)
	{
		throw null;
	}

	private static IEnumerator CoLockdownFreeze(PlayerControl p)
	{
		throw null;
	}

	private void PositionGlitch()
	{
		throw null;
	}

	private void FalseReport()
	{
		throw null;
	}

	private static PlayerControl FindRandomAliveWithin(Vector2 pos, float radius, byte excludePlayerId)
	{
		throw null;
	}

	private static ShipRoom GetRoomAt(Vector2 pos)
	{
		throw null;
	}

	public MurphyRole()
	{
		throw null;
	}

	static MurphyRole()
	{
		throw null;
	}
}
