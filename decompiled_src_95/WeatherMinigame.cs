using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherMinigame : Minigame
{
	private sealed class _003CCoDoAnimation_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherMinigame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDoAnimation_003Ed__8(int _003C_003E1__state)
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

	public float Duration;

	public HorizontalGauge destGauge1;

	public HorizontalGauge destGauge2;

	public HorizontalGauge destGauge3;

	public PassiveButton StartButton;

	public TextRenderer EtaText;

	public AudioClip StartSound;

	public void StartStopFill()
	{
	}

	private IEnumerator CoDoAnimation()
	{
		return null;
	}
}
