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

		public _003CAnimateHand_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CAnimateText_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShhhBehaviour _003C_003E4__this;

		private Vector3 _003Cvec_003E5__2;

		private float _003Ct2_003E5__3;

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

		public _003CAnimateText_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CPlayAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShhhBehaviour _003C_003E4__this;

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

		public _003CPlayAnimation_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CWaitWithInterrupt_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		private float _003Ctimer_003E5__2;

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

		public _003CWaitWithInterrupt_003Ed__25(int _003C_003E1__state)
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
		throw null;
	}

	public IEnumerator PlayAnimation()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator AnimateText()
	{
		throw null;
	}

	private IEnumerator AnimateHand()
	{
		throw null;
	}

	private void UpdateHand(ref Vector3 vec, float p)
	{
		throw null;
	}

	private void UpdateText(ref Vector3 vec, float p)
	{
		throw null;
	}

	public static IEnumerator WaitWithInterrupt(float duration)
	{
		throw null;
	}

	public static bool CheckForInterrupt()
	{
		throw null;
	}

	public ShhhBehaviour()
	{
		throw null;
	}
}
