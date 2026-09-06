using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaffMusicPlayer : MonoBehaviour
{
	private sealed class _003CPlaySequence_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StaffMusicPlayer _003C_003E4__this;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySequence_003Ed__23(int _003C_003E1__state)
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

	private const string MainBgSoundName = "MainBG";

	private const string IgnoredSceneName = "Ranking";

	private static StaffMusicPlayer activeInstance;

	private AudioClip _introClip;

	private AudioClip _loopClip;

	private float _targetVolume;

	private float _fadeInDuration;

	private AudioSource _introSource;

	private AudioSource _loopSource;

	private bool _started;

	private float _currentLogicalVolume;

	private bool _mutedByEasterEgg;

	private bool _mutedByScene;

	public static void StopActive()
	{
	}

	public void Begin(AudioClip introClip, AudioClip loopClip, float volume, float fadeInDuration)
	{
	}

	public void SetMutedByEasterEgg(bool muted)
	{
	}

	private void SyncMutedFromEasterEgg()
	{
	}

	private void ApplyVolume()
	{
	}

	private void SyncSceneMute(string sceneName)
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

	public void Stop()
	{
	}

	private IEnumerator PlaySequence()
	{
		return null;
	}
}
