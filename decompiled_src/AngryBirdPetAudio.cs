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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private AudioClip NextIdleClip()
	{
		throw null;
	}

	public static AudioClip NextSharedClip(AudioClip[] clips)
	{
		throw null;
	}

	private void PlaySpatial(AudioClip clip, float baseVolume)
	{
		throw null;
	}

	public static void PlayAt(AudioSource source, AudioClip clip, Vector3 worldPos, float baseVolume, float fullRange, float maxRange)
	{
		throw null;
	}

	private static float DistanceVolume(Vector3 worldPos, float fullRange, float maxRange)
	{
		throw null;
	}

	public static void OnIntroFinished()
	{
		throw null;
	}

	public static void PlayEndGame(bool crewWon)
	{
		throw null;
	}

	public static void BeginMatch()
	{
		throw null;
	}

	public AngryBirdPetAudio()
	{
		throw null;
	}

	static AngryBirdPetAudio()
	{
		throw null;
	}
}
