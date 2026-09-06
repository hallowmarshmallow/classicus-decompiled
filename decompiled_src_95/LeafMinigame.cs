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
	}

	public void FixedUpdate()
	{
	}

	public void LeafDone(LeafBehaviour leaf)
	{
	}
}
