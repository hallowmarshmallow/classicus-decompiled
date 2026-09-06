using System;
using System.Collections.Generic;
using UnityEngine;

public sealed class RunnerPlayerList : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PlayerVoteArea> _003C_003E9__15_0;

		internal int _003CAwake_003Eb__15_0(PlayerVoteArea a, PlayerVoteArea b)
		{
			return 0;
		}
	}

	private const float RowSpacing = 0.4f;

	private const int MaxVisible = 13;

	private const float RefreshInterval = 0.5f;

	internal static RunnerPlayerList Instance;

	private PlayerVoteArea _template;

	private Transform _cloneParent;

	private Vector3 _anchorLocalPos;

	private readonly List<PlayerVoteArea> _pool;

	private readonly HashSet<PlayerVoteArea> _setupDone;

	private Transform _upArrow;

	private Transform _downArrow;

	private GameObject _header;

	private int _scroll;

	private float _timer;

	private bool _shown;

	private bool _rowThemeDark;

	private bool _rowThemeApplied;

	private const float FrontRowZ = -9.8f;

	private const float BackRowZ = -10f;

	private void Awake()
	{
	}

	private void ApplyRowTheme(bool force)
	{
	}

	private void OnDestroy()
	{
	}

	private static string LocalisedHeader()
	{
		return null;
	}

	private void Update()
	{
	}

	private static bool ShouldShow()
	{
		return false;
	}

	private void HideEverything()
	{
	}

	private void Rebuild()
	{
	}

	private static List<GameData.PlayerInfo> GetPlayers()
	{
		return null;
	}

	private void Populate(PlayerVoteArea slot, GameData.PlayerInfo info)
	{
	}

	private static void SetupSlotAvatar(PlayerVoteArea slot)
	{
	}

	private static T FindComponentInChild<T>(Transform root, string name) where T : Component
	{
		return null;
	}

	private void HandleArrowClicks()
	{
	}

	private static bool HitsSprite(Transform t, Vector3 worldPoint)
	{
		return false;
	}

	private static void DisableClickColliders(PlayerVoteArea slot)
	{
	}

	private static Transform FindDeep(Transform root, string name)
	{
		return null;
	}
}
