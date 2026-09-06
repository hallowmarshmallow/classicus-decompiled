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

		internal void _003CLockEngine_003Eb__0(float t)
		{
		}
	}

	private sealed class _003CLockEngine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignGame _003C_003E4__this;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLockEngine_003Ed__14(int _003C_003E1__state)
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
	}

	public void Update()
	{
	}

	private IEnumerator LockEngine()
	{
		return null;
	}

	public static float FromByte(byte b)
	{
		return 0f;
	}

	public static byte ToByte(float y)
	{
		return 0;
	}

	public static bool IsSuccess(byte b)
	{
		return false;
	}
}
