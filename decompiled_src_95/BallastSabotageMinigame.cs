using UnityEngine;

public class BallastSabotageMinigame : Minigame
{
	private const float MIN_VALUE = -2.65f;

	private const float MAX_VALUE = 0f;

	private const float STEP = 0.01f;

	public SpriteRenderer gauge;

	public bool isDefaultIncreasing;

	private float _elapsed;

	private float _gaugeValue;

	private bool _inRange;

	private ReactorSystemType _reactor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetToValue(float value)
	{
	}

	public void IncreaseLevel()
	{
	}

	public void DecreaseLevel()
	{
	}

	private void UpdateGaugeDisplay()
	{
	}

	public override void Close()
	{
	}
}
