using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RankingLeaderboard : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction<Scene, LoadSceneMode> _003C_003E9__31_0;

		internal void _003CBootstrap_003Eb__31_0(Scene scene, LoadSceneMode mode)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public int slot;

		public RankingLeaderboard _003C_003E4__this;

		internal void _003CAwake_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public AccountService.RankInfo info;

		internal void _003CCoBanCheck_003Eb__0(AccountService.RankInfo r)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public AccountService.LeaderboardPage result;

		internal void _003CCoLoadPage_003Eb__0(AccountService.LeaderboardPage r)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public Action onClick;

		internal void _003CWireButton_003Eb__0()
		{
		}
	}

	private sealed class _003CCoBanCheck_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RankingLeaderboard _003C_003E4__this;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBanCheck_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CCoLoadPage_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RankingLeaderboard _003C_003E4__this;

		public int page;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		private int _003Cgeneration_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoLoadPage_003Ed__41(int _003C_003E1__state)
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

	private const int RowsPerPage = 7;

	private Transform _board;

	private TMP_Text _title;

	private TMP_Text _pagesText;

	private GameObject _connectIcon;

	private TMP_Text _connectingText;

	private TMP_FontAsset _connectingFont;

	private GameObject _weekendBanner;

	private Transform _prevBtn;

	private Transform _nextBtn;

	private readonly List<Transform> _rows;

	private readonly List<Transform> _rowProfileBtns;

	private readonly List<string> _rowProfileIds;

	private ProfilePopup _profile;

	private readonly List<Color> _rowTrophieColors;

	private readonly List<Color> _rowNumberColors;

	private readonly List<Color> _rowNameColors;

	private static readonly Color GoldYou;

	private int _page;

	private int _pages;

	private int _loadGen;

	private bool _fetching;

	private bool _local;

	private bool _runner;

	private Transform _viewMoreBtn;

	private TMP_Text _viewMoreLabel;

	private Transform _modeBtn;

	private TMP_Text _modeLabel;

	private static Dictionary<string, Sprite> _flags;

	private bool? _profileButtonsUsable;

	private bool ProfileBlocking => false;

	private static void Bootstrap()
	{
	}

	private static void TryAttach(Scene scene)
	{
	}

	private void Awake()
	{
	}

	private void UpdateModeLabel()
	{
	}

	private void ToggleMode()
	{
	}

	private void UpdateScopeLabel()
	{
	}

	private void ToggleScope()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator CoBanCheck()
	{
		return null;
	}

	private IEnumerator CoLoadPage(int page)
	{
		return null;
	}

	private void PopulateRows(AccountService.LeaderboardEntry[] entries)
	{
	}

	private void OpenProfileForSlot(int slot)
	{
	}

	private void UpdateProfileButtons()
	{
	}

	private static Color MedalColor(List<Color> captured, int rank)
	{
		return default(Color);
	}

	private void ShowConnecting(bool show)
	{
	}

	private void UpdateNavButtons()
	{
	}

	private static void SetButtonUsable(Transform btn, bool usable)
	{
	}

	private static void WireButton(Transform btn, Action onClick)
	{
	}

	private static Sprite GetFlag(string country)
	{
		return null;
	}

	private static string GetString(StringNames name, string fallback)
	{
		return null;
	}

	private static TMP_Text DirectChildText(Transform parent, string name)
	{
		return null;
	}

	private static TMP_Text ChildText(Transform root, string name)
	{
		return null;
	}

	private static Transform FindChild(Transform root, string name)
	{
		return null;
	}

	private static Transform FindSceneObject(string name)
	{
		return null;
	}

	private void _003CAwake_003Eb__33_0()
	{
	}

	private void _003CAwake_003Eb__33_1()
	{
	}

	private void _003CAwake_003Eb__33_2()
	{
	}

	private void _003CAwake_003Eb__33_3()
	{
	}
}
