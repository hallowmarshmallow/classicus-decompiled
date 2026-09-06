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

		public _003C_003Ec__DisplayClass42_0()
		{
			throw null;
		}

		internal void _003CCoStartupLogin_003Eb__0(bool success, string error)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public bool ok;

		public _003C_003Ec__DisplayClass47_0()
		{
			throw null;
		}

		internal void _003CCoCheckServerPopup_003Eb__0(bool success, string error)
		{
			throw null;
		}
	}

	private sealed class _003CCoCheckServerPopup_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		private int _003Cattempt_003E5__2;

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

		public _003CCoCheckServerPopup_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003CCoStartupLogin_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		private int _003CquickAttempts_003E5__2;

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

		public _003CCoStartupLogin_003Ed__42(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool IsLoginOpen
	{
		get
		{
			throw null;
		}
	}

	public bool IsReportOpen
	{
		get
		{
			throw null;
		}
	}

	public bool IsStatsOpen
	{
		get
		{
			throw null;
		}
	}

	private static void Bootstrap()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void UpdateRoleLabel()
	{
		throw null;
	}

	private void ResolveLoginUi()
	{
		throw null;
	}

	private void OnLocalClicked()
	{
		throw null;
	}

	private void UpdateLocalLabel()
	{
		throw null;
	}

	public void OpenReport()
	{
		throw null;
	}

	public void CloseReport()
	{
		throw null;
	}

	public void OpenStats()
	{
		throw null;
	}

	public void CloseStats()
	{
		throw null;
	}

	public void OpenLogin()
	{
		throw null;
	}

	public void CloseLogin()
	{
		throw null;
	}

	private IEnumerator CoStartupLogin()
	{
		throw null;
	}

	private static string StickyPopupKey(string popup)
	{
		throw null;
	}

	private void ShowServerPopupIfAny()
	{
		throw null;
	}

	private IEnumerator CoCheckServerPopup()
	{
		throw null;
	}

	public void RefreshTab()
	{
		throw null;
	}

	private void OnAccountStateChanged()
	{
		throw null;
	}

	private void SyncStatsWithAccount()
	{
		throw null;
	}

	private void OnStatsChanged()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void ApplyBackupLabel(bool loggedIn)
	{
		throw null;
	}

	public void RefreshBackupLabel()
	{
		throw null;
	}

	public static void InitButtonEvents(PassiveButton pb)
	{
		throw null;
	}

	[PreserveSig]
	private static extern int GetUserGeoID(int geoClass);

	[PreserveSig]
	private static extern int GetGeoInfo(int location, int geoType, StringBuilder geoData, int cchData, int langId);

	public static string DetectCountry()
	{
		throw null;
	}

	public static Transform FindDeep(Transform root, string name)
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private void ApplySceneVisibility(string sceneName)
	{
		throw null;
	}

	private void AlignTabToLeftEdge()
	{
		throw null;
	}

	public AccountManager()
	{
		throw null;
	}

	static AccountManager()
	{
		throw null;
	}

	private void _003CCoStartupLogin_003Eb__42_1(bool ok, string _)
	{
		throw null;
	}

	private void _003CLateUpdate_003Eb__56_0(bool ok, string err)
	{
		throw null;
	}
}
