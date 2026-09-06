using System;
using UnityEngine;

public class AntiNoclipWatchdog : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__4_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CAwake_003Eb__4_0()
		{
			throw null;
		}
	}

	private const float CheckInterval = 1f;

	private AntiNoclipChecker target;

	private static bool s_IsAppQuitting;

	private static bool s_QuitHooked;

	private void Awake()
	{
		throw null;
	}

	public void SetTarget(AntiNoclipChecker checker)
	{
		throw null;
	}

	public void ClearTarget()
	{
		throw null;
	}

	public AntiNoclipWatchdog()
	{
		throw null;
	}
}
