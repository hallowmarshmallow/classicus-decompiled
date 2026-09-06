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

		public _003CPlayLobbyMusic_003Ed__19(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private float ClampedVolume()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static float GetPitchForCurrentTime()
	{
		throw null;
	}

	public void SetVolume(float volume)
	{
		throw null;
	}

	public void SetPitch(float pitch)
	{
		throw null;
	}

	private IEnumerator PlayLobbyMusic()
	{
		throw null;
	}

	public LobbyMusicPlayer()
	{
		throw null;
	}
}
