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
		throw null;
	}

	internal void InitMusic()
	{
		throw null;
	}

	internal void BeginPlayback()
	{
		throw null;
	}

	internal void StartSeekerMusic()
	{
		throw null;
	}

	private static AudioMixerGroup MusicMixerGroup()
	{
		throw null;
	}

	internal void SetTaskState(bool doingTask)
	{
		throw null;
	}

	internal void SetMusicCrossfadeSpeed(float speed)
	{
		throw null;
	}

	internal void SetMusicValues(float dangerLevel1, float dangerLevel2)
	{
		throw null;
	}

	internal void ResetMusic()
	{
		throw null;
	}

	internal void MuteAll()
	{
		throw null;
	}

	internal void FixedUpdate()
	{
		throw null;
	}

	internal void StopAll()
	{
		throw null;
	}

	private void SyncMusic()
	{
		throw null;
	}

	private static AudioSource GetOrCreateSource(string name)
	{
		throw null;
	}

	private static void StopAndDestroy(ref AudioSource source, string name)
	{
		throw null;
	}
}
