using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;

public sealed class MimicRole : RoleBehaviour
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string targetRoleCode;

		public byte targetId;

		public MimicRole _003C_003E4__this;

		public _003C_003Ec__DisplayClass20_0()
		{
			throw null;
		}

		internal void _003COnClicked_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoRevertAfterDelay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public byte playerId;

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

		public _003CCoRevertAfterDelay_003Ed__25(int _003C_003E1__state)
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

	private static float _cooldownUntil;

	private float _mimicCooldown;

	private float _mimicDuration;

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

	private void UpdateButtonVisuals()
	{
		throw null;
	}

	private void OnClicked()
	{
		throw null;
	}

	private void RequestMimic(string targetRoleCodeName, byte targetPlayerId)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	private void BeginMimicHostSide(string targetRoleCodeName, byte targetPlayerId)
	{
		throw null;
	}

	private static byte[] GetCrewTaskIds(byte targetPlayerId)
	{
		throw null;
	}

	private static IEnumerator CoRevertAfterDelay(byte playerId, float delay)
	{
		throw null;
	}

	public MimicRole()
	{
		throw null;
	}

	static MimicRole()
	{
		throw null;
	}
}
