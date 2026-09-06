using UnityEngine;

public class SweepMinigame : Minigame
{
	public SpriteRenderer[] Spinners;

	public SpriteRenderer[] Shadows;

	public SpriteRenderer[] Lights;

	public HorizontalGauge[] Gauges;

	private int spinnerIdx;

	private float timer;

	public float SpinRate;

	private float initialTimer;

	public AudioClip SpinningSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private float CalcXPerc()
	{
		throw null;
	}

	public void HitButton(int i)
	{
		throw null;
	}

	private void ResetGauges()
	{
		throw null;
	}

	public SweepMinigame()
	{
		throw null;
	}
}
