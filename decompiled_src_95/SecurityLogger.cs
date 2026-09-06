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

		internal bool _003CFixedUpdate_003Eb__0(PlayerControl p)
		{
			return false;
		}
	}

	private sealed class _003CBlinkSensor_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SecurityLogger _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBlinkSensor_003Ed__10(int _003C_003E1__state)
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
	}

	public void FixedUpdate()
	{
	}

	private IEnumerator BlinkSensor()
	{
		return null;
	}
}
