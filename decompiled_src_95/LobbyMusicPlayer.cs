using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMusicPlayer : MonoBehaviour
{
	private sealed class _003CPlayLobbyMusic_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyMusicPlayer _003C_003E4__this;

		private float _003CsavedVolume_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayLobbyMusic_003Ed__19(int _003C_003E1__state)
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

	public AudioClip introClip;

	public AudioClip loopClip;

	public float fadeInDuration;

	private AudioSource introSource;

	private AudioSource loopSource;

	private AudioSource _003CActiveSource_003Ek__BackingField;

	private bool suppressedByCustomMusic;

	private double scheduledLoopStart;

	private bool loopScheduledNotStarted;

	public AudioSource ActiveSource
	{
		get
		{
			return _003CActiveSource_003Ek__BackingField;
		}
		private set
		{
			_003CActiveSource_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private float ClampedVolume()
	{
		return 0f;
	}

	private void Update()
	{
	}

	private static float GetPitchForCurrentTime()
	{
		return 0f;
	}

	public void SetVolume(float volume)
	{
	}

	public void SetPitch(float pitch)
	{
	}

	private IEnumerator PlayLobbyMusic()
	{
		return null;
	}
}
