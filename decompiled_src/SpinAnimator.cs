using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAnimator : MonoBehaviour
{
	private enum States
	{
		Visible,
		Invisible,
		Spinning,
		Pulsing
	}

	private sealed class _003CCoDisappear_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinAnimator _003C_003E4__this;

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

		public _003CCoDisappear_003Ed__6(int _003C_003E1__state)
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

	public float Speed;

	private States curState;

	private void Update()
	{
		throw null;
	}

	public void Appear()
	{
		throw null;
	}

	public void Disappear()
	{
		throw null;
	}

	private IEnumerator CoDisappear()
	{
		throw null;
	}

	public void StartPulse()
	{
		throw null;
	}

	internal void Play()
	{
		throw null;
	}

	public SpinAnimator()
	{
		throw null;
	}
}
