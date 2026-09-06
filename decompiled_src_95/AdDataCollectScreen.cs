using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdDataCollectScreen : MonoBehaviour
{
	private sealed class _003CShow_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdDataCollectScreen _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShow_003Ed__2(int _003C_003E1__state)
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

	public ToggleButtonBehaviour PersonalizedAdsButton;

	private void Start()
	{
	}

	public IEnumerator Show()
	{
		return null;
	}

	public void Close()
	{
	}

	public void Update()
	{
	}

	public void TogglePersonalizedAd()
	{
	}

	public void UpdateButtons()
	{
	}
}
