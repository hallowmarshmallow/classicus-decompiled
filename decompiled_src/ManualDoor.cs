using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class ManualDoor : SomeKindaDoor
{
	private sealed class _003CCoCloseDoorway_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManualDoor _003C_003E4__this;

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

		public _003CCoCloseDoorway_003Ed__12(int _003C_003E1__state)
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

	public bool Opening;

	public BoxCollider2D myCollider;

	public SpriteRenderer image;

	private float size;

	public float OpenDuration;

	private float openTimer;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	private void Awake()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public override void SetDoorway(bool open)
	{
		throw null;
	}

	private void DoorDynamics(AudioSource source, float dt)
	{
		throw null;
	}

	private IEnumerator CoCloseDoorway(bool isHort)
	{
		throw null;
	}

	public virtual void Serialize(MessageWriter writer)
	{
		throw null;
	}

	public virtual void Deserialize(MessageReader reader)
	{
		throw null;
	}

	public ManualDoor()
	{
		throw null;
	}
}
