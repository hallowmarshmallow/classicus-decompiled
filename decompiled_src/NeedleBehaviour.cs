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

		public _003CConsistantBounce_003Ed__1(int _003C_003E1__state)
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

	private sealed class _003CRandomBounce_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NeedleBehaviour _003C_003E4__this;

		private Quaternion _003Cinitial_003E5__2;

		private Quaternion _003Cfinal_003E5__3;

		private float _003Ctime_003E5__4;

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

		public _003CRandomBounce_003Ed__2(int _003C_003E1__state)
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

	private sealed class _003CSpin_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NeedleBehaviour _003C_003E4__this;

		private float _003Ctime_003E5__2;

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

		public _003CSpin_003Ed__4(int _003C_003E1__state)
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

	public float duration;

	public float initialAngle;

	public float amount;

	public Movement movementType;

	public bool randomInitialAngle;

	public FloatRange initialAngleRange;

	public void Start()
	{
		throw null;
	}

	public IEnumerator ConsistantBounce()
	{
		throw null;
	}

	public IEnumerator RandomBounce()
	{
		throw null;
	}

	public void StartSpin(float duration)
	{
		throw null;
	}

	public IEnumerator Spin(float duration)
	{
		throw null;
	}

	public NeedleBehaviour()
	{
		throw null;
	}
}
