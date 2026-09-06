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

		public _003CPlaySequence_003Ed__23(int _003C_003E1__state)
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
		throw null;
	}

	public void Begin(AudioClip introClip, AudioClip loopClip, float volume, float fadeInDuration)
	{
		throw null;
	}

	public void SetMutedByEasterEgg(bool muted)
	{
		throw null;
	}

	private void SyncMutedFromEasterEgg()
	{
		throw null;
	}

	private void ApplyVolume()
	{
		throw null;
	}

	private void SyncSceneMute(string sceneName)
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

	public void Stop()
	{
		throw null;
	}

	private IEnumerator PlaySequence()
	{
		throw null;
	}

	public StaffMusicPlayer()
	{
		throw null;
	}
}
