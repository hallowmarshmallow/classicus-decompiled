using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public static class AccountService
{
	[Serializable]
	public class AccountInfo
	{
		public string id;

		public bool hasBackup;

		public bool tempPass;

		public string email;

		public bool hideCountry;

		public bool banned;

		public string stats;

		public string role;

		public bool needsLogin;
	}

	[Serializable]
	public class RankInfo
	{
		public bool ok;

		public string error;

		public long score;

		public int global;

		public int local;

		public string country;

		public bool hideCountry;

		public bool lbBanned;

		public bool lbBanPermanent;

		public bool weekend;

		public long runnerBestMs;

		public int runnerGlobal;

		public int runnerLocal;
	}

	[Serializable]
	public class LeaderboardEntry
	{
		public int rank;

		public string name;

		public long score;

		public string country;

		public float bestSeconds;

		public string id;
	}

	[Serializable]
	public class ProfilePage
	{
		public bool ok;

		public string name;

		public long score;

		public float bestSeconds;

		public long games;

		public long wins;

		public long tasks;

		public int views;

		public int likes;

		public string stats;

		public long hnsHiderWins;

		public long hnsSeekerWins;

		public long runnerSeconds;

		public long runnerDeaths;

		public long runnerRevives;

		public long runnerFreezes;

		public long runnerSpeeds;

		public long runnerShields;

		public long matchStreakBest;
	}

	[Serializable]
	public class ProfileLikeResult
	{
		public bool ok;

		public int likes;

		public bool likedByMe;
	}

	[Serializable]
	public class LeaderboardPage
	{
		public bool ok;

		public int pages;

		public int page;

		public bool weekend;

		public LeaderboardEntry[] entries;
	}

	[Serializable]
	private class ResponseModel
	{
		public bool ok;

		public string error;

		public AccountInfo account;

		public string serverPopup;

		public bool serverPopupSticky;

		public string token;
	}

	[Serializable]
	private class RequestModel
	{
		public string device;

		public string name;

		public string email;

		public string pass;

		public string country;

		public bool hide;

		public string text;

		public int lang;

		public string token;
	}

	private sealed class _003CCoFetchLeaderboard_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int page;

		public bool local;

		public bool runner;

		public Action<LeaderboardPage> done;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFetchLeaderboard_003Ed__50(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoFetchProfile_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string profileId;

		public Action<ProfilePage> done;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFetchProfile_003Ed__51(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoFetchRank_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<RankInfo> done;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFetchRank_003Ed__47(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoPost_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RequestModel body;

		public string path;

		public Action<bool, string> done;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPost_003Ed__53(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoToggleProfileLike_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string profileId;

		public Action<ProfileLikeResult> done;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoToggleProfileLike_003Ed__52(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static string _sessionUrlOverride;

	private static bool _003CConnected_003Ek__BackingField;

	private static AccountInfo _003CAccount_003Ek__BackingField;

	private static Action m_StateChanged;

	public static string LastServerPopup;

	public static bool LastServerPopupSticky;

	public static bool IsLocalOverride => false;

	public static bool Connected
	{
		get
		{
			return _003CConnected_003Ek__BackingField;
		}
		private set
		{
			_003CConnected_003Ek__BackingField = value;
		}
	}

	public static AccountInfo Account
	{
		get
		{
			return _003CAccount_003Ek__BackingField;
		}
		private set
		{
			_003CAccount_003Ek__BackingField = value;
		}
	}

	public static string SessionToken
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string BaseUrl => null;

	public static event Action StateChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	private static void ResetSessionOverride()
	{
	}

	public static bool ToggleLocalOverride()
	{
		return false;
	}

	private static void ResetConnection()
	{
	}

	public static IEnumerator CoAutoLogin(Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoRegister(string email, string pass, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoLogin(string email, string pass, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoForgotPassword(string email, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoLogout(Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoChangePassword(string pass, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoSetCountry(string country, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoSetHideCountry(bool hide, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoRankReport(string text, Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoUploadStats(Action<bool, string> done)
	{
		return null;
	}

	public static IEnumerator CoFetchRank(Action<RankInfo> done)
	{
		return null;
	}

	public static IEnumerator CoFetchLeaderboard(int page, bool local, bool runner, Action<LeaderboardPage> done)
	{
		return null;
	}

	public static IEnumerator CoFetchProfile(string profileId, Action<ProfilePage> done)
	{
		return null;
	}

	public static IEnumerator CoToggleProfileLike(string profileId, Action<ProfileLikeResult> done)
	{
		return null;
	}

	private static IEnumerator CoPost(string path, RequestModel body, Action<bool, string> done)
	{
		return null;
	}
}
