using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerBehaviour : MonoBehaviour
{
	private sealed class _003CDoClick_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public FingerBehaviour _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoClick_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CMoveTo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FingerBehaviour _003C_003E4__this;

		public Vector2 target;

		public float duration;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CtargetPos_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveTo_003Ed__8(int _003C_003E1__state)
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

	public SpriteRenderer Finger;

	public SpriteRenderer Click;

	public float liftedAngle;

	public IEnumerator DoClick(float duration)
	{
		return null;
	}

	private void SetFingerAngle(float angle)
	{
	}

	public void ClickOff()
	{
	}

	public void ClickOn()
	{
	}

	public IEnumerator MoveTo(Vector2 target, float duration)
	{
		return null;
	}
}
