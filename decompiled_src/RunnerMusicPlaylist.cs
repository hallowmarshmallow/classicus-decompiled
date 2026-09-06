using System.Collections.Generic;
using UnityEngine;

public class RunnerMusicPlaylist : ScriptableObject
{
	private List<AudioClip> tracks;

	private AudioClip russianFirstTrack;

	private bool shuffle;

	private AudioClip ultimateTrack;

	public AudioClip UltimateTrack
	{
		get
		{
			throw null;
		}
	}

	public int Count
	{
		get
		{
			throw null;
		}
	}

	public bool Shuffle
	{
		get
		{
			throw null;
		}
	}

	public AudioClip RussianFirstTrack
	{
		get
		{
			throw null;
		}
	}

	public AudioClip Get(int index)
	{
		throw null;
	}

	public bool HasAnyTrack()
	{
		throw null;
	}

	public RunnerMusicPlaylist()
	{
		throw null;
	}
}
