using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
	public enum MixerTypes
	{
		SFX,
		Music
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AudioSource> _003C_003E9__26_0;

		public static Predicate<AudioSource> _003C_003E9__26_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CPlaySound_003Eb__26_0(AudioSource s)
		{
			throw null;
		}

		internal bool _003CPlaySound_003Eb__26_1(AudioSource s)
		{
			throw null;
		}
	}

	private static SoundManager _Instance;

	public AudioMixerGroup musicMixer;

	public AudioMixerGroup sfxMixer;

	public static float MusicVolume;

	public static float SfxVolume;

	private Dictionary<AudioClip, List<AudioSource>> allSources;

	private List<ISoundPlayer> soundPlayers;

	private Dictionary<string, AudioSource> namedSfxSources;

	private const int MaxPooledSourcesPerClip = 4;

	public static SoundManager Instance
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void RebindMixerGroups()
	{
		throw null;
	}

	private void UpdateVolume()
	{
		throw null;
	}

	public void ChangeSfxVolume(float volume)
	{
		throw null;
	}

	public void ChangeMusicVolume(float volume)
	{
		throw null;
	}

	public void StopSound(AudioClip clip)
	{
		throw null;
	}

	public void StopAllSound()
	{
		throw null;
	}

	public static float GetSoundVolume(Vector2 soundPosition, Vector2 listenerPosition, float falloffStartDistance = 2f, float falloffEndDistance = 6f, float minVolume = 0f)
	{
		throw null;
	}

	public void PlayDynamicSound(string name, AudioClip clip, bool loop, DynamicSound.GetDynamicsFunction volumeFunc, bool playAsSfx = false)
	{
		throw null;
	}

	public AudioSource GetNamedSfxSource(string name)
	{
		throw null;
	}

	public void StopNamedSound(string name)
	{
		throw null;
	}

	public AudioSource CrossFadeSound(string name, AudioClip clip, float maxVolume, float duration = 1.5f, bool instant = false)
	{
		throw null;
	}

	public AudioSource PlaySoundImmediate(AudioClip clip, bool loop, float volume = 1f, float pitch = 1f)
	{
		throw null;
	}

	public bool SoundIsPlaying(AudioClip clip)
	{
		throw null;
	}

	public AudioSource PlaySound(AudioClip clip, bool loop, float volume = 1f, bool forceNewSource = false, bool dropIfBusy = false, float pitch = 1f)
	{
		throw null;
	}

	public void StopSoundByName(string name)
	{
		throw null;
	}

	public SoundManager()
	{
		throw null;
	}

	static SoundManager()
	{
		throw null;
	}
}
