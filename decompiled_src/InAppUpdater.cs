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

		private static int Variant
		{
			get
			{
				throw null;
			}
		}

		public static bool Available
		{
			get
			{
				throw null;
			}
		}

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
			throw null;
		}

		public static int Chmod(string path, uint mode)
		{
			throw null;
		}

		public static int System(string command)
		{
			throw null;
		}

		public static int Statvfs(string path, IntPtr buf)
		{
			throw null;
		}

		static Libc()
		{
			throw null;
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

		public _003CDownloadFile_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003CPerformUpdate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppUpdater _003C_003E4__this;

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

		public _003CPerformUpdate_003Ed__23(int _003C_003E1__state)
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

		public _003CUpdateDesktop_003Ed__24(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public void Awake()
	{
		throw null;
	}

	public void SetRelease(GitHubRelease release)
	{
		throw null;
	}

	public void StartUpdate()
	{
		throw null;
	}

	private void ShowError(string message)
	{
		throw null;
	}

	private IEnumerator PerformUpdate()
	{
		throw null;
	}

	private IEnumerator UpdateDesktop(string platformName, string extension)
	{
		throw null;
	}

	private static string ResolveStagingDir(string gameDir)
	{
		throw null;
	}

	private static long GetFreeSpace(string path)
	{
		throw null;
	}

	private static void WriteScript(string scriptPath, string script, bool useCrlf)
	{
		throw null;
	}

	private static byte[] Utf8Z(string s)
	{
		throw null;
	}

	private static long GetFreeSpaceStatvfs(string path)
	{
		throw null;
	}

	private static string ShellQuote(string s)
	{
		throw null;
	}

	private static bool IsExecutableFile(string fullPath)
	{
		throw null;
	}

	private static bool CommandExists(string command)
	{
		throw null;
	}

	private static bool RunDetached(string shellCommand, string workingDir)
	{
		throw null;
	}

	private bool CreateLinuxUpdaterScript(string sourceDir, string gameDir, string tempDir, out string failReason)
	{
		throw null;
	}

	private IEnumerator DownloadFile(string url, string savePath, long expectedSize)
	{
		throw null;
	}

	private GitHubReleaseAsset FindAsset(string extension)
	{
		throw null;
	}

	private GitHubReleaseAsset FindAssetByPlatform(string platformName, string extension)
	{
		throw null;
	}

	private void SetUpdateText(string text)
	{
		throw null;
	}

	private void RestoreUI()
	{
		throw null;
	}

	private void SetButtonsVisible(bool visible)
	{
		throw null;
	}

	private static string FormatBytes(long bytes)
	{
		throw null;
	}

	private static string Translate(StringNames id, object[] parts)
	{
		throw null;
	}

	public InAppUpdater()
	{
		throw null;
	}

	static InAppUpdater()
	{
		throw null;
	}
}
