using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTracker : MonoBehaviour
{
	private sealed class _003CCoSlideIn_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomTracker _003C_003E4__this;

		public SystemTypes newRoom;

		private Vector3 _003CtempPos_003E5__2;

		private Color _003CtempColor_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSlideIn_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CSlideOut_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomTracker _003C_003E4__this;

		private Vector3 _003CtempPos_003E5__2;

		private Color _003CtempColor_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSlideOut_003Ed__12(int _003C_003E1__state)
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

	public TextRenderer text;

	public float SourceY;

	public float TargetY;

	private Collider2D playerCollider;

	private ContactFilter2D filter;

	private Collider2D[] buffer;

	public ShipRoom LastRoom;

	private Coroutine slideInRoutine;

	public void Awake()
	{
	}

	public void OnDisable()
	{
	}

	public void FixedUpdate()
	{
	}

	private IEnumerator CoSlideIn(SystemTypes newRoom)
	{
		return null;
	}

	private IEnumerator SlideOut()
	{
		return null;
	}

	private static bool CheckHitsForPlayer(Collider2D[] buffer, int hitCount)
	{
		return false;
	}
}
