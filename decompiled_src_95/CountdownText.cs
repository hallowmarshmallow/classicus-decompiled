using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownText : MonoBehaviour
{
	private sealed class _003CCountdownRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CountdownText _003C_003E4__this;

		private int _003Ccurrent_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCountdownRoutine_003Ed__9(int _003C_003E1__state)
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

	private TMP_Text _text;

	public int startValue;

	public int endValue;

	public float interval;

	private Coroutine _countdownCoroutine;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void StartCountdown()
	{
	}

	public void StopCountdown()
	{
	}

	private IEnumerator CountdownRoutine()
	{
		return null;
	}

	protected virtual void OnCountdownFinished()
	{
	}
}
