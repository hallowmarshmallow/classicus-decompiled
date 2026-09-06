using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterSecondsOnce : MonoBehaviour
{
	private sealed class _003CDisableAfterDelay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisableAfterSecondsOnce _003C_003E4__this;

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

		public _003CDisableAfterDelay_003Ed__4(int _003C_003E1__state)
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

	public GameObject targetObject;

	public float delaySeconds;

	private static HashSet<string> disabledNames;

	private void Start()
	{
		throw null;
	}

	private IEnumerator DisableAfterDelay()
	{
		throw null;
	}

	public DisableAfterSecondsOnce()
	{
		throw null;
	}

	static DisableAfterSecondsOnce()
	{
		throw null;
	}
}
