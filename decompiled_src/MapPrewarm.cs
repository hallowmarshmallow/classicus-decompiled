using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapPrewarm
{
	private class Runner : MonoBehaviour
	{
		private void Update()
		{
			throw null;
		}

		public Runner()
		{
			throw null;
		}
	}

	private sealed class _003CCoAbandon_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string droppedName;

		public string reason;

		public MapData dropped;

		private int _003CtexBefore_003E5__2;

		private float _003CstartedAt_003E5__3;

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

		public _003CCoAbandon_003Ed__43(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoWaitUntilReady_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string mapName;

		public float maxSeconds;

		private MapData _003Cmap_003E5__2;

		private float _003CstartedAt_003E5__3;

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

		public _003CCoWaitUntilReady_003Ed__32(int _003C_003E1__state)
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

	private sealed class _003CCoWarmSpawnPicker_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string mapName;

		private float _003CstartedAt_003E5__2;

		private GameObject _003Cwarm_003E5__3;

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

		public _003CCoWarmSpawnPicker_003Ed__34(int _003C_003E1__state)
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

	private static readonly HashSet<string> warmedMaps;

	private static float lastTickAt;

	private static MapData warming;

	private static string warmingName;

	private static bool committed;

	private static float stateChangedAt;

	private static string hoverName;

	private static float hoverStartedAt;

	private static bool abandonPending;

	private static float abandonAt;

	private static string abandonReason;

	private static Runner runner;

	private static readonly HashSet<string> spawnPickerWarmed;

	public static bool IsCommitted
	{
		get
		{
			throw null;
		}
	}

	public static void HoverEnter(string mapName)
	{
		throw null;
	}

	public static void HoverExit(string mapName)
	{
		throw null;
	}

	private static void CancelPendingAbandon()
	{
		throw null;
	}

	public static void Request(string mapName)
	{
		throw null;
	}

	public static void Commit(string mapName)
	{
		throw null;
	}

	public static IEnumerator CoWaitUntilReady(string mapName, float maxSeconds)
	{
		throw null;
	}

	public static IEnumerator CoWarmSpawnPicker(string mapName)
	{
		throw null;
	}

	private static GameObject TryInstantiateSpawnPicker(string mapName, out float startedAt)
	{
		throw null;
	}

	private static void DestroyWarmedSpawnPicker(GameObject warm, string mapName, float startedAt)
	{
		throw null;
	}

	public static bool AlreadyWarmed(string mapName)
	{
		throw null;
	}

	public static void WarmShaderVariants(string mapName)
	{
		throw null;
	}

	private static void WarmShaderVariantsCore(string mapName)
	{
		throw null;
	}

	private static bool TryBuildVariant(Shader shader, string[] keywords, out ShaderVariantCollection.ShaderVariant variant)
	{
		throw null;
	}

	public static void NotifyConsumed(MapData map)
	{
		throw null;
	}

	public static void Abandon(string reason)
	{
		throw null;
	}

	private static IEnumerator CoAbandon(MapData dropped, string droppedName, string reason)
	{
		throw null;
	}

	private static void Tick()
	{
		throw null;
	}

	private static void EnsureRunner()
	{
		throw null;
	}

	static MapPrewarm()
	{
		throw null;
	}
}
