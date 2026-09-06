using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartFramePacer : MonoBehaviour
{
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SmartFramePacer _003C_003E4__this;

		private WaitForSecondsRealtime _003Cwait_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStart_003Ed__5(int _003C_003E1__state)
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

	private const float ENFORCEMENT_INTERVAL = 2f;

	private static SmartFramePacer instance;

	private int intendedVSyncCount;

	private int intendedTargetFps;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	public static void Refresh()
	{
	}

	private void Apply()
	{
	}

	private void Enforce()
	{
	}

	private void OnDestroy()
	{
	}
}
