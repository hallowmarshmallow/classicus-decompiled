using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
	private sealed class _003CCoShakeScreen_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public FollowerCamera _003C_003E4__this;

		public float severity;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShakeScreen_003Ed__9(int _003C_003E1__state)
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

	public MonoBehaviour Target;

	public Vector2 Offset;

	public bool Locked;

	public float shakeAmount;

	public float shakePeriod;

	private const float FollowSpeed = 5f;

	private Vector3 lastShakeOffset;

	public void Update()
	{
	}

	public void ShakeScreen(float duration, float severity)
	{
	}

	private IEnumerator CoShakeScreen(float duration, float severity)
	{
		return null;
	}

	internal void SetTarget(MonoBehaviour target)
	{
	}

	public void Snap()
	{
	}
}
