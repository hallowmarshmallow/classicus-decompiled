using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class SteamBehaviour : MonoBehaviour
{
	private sealed class _003CRun_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamBehaviour _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRun_003Ed__3(int _003C_003E1__state)
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

	public SpriteAnim anim;

	public FloatRange PlayRate;

	public void OnEnable()
	{
	}

	private IEnumerator Run()
	{
		return null;
	}
}
