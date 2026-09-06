using PowerTools;
using UnityEngine;

public class LeafMinigame : Minigame
{
	public LeafBehaviour LeafPrefab;

	public Vector2Range ValidArea;

	public SpriteAnim[] Arrows;

	public AnimationClip[] Inactive;

	public AnimationClip[] Active;

	public AnimationClip[] Complete;

	private Collider2D[] Leaves;

	public AudioClip[] LeaveSounds;

	public AudioClip[] SuckSounds;

	private Controller myController;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void LeafDone(LeafBehaviour leaf)
	{
		throw null;
	}

	public LeafMinigame()
	{
		throw null;
	}
}
