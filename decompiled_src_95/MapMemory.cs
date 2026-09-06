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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoUnload_003Ed__38(int _003C_003E1__state)
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

	private static bool SweepEnabled => false;

	public static float SecondsSinceLastSweep => 0f;

	private static void Install()
	{
	}

	public static bool TryClaimSweep(string owner, float cooldownSeconds, out string refusal)
	{
		refusal = null;
		return false;
	}

	public static void ReleaseSweepClaim(string owner)
	{
	}

	public static AsyncOperation BeginUnloadUnusedAssets()
	{
		return null;
	}

	public static void SafeCollect()
	{
	}

	public static void ReleaseMap(string reason, string caller = "", string file = "", int line = 0)
	{
	}

	private static void ReleaseCore(ShipStatus ship, string reason, string caller, string file, int line)
	{
	}

	public static void ReleaseMapOwnedBy(ShipStatus ship, string reason, string caller = "", string file = "", int line = 0)
	{
	}

	private static void ReleaseMinimap(out bool shellRooted, out bool unityAlive)
	{
		shellRooted = default(bool);
		unityAlive = default(bool);
	}

	private static void ReleaseRoundStatics()
	{
	}

	private static bool IsDeadShell(UnityEngine.Object o)
	{
		return false;
	}

	public static void RequestUnload(string caller = "", string file = "", int line = 0)
	{
	}

	public static void NoteMapLoaded(string mapName)
	{
	}

	public static void AssertNoResidentMap(string where)
	{
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private IEnumerator CoUnload()
	{
		return null;
	}

	private static void ReportSinceMapLoad(int id, int texAfter, long texBytesAfter)
	{
	}

	private static void ReportVerdict(int id, int released)
	{
	}

	private static bool AnyRoundRootPresent()
	{
		return false;
	}

	private static bool IsPresent(UnityEngine.Object o)
	{
		return false;
	}

	public static string RootReport()
	{
		return null;
	}

	private static string RootState(UnityEngine.Object o)
	{
		return null;
	}

	public static int LoadedTextureCount()
	{
		return 0;
	}

	public static long SampleTextureBytes(out int count)
	{
		count = default(int);
		return 0L;
	}

	public static long SafeGfxBytes()
	{
		return 0L;
	}

	private static long ProbeGfxDriver()
	{
		return 0L;
	}

	private static string GfxSource()
	{
		return null;
	}

	public static long SafeNativeAllocated()
	{
		return 0L;
	}

	public static long SafeNativeReserved()
	{
		return 0L;
	}

	public static long SafeMonoUsed()
	{
		return 0L;
	}

	private static string Snapshot()
	{
		return null;
	}

	public static string MB(long bytes)
	{
		return null;
	}

	private static string Delta(long before, long after)
	{
		return null;
	}

	private static string ShortFile(string path)
	{
		return null;
	}
}
