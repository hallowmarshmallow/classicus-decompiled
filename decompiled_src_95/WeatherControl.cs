using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeatherControl : MonoBehaviour
{
	private sealed class _003CRun_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherControl _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRun_003Ed__10(int _003C_003E1__state)
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

	public Sprite backgroundLight;

	public Sprite backgroundDark;

	public Sprite lightOff;

	public Sprite lightOn;

	public SpriteRenderer Background;

	public SpriteRenderer Switch;

	public SpriteRenderer Light;

	public TextMeshPro Label;

	internal void SetInactive()
	{
	}

	public void SetActive()
	{
	}

	private IEnumerator Run()
	{
		return null;
	}
}
