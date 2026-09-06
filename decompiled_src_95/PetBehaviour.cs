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

	public string ProdId => null;

	public string SteamPrice => null;

	public uint SteamAppId => 0u;

	public bool Visible
	{
		set
		{
		}
	}

	public void BeginBirdTalk(float seconds)
	{
	}

	private void Start()
	{
	}

	private Vector2 GetTruePosition()
	{
		return default(Vector2);
	}

	public void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetMourning()
	{
	}
}
