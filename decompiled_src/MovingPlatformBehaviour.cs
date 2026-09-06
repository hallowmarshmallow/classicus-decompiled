using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class MovingPlatformBehaviour : MonoBehaviour, ISystemType
{
	private sealed class _003CUsePlatform_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MovingPlatformBehaviour _003C_003E4__this;

		public PlayerControl target;

		private float _003CplatformTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		private Vector3 _003CsourcePos_003E5__4;

		private Vector3 _003CtargetPos_003E5__5;

		private Vector3 _003CworldUseTargetPos_003E5__6;

		private Vector3 _003CworldSourcePos_003E5__7;

		private Vector3 _003CworldTargetPos_003E5__8;

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

		public _003CUsePlatform_003Ed__23(int _003C_003E1__state)
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

	public Vector3 LeftPosition;

	public Vector3 RightPosition;

	public Vector3 DisabledPosition;

	public Vector3 LeftUsePosition;

	public Vector3 RightUsePosition;

	public AudioClip MovingSound;

	private bool IsLeft;

	private PlayerControl Target;

	private byte useId;

	private const float SlideSpeed = 4.5f;

	private bool _003CIsDirty_003Ek__BackingField;

	public bool InUse
	{
		get
		{
			throw null;
		}
	}

	public bool IsDirty
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

	public void Use()
	{
		throw null;
	}

	public void Use(PlayerControl player)
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	private void SetSide(bool isLeft)
	{
		throw null;
	}

	private static bool IsRunnerMode()
	{
		throw null;
	}

	public void RefreshForGameMode()
	{
		throw null;
	}

	private void SetTarget(uint playerNetId, bool isLeft)
	{
		throw null;
	}

	private IEnumerator UsePlatform(PlayerControl target)
	{
		throw null;
	}

	private void ResetPlatform()
	{
		throw null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
		throw null;
	}

	public void MeetingCalled()
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
		throw null;
	}

	public void MarkClean()
	{
		throw null;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public MovingPlatformBehaviour()
	{
		throw null;
	}
}
