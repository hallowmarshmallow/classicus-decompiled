using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class AngryBirdMiniFlock : MonoBehaviour
{
	private class Mini
	{
		public Transform tf;

		public SpriteRenderer rend;

		public SpriteRenderer shadowRend;

		public SpriteAnim anim;

		public AudioSource source;

		public float nextChirp;

		public float talkUntil;

		public Vector2 lastPos;

		public Mini()
		{
			throw null;
		}
	}

	private const int MiniCount = 2;

	private const int TrailSamples = 64;

	private const int TrailMask = 63;

	private const float Spacing = 0.15f;

	private const float SampleEpsilonSqr = 0.0004f;

	private const float TeleportSqr = 2f;

	private const float MiniZBase = 1f;

	private const float MiniZStep = 0.1f;

	private const float ChirpGap = 7f;

	private const float MiniVolumeScale = 0.6f;

	private const float TravelRebaseAt = 10000f;

	private static readonly string[] ChirpResourcePaths;

	private const string SelectResourcePath = "Blue SFX/cha_blues_select_vo";

	private static AudioClip[] _chirpClips;

	private static AudioClip _selectClip;

	private static bool _clipsLoaded;

	private PetBehaviour _pet;

	private Mini[] _minis;

	private Vector2[] _pos;

	private float[] _dist;

	private int _head;

	private int _count;

	private float _travelled;

	private bool _hadSource;

	private bool _selectPlayed;

	public static void TryAttach(PetBehaviour pet)
	{
		throw null;
	}

	private void Init(PetBehaviour pet, List<Transform> found)
	{
		throw null;
	}

	private static SpriteRenderer FindShadow(Transform mini)
	{
		throw null;
	}

	private static void EnsureClipsLoaded()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void Sample()
	{
		throw null;
	}

	private void Rebase()
	{
		throw null;
	}

	private void ResetTrail()
	{
		throw null;
	}

	private Vector2 BackDirection()
	{
		throw null;
	}

	private void Apply(bool mourning)
	{
		throw null;
	}

	private void Chirp(Mini m, bool mourning)
	{
		throw null;
	}

	private void PlayMini(Mini m, AudioClip clip, float volume)
	{
		throw null;
	}

	private void PlaySelectOnce()
	{
		throw null;
	}

	private void Animate(Mini m, bool mourning, bool moving)
	{
		throw null;
	}

	public void SetVisible(bool value)
	{
		throw null;
	}

	public AngryBirdMiniFlock()
	{
		throw null;
	}

	static AngryBirdMiniFlock()
	{
		throw null;
	}
}
