using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : PoolableBehavior
{
	private sealed class _003CCoBreakApart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Asteroid _003C_003E4__this;

		private SpriteRenderer _003Crend_003E5__2;

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

		public _003CCoBreakApart_003Ed__12(int _003C_003E1__state)
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

	public Sprite[] AsteroidImages;

	public Sprite[] BrokenImages;

	private int imgIdx;

	public FloatRange MoveSpeed;

	public FloatRange RotateSpeed;

	public SpriteRenderer Explosion;

	private Vector3 _003CTargetPosition_003Ek__BackingField;

	public Vector3 TargetPosition
	{
		get
		{
			throw null;
		}
		internal set
		{
			throw null;
		}
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public override void Reset()
	{
		throw null;
	}

	public IEnumerator CoBreakApart()
	{
		throw null;
	}

	public Asteroid()
	{
		throw null;
	}

	private void _003CCoBreakApart_003Eb__12_0(float t)
	{
		throw null;
	}

	private void _003CCoBreakApart_003Eb__12_1(float t)
	{
		throw null;
	}
}
