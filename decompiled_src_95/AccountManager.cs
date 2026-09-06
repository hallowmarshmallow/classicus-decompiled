using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccountManager : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public bool ok;

		public string lastError;

		public bool finished;

		internal void _003CCoStartupLogin_003Eb__0(bool success, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public SpriteRenderer sprite;

		internal void _003CWireTabHover_003Eb__0()
		{
		}

		internal void _003CWireTabHover_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public bool ok;

		internal void _003CCoCheckServerPopup_003Eb__0(bool success, string error)
		{
		}
	}

	private sealed class _003CCoCheckServerPopup_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

		private int _003Cattempt_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCheckServerPopup_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CCoStartupLogin_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		private int _003CquickAttempts_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartupLogin_003Ed__42(int _003C_003E1__state)
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

	private static AccountManager _003CInstance_003Ek__BackingField;

	public SlideOpen Tab;

	public GameObject TabRoot;

	public GameObject LoginRoot;

	private bool _reportedServerDown;

	private TMP_Text _backupLabel;

	private string _backupLabelOriginalText;

	private Color _backupLabelOriginalColor;

	private bool _backupLabelLoggedIn;

	private static readonly Color LoggedInGreen;

	private static readonly string[] MenuScenes;

	private TMP_Text _roleLabel;

	private Coroutine _startupLogin;

	private TMP_Text _localLabel;

	private string _localLabelBaseText;

	private Color _localLabelBaseColor;

	private readonly List<GameObject> _hiddenForLogin;

	public GameObject ReportRoot;

	private readonly List<GameObject> _hiddenForReport;

	public GameObject StatsRoot;

	private readonly List<GameObject> _hiddenForStats;

	private string _lastShownServerPopup;

	private static readonly string[] OnlineGatedButtons;

	private static readonly Color OfflineGray;

	private readonly Dictionary<SpriteRenderer, Color> _gatedColors;

	private static bool _loginNudgeShown;

	private bool _popupCheckInFlight;

	private bool _statsHooked;

	private float _statsDirtyAt;

	private bool _statsUploading;

	private string _statsSyncedAccountId;

	private const int GEOCLASS_NATION = 16;

	private const int GEO_ISO2 = 4;

	private Vector3 _tabClosedBase;

	private Vector3 _tabOpenBase;

	private bool _tabBaseCaptured;

	private bool _tabAlignPending;

	public static AccountManager Instance
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

	public bool IsLoginOpen => false;

	public bool IsReportOpen => false;

	public bool IsStatsOpen => false;

	private static void Bootstrap()
	{
	}

	private void Awake()
	{
	}

	private void UpdateRoleLabel()
	{
	}

	private void ResolveLoginUi()
	{
	}

	private void OnLocalClicked()
	{
	}

	private void UpdateLocalLabel()
	{
	}

	public void OpenReport()
	{
	}

	public void CloseReport()
	{
	}

	public void OpenStats()
	{
	}

	public void CloseStats()
	{
	}

	public void OpenLogin()
	{
	}

	public void CloseLogin()
	{
	}

	private IEnumerator CoStartupLogin()
	{
		return null;
	}

	private static string StickyPopupKey(string popup)
	{
		return null;
	}

	private void ApplyOnlineGating()
	{
	}

	private void WireTabHover()
	{
	}

	private static void SetTabHighlight(SpriteRenderer sprite, bool on)
	{
	}

	private void ShowLoginNudgeOnce()
	{
	}

	private void ShowServerPopupIfAny()
	{
	}

	private IEnumerator CoCheckServerPopup()
	{
		return null;
	}

	public void RefreshTab()
	{
	}

	private void OnAccountStateChanged()
	{
	}

	private void SyncStatsWithAccount()
	{
	}

	private void OnStatsChanged()
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private void ApplyBackupLabel(bool loggedIn)
	{
	}

	public void RefreshBackupLabel()
	{
	}

	public static void InitButtonEvents(PassiveButton pb)
	{
	}

	[PreserveSig]
	private static extern int GetUserGeoID(int geoClass);

	[PreserveSig]
	private static extern int GetGeoInfo(int location, int geoType, StringBuilder geoData, int cchData, int langId);

	public static string DetectCountry()
	{
		return null;
	}

	public static Transform FindDeep(Transform root, string name)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void ApplySceneVisibility(string sceneName)
	{
	}

	private void AlignTabToLeftEdge()
	{
	}

	private void _003CCoStartupLogin_003Eb__42_1(bool ok, string _)
	{
	}

	private void _003CLateUpdate_003Eb__64_0(bool ok, string err)
	{
	}
}
