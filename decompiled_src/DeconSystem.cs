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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CCoRunSprayers_003Eb__22_0(ParticleSystem p)
		{
			throw null;
		}
	}

	private sealed class _003CCoRunSprayers_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeconSystem _003C_003E4__this;

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

		public _003CCoRunSprayers_003Ed__22(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public bool Detoriorate(float dt)
	{
		throw null;
	}

	private IEnumerator CoRunSprayers()
	{
		throw null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
		throw null;
	}

	public void OpenDoor(bool upper)
	{
		throw null;
	}

	public void OpenFromInside(bool upper)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
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

	private void UpdateDoorsViaState()
	{
		throw null;
	}

	public DeconSystem()
	{
		throw null;
	}
}
