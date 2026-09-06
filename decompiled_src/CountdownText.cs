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

		public _003CCountdownRoutine_003Ed__9(int _003C_003E1__state)
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

	private TMP_Text _text;

	public int startValue;

	public int endValue;

	public float interval;

	private Coroutine _countdownCoroutine;

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public void StartCountdown()
	{
		throw null;
	}

	public void StopCountdown()
	{
		throw null;
	}

	private IEnumerator CountdownRoutine()
	{
		throw null;
	}

	protected virtual void OnCountdownFinished()
	{
		throw null;
	}

	public CountdownText()
	{
		throw null;
	}
}
