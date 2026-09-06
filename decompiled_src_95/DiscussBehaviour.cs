using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscussBehaviour : MonoBehaviour
{
	private sealed class _003CAnimateText_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiscussBehaviour _003C_003E4__this;

		private Vector3 _003Cvec_003E5__2;

		private float _003Ct2_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimateText_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CPlayAnimation_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiscussBehaviour _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnimation_003Ed__10(int _003C_003E1__state)
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

	public SpriteRenderer LeftPlayer;

	public SpriteRenderer RightPlayer;

	public SpriteRenderer Text;

	public FloatRange RotateRange;

	public Vector2Range TextTarget;

	public AnimationCurve TextEasing;

	public float Delay;

	public float TextDuration;

	public float HoldDuration;

	private Vector3 vec;

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

	private void UpdateText(ref Vector3 vec, float p)
	{
	}
}
