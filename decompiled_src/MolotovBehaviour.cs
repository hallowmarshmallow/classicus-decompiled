using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolotovBehaviour : MonoBehaviour
{
	private sealed class _003CLifeCycle_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MolotovBehaviour _003C_003E4__this;

		private float _003Ct_003E5__2;

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

		public _003CLifeCycle_003Ed__7(int _003C_003E1__state)
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

	public float prepareTime;

	public float growTime;

	public float stayTime;

	public float shrinkTime;

	public Vector3 maxScale;

	public RoleBehaviour perpetratorRole;

	private void Start()
	{
		throw null;
	}

	private IEnumerator LifeCycle()
	{
		throw null;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		throw null;
	}

	public MolotovBehaviour()
	{
		throw null;
	}
}
