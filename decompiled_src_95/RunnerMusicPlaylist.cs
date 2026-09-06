using System.Collections.Generic;
using UnityEngine;

public class RunnerMusicPlaylist : ScriptableObject
{
	private List<AudioClip> tracks;

	private AudioClip russianFirstTrack;

	private bool shuffle;

	private AudioClip ultimateTrack;

	public AudioClip UltimateTrack => null;

	public int Count => 0;

	public bool Shuffle => false;

	public AudioClip RussianFirstTrack => null;

	public AudioClip Get(int index)
	{
		return null;
	}

	public bool HasAnyTrack()
	{
		return false;
	}
}
