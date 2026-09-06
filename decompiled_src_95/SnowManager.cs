using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManager : MonoBehaviour
{
	private sealed class _003CRun_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SnowManager _003C_003E4__this;

		private ContactFilter2D _003Cfilter_003E5__2;

		private Collider2D[] _003Cbuffer_003E5__3;

		private WaitForSeconds _003Cwait_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRun_003Ed__4(int _003C_003E1__state)
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

	public ParticleSystem particles;

	private ParticleSystemRenderer rend;

	private float timer;

	private void Start()
	{
	}

	private IEnumerator Run()
	{
		return null;
	}

	private void SetPartAlpha()
	{
	}
}
