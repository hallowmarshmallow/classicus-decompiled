using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleBehaviour : MonoBehaviour
{
	public enum Movement
	{
		ConstantBounce,
		RandomBounce
	}

	private sealed class _003CConsistantBounce_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NeedleBehaviour _003C_003E4__this;

		private Quaternion _003Cinitial_003E5__2;

		private Quaternion _003Cfinal_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CConsistantBounce_003Ed__1(int _003C_003E1__state)
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

	private sealed class _003CRandomBounce_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NeedleBehaviour _003C_003E4__this;

		private Quaternion _003Cinitial_003E5__2;

		private Quaternion _003Cfinal_003E5__3;

		private float _003Ctime_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRandomBounce_003Ed__2(int _003C_003E1__state)
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

	private sealed class _003CSpin_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NeedleBehaviour _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSpin_003Ed__4(int _003C_003E1__state)
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

	public float duration;

	public float initialAngle;

	public float amount;

	public Movement movementType;

	public bool randomInitialAngle;

	public FloatRange initialAngleRange;

	public void Start()
	{
	}

	public IEnumerator ConsistantBounce()
	{
		return null;
	}

	public IEnumerator RandomBounce()
	{
		return null;
	}

	public void StartSpin(float duration)
	{
	}

	public IEnumerator Spin(float duration)
	{
		return null;
	}
}
