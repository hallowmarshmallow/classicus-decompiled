using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStarter : MonoBehaviour
{
	private sealed class _003CCaptureAndLoop_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public AudioClip targetClip;

		public SoundStarter _003C_003E4__this;

		private float _003CclipLen_003E5__2;

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

		public _003CCaptureAndLoop_003Ed__23(int _003C_003E1__state)
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

	public string Name;

	public AudioClip SoundToPlay;

	public bool StopAll;

	public bool Looped;

	public float LoopStartTime;

	public float Volume;

	public bool InstantPlay;

	public float FadeDuration;

	private static bool alreadyLooping;

	private static AudioClip currentClip;

	private static AudioSource cachedSource;

	private static AudioClip _003COverrideClip_003Ek__BackingField;

	private static string _003COverrideName_003Ek__BackingField;

	public static AudioClip OverrideClip
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

	public static string OverrideName
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

	public static void SetOverride(string soundName, AudioClip clip)
	{
		throw null;
	}

	public static void ClearOverride()
	{
		throw null;
	}

	public static void ResetLoopState()
	{
		throw null;
	}

	public void Awake()
	{
		throw null;
	}

	private IEnumerator CaptureAndLoop(AudioClip targetClip, AudioSource source)
	{
		throw null;
	}

	public SoundStarter()
	{
		throw null;
	}
}
