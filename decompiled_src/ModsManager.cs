using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ModsManager : DestroyableSingleton<ModsManager>
{
	private sealed class _003CLoadLogo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModInfo mod;

		private string _003CcachePath_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

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

		public _003CLoadLogo_003Ed__5(int _003C_003E1__state)
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

	private const long MinCacheFreeBytes = 16777216L;

	private static readonly TimeSpan LogoCacheLifetime;

	public readonly Dictionary<string, ModInfo> allMods;

	public override void Awake()
	{
		throw null;
	}

	public void RefreshInstalledMods(bool reloadLuaMods = true)
	{
		throw null;
	}

	public IEnumerator LoadLogo(ModInfo mod)
	{
		throw null;
	}

	private static bool TryLoadCachedLogo(string cachePath, out Sprite sprite)
	{
		throw null;
	}

	private static bool TryCreateSprite(byte[] data, out Sprite sprite)
	{
		throw null;
	}

	private static string GetLogoCachePath(ModInfo mod)
	{
		throw null;
	}

	private static string Hash(string value)
	{
		throw null;
	}

	private static bool CanUseLogoCache()
	{
		throw null;
	}

	public ModsManager()
	{
		throw null;
	}

	static ModsManager()
	{
		throw null;
	}
}
