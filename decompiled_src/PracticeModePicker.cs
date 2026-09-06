using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PracticeModePicker
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public byte picked;

		public bool done;

		public _003C_003Ec__DisplayClass12_0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public byte capturedMode;

		public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals1;

		public _003C_003Ec__DisplayClass12_1()
		{
			throw null;
		}

		internal void _003CCoPickMode_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoPickMode_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		public Action<byte> onPicked;

		private GameObject _003CesObj_003E5__2;

		private GameObject _003CcanvasObj_003E5__3;

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

		public _003CCoPickMode_003Ed__12(int _003C_003E1__state)
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

	private static readonly byte[] ModeIds;

	private static readonly StringNames[] LabelIds;

	private static readonly string[] FallbackLabels;

	private static readonly string[] RunnerDisabledMapNames;

	private static bool _003CIsPicking_003Ek__BackingField;

	public static bool IsPicking
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private static bool IsRunnerAllowedOnCurrentMap()
	{
		throw null;
	}

	public static void ClearGate()
	{
		throw null;
	}

	public static IEnumerator CoPickMode(Action<byte> onPicked)
	{
		throw null;
	}

	private static string GetTitleLabel()
	{
		throw null;
	}

	private static string GetModeLabel(int index)
	{
		throw null;
	}

	private static bool IsOptionsMenuOpen()
	{
		throw null;
	}

	static PracticeModePicker()
	{
		throw null;
	}
}
