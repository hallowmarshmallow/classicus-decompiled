using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShhhBehaviour : MonoBehaviour
{
	private sealed class _003CAnimateHand_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShhhBehaviour _003C_003E4__this;

		private Vector3 _003Cvec_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimateHand_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CAnimateText_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShhhBehaviour _003C_003E4__this;

		private Vector3 _003Cvec_003E5__2;

		private float _003Ct2_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimateText_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CPlayAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShhhBehaviour _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnimation_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CWaitWithInterrupt_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitWithInterrupt_003Ed__25(int _003C_003E1__state)
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

	public SpriteRenderer Background;

	public SpriteRenderer Body;

	public SpriteRenderer Hand;

	public SpriteRenderer TextImage;

	public float RotateSpeed;

	public Vector2Range HandTarget;

	public AnimationCurve PositionEasing;

	public FloatRange HandRotate;

	public AnimationCurve RotationEasing;

	public Vector2Range TextTarget;

	public AnimationCurve TextEasing;

	public float Duration;

	public float Delay;

	public float TextDuration;

	public float PulseDuration;

	public float PulseSize;

	public float HoldDuration;

	public bool Autoplay;

	public void OnEnable()
	{
	}

	public IEnumerator PlayAnimation()
	{
		return null;
	}

	public void Update()
	{
	}

	private IEnumerator AnimateText()
	{
		return null;
	}

	private IEnumerator AnimateHand()
	{
		return null;
	}

	private void UpdateHand(ref Vector3 vec, float p)
	{
	}

	private void UpdateText(ref Vector3 vec, float p)
	{
	}

	public static IEnumerator WaitWithInterrupt(float duration)
	{
		return null;
	}

	public static bool CheckForInterrupt()
	{
		return false;
	}
}
