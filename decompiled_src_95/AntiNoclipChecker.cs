using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntiNoclipChecker : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__19_0;

		internal void _003CAwake_003Eb__19_0()
		{
		}
	}

	private sealed class _003CCoDelayedInit_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AntiNoclipChecker _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDelayedInit_003Ed__22(int _003C_003E1__state)
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

	internal const bool DetectionEnabled = false;

	internal static bool s_KickTriggered;

	private static bool s_IsAppQuitting;

	private static bool s_QuitHooked;

	private bool s_SceneUnloading;

	private const float InitialGraceSeconds = 5f;

	private const float IntegrityCheckInterval = 2f;

	private const float MinMoveSqr = 0.0001f;

	private static readonly string[] WatchLayerNames;

	private int edgeLineMask;

	private readonly List<Collider2D> watchedColliders;

	private Vector2 previousPosition;

	private bool positionSeeded;

	private bool initialized;

	private bool kickPending;

	private bool selfDisabling;

	private Scene myScene;

	private static readonly RaycastHit2D[] castBuffer;

	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void OnSceneUnloaded(Scene unloaded)
	{
	}

	private void Start()
	{
	}

	private IEnumerator CoDelayedInit()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckWallCrossing(Vector2 from, Vector2 to)
	{
	}

	private void CheckColliderIntegrity()
	{
	}

	private static bool IsDoorCollider(Collider2D col)
	{
		return false;
	}

	private static bool IsInGraceState(PlayerControl player)
	{
		return false;
	}

	internal void TriggerKick()
	{
	}
}
