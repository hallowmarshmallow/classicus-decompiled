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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoShowCard_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowCard_003Ed__14(int _003C_003E1__state)
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
	}

	private IEnumerator CoShowCard()
	{
		return null;
	}

	public void EnterDigit(int i)
	{
	}

	public void ClearDigits()
	{
	}

	public void AcceptDigits()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private IEnumerator Animate()
	{
		return null;
	}
}
