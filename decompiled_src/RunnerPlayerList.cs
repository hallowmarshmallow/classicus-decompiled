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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal int _003CAwake_003Eb__15_0(PlayerVoteArea a, PlayerVoteArea b)
		{
			throw null;
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
		throw null;
	}

	private void ApplyRowTheme(bool force)
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private static string LocalisedHeader()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static bool ShouldShow()
	{
		throw null;
	}

	private void HideEverything()
	{
		throw null;
	}

	private void Rebuild()
	{
		throw null;
	}

	private static List<GameData.PlayerInfo> GetPlayers()
	{
		throw null;
	}

	private void Populate(PlayerVoteArea slot, GameData.PlayerInfo info)
	{
		throw null;
	}

	private static void SetupSlotAvatar(PlayerVoteArea slot)
	{
		throw null;
	}

	private static T FindComponentInChild<T>(Transform root, string name) where T : Component
	{
		throw null;
	}

	private void HandleArrowClicks()
	{
		throw null;
	}

	private static bool HitsSprite(Transform t, Vector3 worldPoint)
	{
		throw null;
	}

	private static void DisableClickColliders(PlayerVoteArea slot)
	{
		throw null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		throw null;
	}

	public RunnerPlayerList()
	{
		throw null;
	}
}
