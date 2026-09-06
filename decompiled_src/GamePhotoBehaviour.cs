using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePhotoBehaviour : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public GamePhotoBehaviour _003C_003E4__this;

		public bool inWater;

		public _003C_003Ec__DisplayClass8_0()
		{
			throw null;
		}

		internal void _003CDrop_003Eb__0(float t)
		{
			throw null;
		}

		internal void _003CDrop_003Eb__1()
		{
			throw null;
		}
	}

	private sealed class _003CDrop_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePhotoBehaviour _003C_003E4__this;

		public bool inWater;

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

		public _003CDrop_003Ed__8(int _003C_003E1__state)
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

	private sealed class _003CPickup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePhotoBehaviour _003C_003E4__this;

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

		public _003CPickup_003Ed__7(int _003C_003E1__state)
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

	public static readonly Color InWaterPink;

	public float zOffset;

	public SpriteRenderer Frame;

	public SpriteRenderer Image;

	public Collider2D Hitbox;

	public Color TargetColor;

	public void Start()
	{
		throw null;
	}

	internal IEnumerator Pickup()
	{
		throw null;
	}

	internal IEnumerator Drop(bool inWater)
	{
		throw null;
	}

	public GamePhotoBehaviour()
	{
		throw null;
	}

	static GamePhotoBehaviour()
	{
		throw null;
	}

	private void _003CPickup_003Eb__7_0(float t)
	{
		throw null;
	}

	private void _003CPickup_003Eb__7_1()
	{
		throw null;
	}
}
