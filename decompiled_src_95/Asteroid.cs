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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBreakApart_003Ed__12(int _003C_003E1__state)
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
			return _003CTargetPosition_003Ek__BackingField;
		}
		internal set
		{
			_003CTargetPosition_003Ek__BackingField = value;
		}
	}

	public void FixedUpdate()
	{
	}

	public override void Reset()
	{
	}

	public IEnumerator CoBreakApart()
	{
		return null;
	}

	private void _003CCoBreakApart_003Eb__12_0(float t)
	{
	}

	private void _003CCoBreakApart_003Eb__12_1(float t)
	{
	}
}
