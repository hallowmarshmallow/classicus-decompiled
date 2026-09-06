using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public sealed class StaffCustomSoundPlayer : MonoBehaviour
{
	private sealed class _003CCoDownloadAndLoop_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public StaffCustomSoundPlayer _003C_003E4__this;

		private UnityWebRequest _003Creq_003E5__2;

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

		public _003CCoDownloadAndLoop_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private const string VolumePrefKey = "MyMod_LobbyMusicVolume";

	private const float MaxLobbyThemeVolume = 0.8f;

	private static StaffCustomSoundPlayer _instance;

	private AudioSource _source;

	private Coroutine _downloadRoutine;

	private LobbyMusicPlayer _mutedTheme;

	public static void PlayFromUrl(string url)
	{
		throw null;
	}

	public static void StopAll()
	{
		throw null;
	}

	private static void EnsureInstance()
	{
		throw null;
	}

	private void Begin(string url)
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private IEnumerator CoDownloadAndLoop(string url)
	{
		throw null;
	}

	private void MuteLobbyTheme()
	{
		throw null;
	}

	private void RestoreLobbyTheme()
	{
		throw null;
	}

	private static LobbyMusicPlayer FindLobbyTheme()
	{
		throw null;
	}

	private void StopInternal()
	{
		throw null;
	}

	public StaffCustomSoundPlayer()
	{
		throw null;
	}
}
