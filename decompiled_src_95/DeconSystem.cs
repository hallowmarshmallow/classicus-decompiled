using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class DeconSystem : MonoBehaviour, ISystemType
{
	public enum States : byte
	{
		Idle = 0,
		Enter = 1,
		Closed = 2,
		Exit = 4,
		HeadingUp = 8
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ParticleSystem> _003C_003E9__22_0;

		internal void _003CCoRunSprayers_003Eb__22_0(ParticleSystem p)
		{
		}
	}

	private sealed class _003CCoRunSprayers_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeconSystem _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRunSprayers_003Ed__22(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const byte HeadUpCmd = 1;

	private const byte HeadDownCmd = 2;

	private const byte HeadUpInsideCmd = 3;

	private const byte HeadDownInsideCmd = 4;

	public SystemTypes TargetSystem;

	public SomeKindaDoor UpperDoor;

	public SomeKindaDoor LowerDoor;

	public float DoorOpenTime;

	public float DeconTime;

	public AudioClip SpraySound;

	public ParticleSystem[] Particles;

	private float timer;

	public DecontamNumController FloorText;

	private Coroutine sprayers;

	private States _003CCurState_003Ek__BackingField;

	public States CurState
	{
		get
		{
			return _003CCurState_003Ek__BackingField;
		}
		private set
		{
			_003CCurState_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool Detoriorate(float dt)
	{
		return false;
	}

	private IEnumerator CoRunSprayers()
	{
		return null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	public void OpenDoor(bool upper)
	{
	}

	public void OpenFromInside(bool upper)
	{
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private void UpdateDoorsViaState()
	{
	}
}
