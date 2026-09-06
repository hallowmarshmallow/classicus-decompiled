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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CAwake_003Eb__19_0()
		{
			throw null;
		}
	}

	private sealed class _003CCoDelayedInit_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AntiNoclipChecker _003C_003E4__this;

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

		public _003CCoDelayedInit_003Ed__22(int _003C_003E1__state)
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
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void OnSceneUnloaded(Scene unloaded)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private IEnumerator CoDelayedInit()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	private void CheckWallCrossing(Vector2 from, Vector2 to)
	{
		throw null;
	}

	private void CheckColliderIntegrity()
	{
		throw null;
	}

	private static bool IsDoorCollider(Collider2D col)
	{
		throw null;
	}

	private static bool IsInGraceState(PlayerControl player)
	{
		throw null;
	}

	internal void TriggerKick()
	{
		throw null;
	}

	public AntiNoclipChecker()
	{
		throw null;
	}

	static AntiNoclipChecker()
	{
		throw null;
	}
}
