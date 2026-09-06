using System.Collections.Generic;
using UnityEngine;

namespace KlassicHideNSeek;

internal sealed class HnSPingTracker : MonoBehaviour
{
	private static HnSPingTracker _003CInstance_003Ek__BackingField;

	private const float RefreshInterval = 1f;

	private const float StaleTimeout = 8f;

	private readonly Dictionary<byte, (int, float)> _pingTable;

	private float _sinceLastRefresh;

	private GUIStyle _guiStyle;

	private string _cachedLabel;

	internal static HnSPingTracker Instance
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

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnGUI()
	{
		throw null;
	}

	internal static void RecordPing(byte playerId, int latencyMs)
	{
		throw null;
	}

	internal static int GetPing(byte playerId)
	{
		throw null;
	}

	internal static void Reset()
	{
		throw null;
	}

	private void PruneStaleEntries()
	{
		throw null;
	}

	private void RebuildLabel()
	{
		throw null;
	}

	private static string GetPlayerName(byte playerId)
	{
		throw null;
	}

	private static Texture2D MakeSolidTexture(Color color)
	{
		throw null;
	}

	public HnSPingTracker()
	{
		throw null;
	}
}
