using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public sealed class MorpheusRole : RoleBehaviour
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public GameData.PlayerInfo target;

		public MorpheusRole _003C_003E4__this;

		public _003C_003Ec__DisplayClass29_0()
		{
			throw null;
		}

		internal void _003COnClicked_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoDistortPerception_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MorpheusRole _003C_003E4__this;

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

		public _003CCoDistortPerception_003Ed__33(int _003C_003E1__state)
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

	private const float DreamEchoRadius = 5f;

	private const float DriftAccel = 0.6f;

	private const float DriftMaxSpeed = 1.5f;

	private static float _cooldownUntil;

	private float _cooldown;

	private float _duration;

	private VanillaButtonManager _button;

	private bool _dreaming;

	private float _dreamUntil;

	private Coroutine _dreamRoutine;

	private readonly Dictionary<byte, bool> _lastAliveState;

	private readonly Dictionary<byte, Vector2> _driftVelocities;

	private readonly List<byte> _distortedPlayerIds;

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

	private void RpcDreamShift(byte targetId)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	private void ApplyDreamShift(byte targetId)
	{
		throw null;
	}

	private IEnumerator CoDistortPerception()
	{
		throw null;
	}

	private void BeginDistortion()
	{
		throw null;
	}

	private void StepDistortion()
	{
		throw null;
	}

	private void EndDistortion()
	{
		throw null;
	}

	private void UpdateDreamEcho()
	{
		throw null;
	}

	private void ShowDreamEcho()
	{
		throw null;
	}

	public override void OnMeetingCalled()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	public MorpheusRole()
	{
		throw null;
	}

	static MorpheusRole()
	{
		throw null;
	}
}
