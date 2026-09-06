using System;
using PowerTools;
using UnityEngine;

public class PetBehaviour : MonoBehaviour, IBuyable, ISteamBuyable
{
	private const float SnapDistance = 2f;

	public bool Free;

	public string ProductId;

	public string StoreName;

	public uint SteamId;

	public int ItchId;

	public string ItchUrl;

	public PlayerControl Source;

	public const float MinDistance = 0.2f;

	public const float damping = 0.7f;

	public const float Easing = 0.2f;

	public const float Speed = 5f;

	public float YOffset;

	public SpriteAnim animator;

	public SpriteRenderer rend;

	public SpriteRenderer shadowRend;

	public Rigidbody2D body;

	public Collider2D Collider;

	public AnimationClip idleClip;

	public AnimationClip sadClip;

	public AnimationClip scaredClip;

	public AnimationClip walkClip;

	public bool BirdSoundsEnabled;

	public AudioClip[] BirdIdleClips;

	public AnimationClip BirdTalkClip;

	public bool BirdTalkDuringWalk;

	public AudioClip[] BirdLevelStartClips;

	public AudioClip[] BirdVictoryClips;

	public AudioClip[] BirdDefeatClips;

	public float BirdIdleInterval;

	public float BirdFullVolumeRange;

	public float BirdMaxHearingRange;

	public float BirdVolume;

	[NonSerialized]
	public AngryBirdMiniFlock MiniFlock;

	private float birdTalkUntil;

	public string ProdId
	{
		get
		{
			throw null;
		}
	}

	public string SteamPrice
	{
		get
		{
			throw null;
		}
	}

	public uint SteamAppId
	{
		get
		{
			throw null;
		}
	}

	public bool Visible
	{
		set
		{
			throw null;
		}
	}

	public void BeginBirdTalk(float seconds)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private Vector2 GetTruePosition()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	public void SetMourning()
	{
		throw null;
	}

	public PetBehaviour()
	{
		throw null;
	}
}
