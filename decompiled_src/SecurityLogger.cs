using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityLogger : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int i;

		public Func<PlayerControl, bool> _003C_003E9__0;

		public _003C_003Ec__DisplayClass9_0()
		{
			throw null;
		}

		internal bool _003CFixedUpdate_003Eb__0(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003CBlinkSensor_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SecurityLogger _003C_003E4__this;

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

		public _003CBlinkSensor_003Ed__10(int _003C_003E1__state)
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

	private static Collider2D[] hits;

	public SecurityLogBehaviour LogParent;

	public SecurityLogBehaviour.SecurityLogLocations MyLocation;

	public float Cooldown;

	public SpriteRenderer Image;

	public BoxCollider2D Sensor;

	private float[] Timers;

	private ContactFilter2D filter;

	private void Awake()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private IEnumerator BlinkSensor()
	{
		throw null;
	}

	public SecurityLogger()
	{
		throw null;
	}

	static SecurityLogger()
	{
		throw null;
	}
}
