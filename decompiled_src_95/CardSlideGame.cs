using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlideGame : Minigame
{
	private enum TaskStages
	{
		Before,
		Animating,
		Inserted,
		After
	}

	private sealed class _003CInsertCard_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardSlideGame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInsertCard_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CPutCardBack_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardSlideGame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPutCardBack_003Ed__19(int _003C_003E1__state)
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

	private Color gray;

	private Color green;

	private TaskStages State;

	private Controller myController;

	private FloatRange XRange;

	public FloatRange AcceptedTime;

	public Collider2D col;

	public SpriteRenderer redLight;

	public SpriteRenderer greenLight;

	public TextRenderer StatusText;

	public AudioClip AcceptSound;

	public AudioClip DenySound;

	public AudioClip[] CardMove;

	public AudioClip WalletOut;

	public float dragTime;

	private bool moving;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private IEnumerator PutCardBack()
	{
		return null;
	}

	private IEnumerator InsertCard()
	{
		return null;
	}
}
