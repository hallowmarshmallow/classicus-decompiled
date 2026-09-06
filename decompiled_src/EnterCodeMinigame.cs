using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCodeMinigame : Minigame
{
	private sealed class _003CAnimate_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeMinigame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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

		public _003CAnimate_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoShowCard_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

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

		public _003CCoShowCard_003Ed__14(int _003C_003E1__state)
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

	public TextRenderer NumberText;

	public TextRenderer TargetText;

	public SpriteRenderer Card;

	public int number;

	public string numString;

	private bool animating;

	private bool cardOut;

	private bool done;

	private int targetNumber;

	public AudioClip WalletOut;

	public AudioClip NumberSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	public void ShowCard()
	{
		throw null;
	}

	private IEnumerator CoShowCard()
	{
		throw null;
	}

	public void EnterDigit(int i)
	{
		throw null;
	}

	public void ClearDigits()
	{
		throw null;
	}

	public void AcceptDigits()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private IEnumerator Animate()
	{
		throw null;
	}

	public EnterCodeMinigame()
	{
		throw null;
	}
}
