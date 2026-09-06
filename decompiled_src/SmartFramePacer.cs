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

		public _003CStart_003Ed__5(int _003C_003E1__state)
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

	private const float ENFORCEMENT_INTERVAL = 2f;

	private static SmartFramePacer instance;

	private int intendedVSyncCount;

	private int intendedTargetFps;

	private void Awake()
	{
		throw null;
	}

	private IEnumerator Start()
	{
		throw null;
	}

	public static void Refresh()
	{
		throw null;
	}

	private void Apply()
	{
		throw null;
	}

	private void Enforce()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public SmartFramePacer()
	{
		throw null;
	}
}
