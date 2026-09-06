using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedScanMinigame : Minigame
{
	private enum PositionState
	{
		None,
		WalkingToPad,
		WalkingToOffset
	}

	private sealed class _003CWalkToOffset_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MedScanMinigame _003C_003E4__this;

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

		public _003CWalkToOffset_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CWalkToPad_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MedScanMinigame _003C_003E4__this;

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

		public _003CWalkToPad_003Ed__19(int _003C_003E1__state)
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

	private static readonly string[] ColorNames;

	private static readonly string[] BloodTypes;

	public TextRenderer text;

	public TextRenderer charStats;

	public HorizontalGauge gauge;

	private MedScanSystem medscan;

	public float ScanDuration;

	public float ScanTimer;

	private string completeString;

	public AudioClip ScanSound;

	public AudioClip TextSound;

	private Coroutine walking;

	private PositionState state;

	private float _requestRetryTimer;

	private const float RequestRetryInterval = 1.5f;

	private bool released;

	private static string ColorNameFor(int colorId)
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private IEnumerator WalkToOffset()
	{
		throw null;
	}

	private IEnumerator WalkToPad()
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	private void ReleaseScanner()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public MedScanMinigame()
	{
		throw null;
	}

	static MedScanMinigame()
	{
		throw null;
	}
}
