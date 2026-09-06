using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignGame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public AlignGame _003C_003E4__this;

		public Color green;

		public _003C_003Ec__DisplayClass14_0()
		{
			throw null;
		}

		internal void _003CLockEngine_003Eb__0(float t)
		{
			throw null;
		}
	}

	private sealed class _003CLockEngine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignGame _003C_003E4__this;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

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

		public _003CLockEngine_003Ed__14(int _003C_003E1__state)
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

	private Controller myController;

	public FloatRange YRange;

	public AnimationCurve curve;

	public LineRenderer centerline;

	public LineRenderer[] guidelines;

	public SpriteRenderer engine;

	public Collider2D col;

	public TextController StatusText;

	private float pulseTimer;

	private Material cachedCenterlineMat;

	private Material cachedGuideline0Mat;

	private Material cachedGuideline1Mat;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator LockEngine()
	{
		throw null;
	}

	public static float FromByte(byte b)
	{
		throw null;
	}

	public static byte ToByte(float y)
	{
		throw null;
	}

	public static bool IsSuccess(byte b)
	{
		throw null;
	}

	public AlignGame()
	{
		throw null;
	}
}
