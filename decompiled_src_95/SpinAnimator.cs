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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDisappear_003Ed__6(int _003C_003E1__state)
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

	public float Speed;

	private States curState;

	private void Update()
	{
	}

	public void Appear()
	{
	}

	public void Disappear()
	{
	}

	private IEnumerator CoDisappear()
	{
		return null;
	}

	public void StartPulse()
	{
	}

	internal void Play()
	{
	}
}
