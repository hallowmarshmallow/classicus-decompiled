using UnityEngine;

public class WaterStage : Minigame
{
	public float RefuelDuration;

	public SpriteRenderer waterButton;

	public Sprite buttonDownSprite;

	public Sprite buttonUpSprite;

	public VerticalGauge srcGauge;

	public VerticalGauge destGauge;

	public AudioClip RefuelSound;

	private float timer;

	private bool isDown;

	private bool complete;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void Refuel()
	{
		throw null;
	}

	private void GetRefuelDynamics(AudioSource player, float dt)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public WaterStage()
	{
		throw null;
	}
}
