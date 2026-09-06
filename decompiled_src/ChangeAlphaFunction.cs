using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ChangeAlphaFunction
{
	private sealed class _003CFadeSpriteRendererIn_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer spriteRenderer;

		public float duration;

		private Color _003CstartColor_003E5__2;

		private Color _003CtargetColor_003E5__3;

		private float _003CelapsedTime_003E5__4;

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

		public _003CFadeSpriteRendererIn_003Ed__0(int _003C_003E1__state)
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

	private sealed class _003CFadeSpriteRendererOut_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer spriteRenderer;

		public float duration;

		private Color _003CstartColor_003E5__2;

		private Color _003CtargetColor_003E5__3;

		private float _003CelapsedTime_003E5__4;

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

		public _003CFadeSpriteRendererOut_003Ed__1(int _003C_003E1__state)
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

	public static IEnumerator FadeSpriteRendererIn(SpriteRenderer spriteRenderer, float duration)
	{
		throw null;
	}

	public static IEnumerator FadeSpriteRendererOut(SpriteRenderer spriteRenderer, float duration)
	{
		throw null;
	}
}
