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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDownloadAndLoop_003Ed__13(int _003C_003E1__state)
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

	private const string VolumePrefKey = "MyMod_LobbyMusicVolume";

	private const float MaxLobbyThemeVolume = 0.8f;

	private static StaffCustomSoundPlayer _instance;

	private AudioSource _source;

	private Coroutine _downloadRoutine;

	private LobbyMusicPlayer _mutedTheme;

	public static void PlayFromUrl(string url)
	{
	}

	public static void StopAll()
	{
	}

	private static void EnsureInstance()
	{
	}

	private void Begin(string url)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private IEnumerator CoDownloadAndLoop(string url)
	{
		return null;
	}

	private void MuteLobbyTheme()
	{
	}

	private void RestoreLobbyTheme()
	{
	}

	private static LobbyMusicPlayer FindLobbyTheme()
	{
		return null;
	}

	private void StopInternal()
	{
	}
}
