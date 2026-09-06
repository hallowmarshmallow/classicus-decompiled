using UnityEngine;

public class SwitchMinigame : Minigame
{
	public Color OnColor;

	public Color OffColor;

	private ShipStatus ship;

	public SpriteRenderer[] switches;

	public SpriteRenderer[] lights;

	public RadioWaveBehaviour top;

	public HorizontalGauge middle;

	public FlatWaveBehaviour bottom;

	public AudioClip FlipSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void FlipSwitch(int switchIdx)
	{
		throw null;
	}

	public SwitchMinigame()
	{
		throw null;
	}
}
