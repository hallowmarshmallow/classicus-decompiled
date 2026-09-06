using UnityEngine;
using UnityEngine.Audio;

namespace KlassicHideNSeek;

internal sealed class HnSMusicManager
{
	private AudioSource normalSource;

	private AudioSource taskSource;

	private AudioSource dangerLevel1Source;

	private AudioSource dangerLevel2Source;

	private AudioSource seekerSource;

	private float normalVolume;

	private float taskVolume;

	private float dangerLevel1Volume;

	private float dangerLevel2Volume;

	private float musicLerpSpeed;

	private float lastMusicSyncTime;

	private bool isDoingTask;

	private bool initialized;

	private bool seekerMusicStarted;

	private bool crewmatePlaybackStarted;

	private HnSThemeSettings themeSettings;

	internal HnSMusicManager(HnSThemeSettings settings)
	{
	}

	internal void InitMusic()
	{
	}

	internal void BeginPlayback()
	{
	}

	internal void StartSeekerMusic()
	{
	}

	private static AudioMixerGroup MusicMixerGroup()
	{
		return null;
	}

	internal void SetTaskState(bool doingTask)
	{
	}

	internal void SetMusicCrossfadeSpeed(float speed)
	{
	}

	internal void SetMusicValues(float dangerLevel1, float dangerLevel2)
	{
	}

	internal void ResetMusic()
	{
	}

	internal void MuteAll()
	{
	}

	internal void FixedUpdate()
	{
	}

	internal void StopAll()
	{
	}

	private void SyncMusic()
	{
	}

	private static AudioSource GetOrCreateSource(string name)
	{
		return null;
	}

	private static void StopAndDestroy(ref AudioSource source, string name)
	{
	}
}
