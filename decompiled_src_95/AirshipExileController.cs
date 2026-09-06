using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipExileController : ExileController
{
	private sealed class _003CAnimate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AirshipExileController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CHandleTextCloud_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float firstWaitTime;

		public AirshipExileController _003C_003E4__this;

		private float _003CnewDur_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleTextCloud_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CPlayerFall_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AirshipExileController _003C_003E4__this;

		private Transform _003CplayerRoot_003E5__2;

		private Vector2 _003CsourcePos_003E5__3;

		private Vector2 _003CtargetPos_003E5__4;

		private Vector2 _003Canchor_003E5__5;

		private float _003Cd_003E5__6;

		private float _003Ct_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerFall_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CSlowMoSlide2D_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform target;

		public float duration;

		public Vector2 source;

		public Vector2 dest;

		public AirshipExileController _003C_003E4__this;

		private Vector3 _003Ctemp_003E5__2;

		private float _003Ctime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSlowMoSlide2D_003Ed__10(int _003C_003E1__state)
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

	public SpriteRenderer ForegroundCloud;

	public SpriteRenderer BackgroundCloud;

	public SpriteRenderer Cloud1;

	public SpriteRenderer Cloud2;

	public SpriteRenderer Cloud3;

	public SpriteRenderer HandSlot;

	public AudioClip Stinger;

	private float CloudSlowMo;

	private float PlayerSlowMo;

	protected override IEnumerator Animate()
	{
		return null;
	}

	private IEnumerator SlowMoSlide2D(Transform target, Vector2 source, Vector2 dest, float duration)
	{
		return null;
	}

	private IEnumerator HandleTextCloud(float firstWaitTime)
	{
		return null;
	}

	private IEnumerator PlayerFall()
	{
		return null;
	}

	private static Vector2 QuadBezier(float t, Vector2 p0, Vector2 control, Vector2 p2)
	{
		return default(Vector2);
	}
}
