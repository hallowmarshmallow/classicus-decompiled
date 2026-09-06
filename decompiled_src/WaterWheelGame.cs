using UnityEngine;

public class WaterWheelGame : Minigame
{
	public SpriteRenderer Wheel;

	public VerticalSpriteGauge WaterLevel;

	public SpriteRenderer Watertop;

	public int WheelScale;

	public AudioClip FillStart;

	public AudioClip FillLoop;

	public AudioClip WheelTurn;

	private TouchpadBehavior touchpad;

	private float Rate;

	private AudioSource fillSound;

	private Vector2 prevStickInput;

	private bool hadPrev;

	private bool grabbed;

	private float Water
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

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void Grab()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public WaterWheelGame()
	{
		throw null;
	}
}
