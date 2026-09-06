using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class InAppUpdater : MonoBehaviour
{
	private static class Libc
	{
		private static int _variant;

		private static int Variant => 0;

		public static bool Available => false;

		[PreserveSig]
		private static extern int access_a(byte[] p, int m);

		[PreserveSig]
		private static extern int access_b(byte[] p, int m);

		[PreserveSig]
		private static extern int access_c(byte[] p, int m);

		[PreserveSig]
		private static extern int chmod_a(byte[] p, uint m);

		[PreserveSig]
		private static extern int chmod_b(byte[] p, uint m);

		[PreserveSig]
		private static extern int chmod_c(byte[] p, uint m);

		[PreserveSig]
		private static extern int system_a(byte[] c);

		[PreserveSig]
		private static extern int system_b(byte[] c);

		[PreserveSig]
		private static extern int system_c(byte[] c);

		[PreserveSig]
		private static extern int statvfs_a(byte[] p, IntPtr b);

		[PreserveSig]
		private static extern int statvfs_b(byte[] p, IntPtr b);

		[PreserveSig]
		private static extern int statvfs_c(byte[] p, IntPtr b);

		public static int Access(string path, int mode)
		{
			return 0;
		}

		public static int Chmod(string path, uint mode)
		{
			return 0;
		}

		public static int System(string command)
		{
			return 0;
		}

		public static int Statvfs(string path, IntPtr buf)
		{
			return 0;
		}
	}

	private sealed class _003CDownloadFile_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public InAppUpdater _003C_003E4__this;

		public string savePath;

		public long expectedSize;

		private string[] _003CcandidateUrls_003E5__2;

		private string _003ClastError_003E5__3;

		private int _003Cattempt_003E5__4;

		private string _003CattemptUrl_003E5__5;

		private UnityWebRequest _003Crequest_003E5__6;

		private UnityWebRequestAsyncOperation _003Coperation_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownloadFile_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CPerformUpdate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppUpdater _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPerformUpdate_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CUpdateDesktop_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppUpdater _003C_003E4__this;

		public string platformName;

		public string extension;

		private string _003CgameDir_003E5__2;

		private string _003CtempDir_003E5__3;

		private string _003CzipPath_003E5__4;

		private string _003CsourceDir_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateDesktop_003Ed__24(int _003C_003E1__state)
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

	private static InAppUpdater _003CInstance_003Ek__BackingField;

	public GameObject updateTextObject;

	public TextMeshPro updateTextTMP;

	public GameObject upgradeButton;

	public GameObject ignoreButton;

	public TextMeshPro popupText;

	private GitHubRelease cachedRelease;

	private bool isUpdating;

	private const int DownloadTimeoutSeconds = 300;

	private const string UpdaterScriptNameWin = "ClassicUs_Updater.bat";

	private const string UpdaterScriptNameLinux = "ClassicUs_Updater.sh";

	private const string InstallNonceKey = "InstallNonce_AUAD";

	private string _currentInstallNonce;

	private int _installCopyPercent;

	private bool _installCopyDone;

	private Exception _installCopyError;

	private static readonly string[][] KnownTerminals;

	private const int X_OK = 1;

	private const int F_OK = 0;

	private static readonly string[] GithubReleaseMirrorPrefixes;

	public static InAppUpdater Instance
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

	public void Awake()
	{
	}

	public void SetRelease(GitHubRelease release)
	{
	}

	public void StartUpdate()
	{
	}

	private void ShowError(string message)
	{
	}

	private IEnumerator PerformUpdate()
	{
		return null;
	}

	private IEnumerator UpdateDesktop(string platformName, string extension)
	{
		return null;
	}

	private static string ResolveStagingDir(string gameDir)
	{
		return null;
	}

	private static long GetFreeSpace(string path)
	{
		return 0L;
	}

	private static void WriteScript(string scriptPath, string script, bool useCrlf)
	{
	}

	private static byte[] Utf8Z(string s)
	{
		return null;
	}

	private static long GetFreeSpaceStatvfs(string path)
	{
		return 0L;
	}

	private static string ShellQuote(string s)
	{
		return null;
	}

	private static bool IsExecutableFile(string fullPath)
	{
		return false;
	}

	private static bool CommandExists(string command)
	{
		return false;
	}

	private static bool RunDetached(string shellCommand, string workingDir)
	{
		return false;
	}

	private bool CreateLinuxUpdaterScript(string sourceDir, string gameDir, string tempDir, out string failReason)
	{
		failReason = null;
		return false;
	}

	private IEnumerator DownloadFile(string url, string savePath, long expectedSize)
	{
		return null;
	}

	private GitHubReleaseAsset FindAsset(string extension)
	{
		return null;
	}

	private GitHubReleaseAsset FindAssetByPlatform(string platformName, string extension)
	{
		return null;
	}

	private void SetUpdateText(string text)
	{
	}

	private void RestoreUI()
	{
	}

	private void SetButtonsVisible(bool visible)
	{
	}

	private static string FormatBytes(long bytes)
	{
		return null;
	}

	private static string Translate(StringNames id, object[] parts)
	{
		return null;
	}
}
