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
	}

	private void Init(PetBehaviour pet, List<Transform> found)
	{
	}

	private static SpriteRenderer FindShadow(Transform mini)
	{
		return null;
	}

	private static void EnsureClipsLoaded()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void Sample()
	{
	}

	private void Rebase()
	{
	}

	private void ResetTrail()
	{
	}

	private Vector2 BackDirection()
	{
		return default(Vector2);
	}

	private void Apply(bool mourning)
	{
	}

	private void Chirp(Mini m, bool mourning)
	{
	}

	private void PlayMini(Mini m, AudioClip clip, float volume)
	{
	}

	private void PlaySelectOnce()
	{
	}

	private void Animate(Mini m, bool mourning, bool moving)
	{
	}

	public void SetVisible(bool value)
	{
	}
}
