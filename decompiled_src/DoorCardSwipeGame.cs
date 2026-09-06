using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorCardSwipeGame : Minigame, IDoorMinigame
{
	private enum TaskStages
	{
		Before,
		Animating,
		Inserted,
		After
	}

	private sealed class _003CInsertCard_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DoorCardSwipeGame _003C_003E4__this;

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

		public _003CInsertCard_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CPutCardBack_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DoorCardSwipeGame _003C_003E4__this;

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

		public _003CPutCardBack_003Ed__23(int _003C_003E1__state)
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

	private Color gray;

	private Color green;

	private TaskStages State;

	private Controller myController;

	private FloatRange YRange;

	public float minAcceptedTime;

	public Collider2D col;

	public SpriteRenderer confirmSymbol;

	public Sprite AcceptSymbol;

	public Sprite RejectSymbol;

	public TextMeshPro StatusText;

	public AudioClip AcceptSound;

	public AudioClip DenySound;

	public AudioClip[] CardMove;

	public AudioClip WalletOut;

	public float dragTime;

	private bool moving;

	private Vector2 prevStickInput;

	private bool hadPrev;

	private OpenableDoor MyDoor;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator PutCardBack()
	{
		throw null;
	}

	private IEnumerator InsertCard()
	{
		throw null;
	}

	public void SetDoor(OpenableDoor door)
	{
		throw null;
	}

	public DoorCardSwipeGame()
	{
		throw null;
	}
}
