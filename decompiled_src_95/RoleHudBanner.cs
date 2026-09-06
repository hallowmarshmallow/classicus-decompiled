using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class RoleHudBanner
{
	private sealed class _003CCoFade_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float holdSeconds;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFade_003Ed__6(int _003C_003E1__state)
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

	private static GameObject _canvasObj;

	private static TextMeshProUGUI _text;

	private static Coroutine _fadeRoutine;

	private static MonoBehaviour _runner;

	public static void Show(string message, Color color, float holdSeconds = 5f)
	{
	}

	private static void EnsureCanvas()
	{
	}

	private static IEnumerator CoFade(float holdSeconds)
	{
		return null;
	}
}
