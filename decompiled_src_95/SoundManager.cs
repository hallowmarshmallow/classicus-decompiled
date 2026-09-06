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

		internal bool _003CPlaySound_003Eb__26_0(AudioSource s)
		{
			return false;
		}

		internal bool _003CPlaySound_003Eb__26_1(AudioSource s)
		{
			return false;
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

	public static SoundManager Instance => null;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void RebindMixerGroups()
	{
	}

	private void UpdateVolume()
	{
	}

	public void ChangeSfxVolume(float volume)
	{
	}

	public void ChangeMusicVolume(float volume)
	{
	}

	public void StopSound(AudioClip clip)
	{
	}

	public void StopAllSound()
	{
	}

	public static float GetSoundVolume(Vector2 soundPosition, Vector2 listenerPosition, float falloffStartDistance = 2f, float falloffEndDistance = 6f, float minVolume = 0f)
	{
		return 0f;
	}

	public void PlayDynamicSound(string name, AudioClip clip, bool loop, DynamicSound.GetDynamicsFunction volumeFunc, bool playAsSfx = false)
	{
	}

	public AudioSource GetNamedSfxSource(string name)
	{
		return null;
	}

	public void StopNamedSound(string name)
	{
	}

	public AudioSource CrossFadeSound(string name, AudioClip clip, float maxVolume, float duration = 1.5f, bool instant = false)
	{
		return null;
	}

	public AudioSource PlaySoundImmediate(AudioClip clip, bool loop, float volume = 1f, float pitch = 1f)
	{
		return null;
	}

	public bool SoundIsPlaying(AudioClip clip)
	{
		return false;
	}

	public AudioSource PlaySound(AudioClip clip, bool loop, float volume = 1f, bool forceNewSource = false, bool dropIfBusy = false, float pitch = 1f)
	{
		return null;
	}

	public void StopSoundByName(string name)
	{
	}
}
