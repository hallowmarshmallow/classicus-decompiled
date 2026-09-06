using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMemory : MonoBehaviour
{
	private sealed class _003CCoUnload_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003Cid_003E5__2;

		private string _003Creason_003E5__3;

		private string _003CsceneName_003E5__4;

		private float _003Cwaited_003E5__5;

		private long _003CgfxBefore_003E5__6;

		private long _003CtexBytesBefore_003E5__7;

		private int _003CtexBefore_003E5__8;

		private long _003CnatBefore_003E5__9;

		private long _003CresBefore_003E5__10;

		private long _003CmonoBefore_003E5__11;

		private float _003CstartedAt_003E5__12;

		private int _003CtexAfterGc_003E5__13;

		private int _003CtexAfterPass1_003E5__14;

		private int _003CtexAfterPass2_003E5__15;

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

		public _003CCoUnload_003Ed__38(int _003C_003E1__state)
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

	private const string Tag = "[MapMemory]";

	private const float LobbySpawnWaitSeconds = 12f;

	private const int ProbeZeroTolerance = 2;

	public const long Unavailable = long.MinValue;

	private static bool _unloadRequested;

	private static bool _sweeping;

	private static string _requestReason;

	private static int _sweepCount;

	private static MapMemory _runner;

	private static float _lastSweepEndedAt;

	private static string _sweepOwner;

	private static int _gfxZeroStreak;

	private static bool _gfxUnavailable;

	private static int _texBytesZeroStreak;

	private static bool _texBytesUnavailable;

	private static bool _mapLoadValid;

	private static string _mapLoadName;

	private static int _texAtMapLoad;

	private static long _texBytesAtMapLoad;

	private static bool SweepEnabled
	{
		get
		{
			throw null;
		}
	}

	public static float SecondsSinceLastSweep
	{
		get
		{
			throw null;
		}
	}

	private static void Install()
	{
		throw null;
	}

	public static bool TryClaimSweep(string owner, float cooldownSeconds, out string refusal)
	{
		throw null;
	}

	public static void ReleaseSweepClaim(string owner)
	{
		throw null;
	}

	public static AsyncOperation BeginUnloadUnusedAssets()
	{
		throw null;
	}

	public static void SafeCollect()
	{
		throw null;
	}

	public static void ReleaseMap(string reason, string caller = "", string file = "", int line = 0)
	{
		throw null;
	}

	private static void ReleaseCore(ShipStatus ship, string reason, string caller, string file, int line)
	{
		throw null;
	}

	public static void ReleaseMapOwnedBy(ShipStatus ship, string reason, string caller = "", string file = "", int line = 0)
	{
		throw null;
	}

	private static void ReleaseMinimap(out bool shellRooted, out bool unityAlive)
	{
		throw null;
	}

	private static void ReleaseRoundStatics()
	{
		throw null;
	}

	private static bool IsDeadShell(UnityEngine.Object o)
	{
		throw null;
	}

	public static void RequestUnload(string caller = "", string file = "", int line = 0)
	{
		throw null;
	}

	public static void NoteMapLoaded(string mapName)
	{
		throw null;
	}

	public static void AssertNoResidentMap(string where)
	{
		throw null;
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private IEnumerator CoUnload()
	{
		throw null;
	}

	private static void ReportSinceMapLoad(int id, int texAfter, long texBytesAfter)
	{
		throw null;
	}

	private static void ReportVerdict(int id, int released)
	{
		throw null;
	}

	private static bool AnyRoundRootPresent()
	{
		throw null;
	}

	private static bool IsPresent(UnityEngine.Object o)
	{
		throw null;
	}

	public static string RootReport()
	{
		throw null;
	}

	private static string RootState(UnityEngine.Object o)
	{
		throw null;
	}

	public static int LoadedTextureCount()
	{
		throw null;
	}

	public static long SampleTextureBytes(out int count)
	{
		throw null;
	}

	public static long SafeGfxBytes()
	{
		throw null;
	}

	private static long ProbeGfxDriver()
	{
		throw null;
	}

	private static string GfxSource()
	{
		throw null;
	}

	public static long SafeNativeAllocated()
	{
		throw null;
	}

	public static long SafeNativeReserved()
	{
		throw null;
	}

	public static long SafeMonoUsed()
	{
		throw null;
	}

	private static string Snapshot()
	{
		throw null;
	}

	public static string MB(long bytes)
	{
		throw null;
	}

	private static string Delta(long before, long after)
	{
		throw null;
	}

	private static string ShortFile(string path)
	{
		throw null;
	}

	public MapMemory()
	{
		throw null;
	}

	static MapMemory()
	{
		throw null;
	}
}
