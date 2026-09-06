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
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	internal static void RecordPing(byte playerId, int latencyMs)
	{
	}

	internal static int GetPing(byte playerId)
	{
		return 0;
	}

	internal static void Reset()
	{
	}

	private void PruneStaleEntries()
	{
	}

	private void RebuildLabel()
	{
	}

	private static string GetPlayerName(byte playerId)
	{
		return null;
	}

	private static Texture2D MakeSolidTexture(Color color)
	{
		return null;
	}
}
