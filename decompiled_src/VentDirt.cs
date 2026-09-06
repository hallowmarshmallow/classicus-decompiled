using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentDirt : PoolableBehavior
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public SpriteRenderer rend;

		public _003C_003Ec__DisplayClass4_0()
		{
			throw null;
		}

		internal void _003CCoDisappear_003Eb__0(float t)
		{
			throw null;
		}
	}

	private sealed class _003CCoDisappear_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VentDirt _003C_003E4__this;

		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

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

		public _003CCoDisappear_003Ed__4(int _003C_003E1__state)
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

	public Sprite[] DirtImages;

	public ParticleSystem CleanedEffect;

	private int imgIdx;

	public override void Reset()
	{
		throw null;
	}

	public IEnumerator CoDisappear()
	{
		throw null;
	}

	public VentDirt()
	{
		throw null;
	}
}
