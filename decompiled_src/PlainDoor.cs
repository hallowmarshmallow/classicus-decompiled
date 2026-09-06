using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using PowerTools;
using UnityEngine;

public class PlainDoor : OpenableDoor
{
	private sealed class _003CCoCloseDoorway_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlainDoor _003C_003E4__this;

		public bool isHort;

		private Vector2 _003Cs_003E5__2;

		private float _003Ci_003E5__3;

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

		public _003CCoCloseDoorway_003Ed__7(int _003C_003E1__state)
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

	public bool Open;

	public BoxCollider2D myCollider;

	public Collider2D shadowCollider;

	public SpriteAnim animator;

	public AnimationClip OpenDoorAnim;

	public AnimationClip CloseDoorAnim;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	private float size;

	public override bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	public virtual void Start()
	{
		throw null;
	}

	public override void SetDoorway(bool open)
	{
		throw null;
	}

	public void FakeDoorway(bool open)
	{
		throw null;
	}

	private void UpdateShadow()
	{
		throw null;
	}

	private IEnumerator CoCloseDoorway(bool isHort)
	{
		throw null;
	}

	private void DoorDynamics(AudioSource source, float dt)
	{
		throw null;
	}

	public override void Serialize(MessageWriter writer)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader)
	{
		throw null;
	}

	public override bool DoUpdate(float dt)
	{
		throw null;
	}

	public PlainDoor()
	{
		throw null;
	}
}
