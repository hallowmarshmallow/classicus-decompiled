using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionTextMonitor : MonoBehaviour
{
	private sealed class _003CGetRegionText_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RegionTextMonitor _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetRegionText_003Ed__1(int _003C_003E1__state)
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

	private void Start()
	{
	}

	private IEnumerator GetRegionText()
	{
		return null;
	}
}
