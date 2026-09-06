using System.Collections.Generic;
using UnityEngine;

public class AngryBirdPetAudio : MonoBehaviour
{
	private static readonly List<AngryBirdPetAudio> Active;

	private static int _idleCursor;

	private static bool _levelStartPlayed;

	private static bool _endGamePlayed;

	private static AudioClip[] _endVictoryClips;

	private static AudioClip[] _endDefeatClips;

	private static bool _anyoneWoreBirdPet;

	private const string StartClipPrefKey = "AngryBirdPetStartClip";

	private const string VolumePrefKey = "ClassicUs_PetSfxVolume";

	private PetBehaviour _pet;

	private AudioSource _source;

	private float _nextChirp;

	private bool _hadSource;

	public static float PetVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private AudioClip NextIdleClip()
	{
		return null;
	}

	public static AudioClip NextSharedClip(AudioClip[] clips)
	{
		return null;
	}

	private void PlaySpatial(AudioClip clip, float baseVolume)
	{
	}

	public static void PlayAt(AudioSource source, AudioClip clip, Vector3 worldPos, float baseVolume, float fullRange, float maxRange)
	{
	}

	private static float DistanceVolume(Vector3 worldPos, float fullRange, float maxRange)
	{
		return 0f;
	}

	public static void OnIntroFinished()
	{
	}

	public static void PlayEndGame(bool crewWon)
	{
	}

	public static void BeginMatch()
	{
	}
}
