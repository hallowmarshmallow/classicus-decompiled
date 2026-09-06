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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCaptureAndLoop_003Ed__23(int _003C_003E1__state)
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
			return _003COverrideClip_003Ek__BackingField;
		}
		private set
		{
			_003COverrideClip_003Ek__BackingField = value;
		}
	}

	public static string OverrideName
	{
		get
		{
			return _003COverrideName_003Ek__BackingField;
		}
		private set
		{
			_003COverrideName_003Ek__BackingField = value;
		}
	}

	public static void SetOverride(string soundName, AudioClip clip)
	{
	}

	public static void ClearOverride()
	{
	}

	public static void ResetLoopState()
	{
	}

	public void Awake()
	{
	}

	private IEnumerator CaptureAndLoop(AudioClip targetClip, AudioSource source)
	{
		return null;
	}
}
