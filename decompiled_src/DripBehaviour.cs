using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class DripBehaviour : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Vector3 pos;

		public _003C_003Ec__DisplayClass7_0()
		{
			throw null;
		}

		internal bool _003CRun_003Eb__0(Collider2D col)
		{
			throw null;
		}
	}

	private sealed class _003CRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DripBehaviour _003C_003E4__this;

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

		public _003CRun_003Ed__7(int _003C_003E1__state)
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

	public Vector2Range SpawnArea;

	public FloatRange FirstWait;

	public FloatRange Frequency;

	public SpriteAnim myAnim;

	public Collider2D[] IgnoreAreas;

	public bool FixDepth;

	public void Start()
	{
		throw null;
	}

	private IEnumerator Run()
	{
		throw null;
	}

	public DripBehaviour()
	{
		throw null;
	}
}
