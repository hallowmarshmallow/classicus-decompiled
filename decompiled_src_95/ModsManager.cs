using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ModsManager : DestroyableSingleton<ModsManager>
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string name;

		internal bool _003CFind_003Eb__0(ModInfo m)
		{
			return false;
		}
	}

	private sealed class _003CInstall_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModInfo mod;

		public Action<string> failed;

		public ModsManager _003C_003E4__this;

		public Action<float> progress;

		private string _003Ctarget_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private UnityWebRequestAsyncOperation _003Coperation_003E5__4;

		private float _003CstalledSince_003E5__5;

		private ulong _003ClastBytes_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInstall_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CLoadLogo_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModInfo mod;

		private string _003CcachePath_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadLogo_003Ed__19(int _003C_003E1__state)
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

	private const long MinCacheFreeBytes = 16777216L;

	private const string PackageFile = "mod.json";

	private const float DownloadStallSeconds = 15f;

	private static readonly TimeSpan LogoCacheLifetime;

	private static Action m_Changed;

	private readonly List<ModInfo> installed;

	public IReadOnlyList<ModInfo> Installed => null;

	public string Folder => null;

	public static event Action Changed
	{
		add
		{
		}
		remove
		{
		}
	}

	public override void Awake()
	{
	}

	public void Refresh()
	{
	}

	public ModInfo Find(string name)
	{
		return null;
	}

	public bool IsInstalled(string name)
	{
		return false;
	}

	public bool IsInsideFolder(string path)
	{
		return false;
	}

	public IEnumerator Install(ModInfo mod, Action<float> progress, Action<string> failed)
	{
		return null;
	}

	public bool Uninstall(string path, out string error)
	{
		error = null;
		return false;
	}

	public IEnumerator LoadLogo(ModInfo mod)
	{
		return null;
	}

	private static ModInfo ReadPackage(string path)
	{
		return null;
	}

	private static void DeleteQuiet(string path)
	{
	}

	private static bool TryLoadCachedLogo(string cachePath, out Sprite sprite)
	{
		sprite = null;
		return false;
	}

	private static bool TryCreateSprite(byte[] data, out Sprite sprite)
	{
		sprite = null;
		return false;
	}

	private static string GetLogoCachePath(ModInfo mod)
	{
		return null;
	}

	private static string Hash(string value)
	{
		return null;
	}

	private static bool CanUseLogoCache()
	{
		return false;
	}
}
