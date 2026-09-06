using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene0Controller : SceneController
{
	private sealed class _003CPopIn_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer boy;

		public Scene0Controller _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPopIn_003Ed__8(int _003C_003E1__state)
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

	private sealed class _003CPopOut_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer boy;

		public Scene0Controller _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPopOut_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene0Controller _003C_003E4__this;

		private int _003ClastBoy_003E5__2;

		private float _003Cstart_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRun_003Ed__7(int _003C_003E1__state)
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

	public float Duration;

	public SpriteRenderer[] ExtraBoys;

	public AnimationCurve PopInCurve;

	public AnimationCurve PopOutCurve;

	public float OutDuration;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private IEnumerator Run()
	{
		return null;
	}

	private IEnumerator PopIn(SpriteRenderer boy)
	{
		return null;
	}

	private IEnumerator PopOut(SpriteRenderer boy)
	{
		return null;
	}
}
