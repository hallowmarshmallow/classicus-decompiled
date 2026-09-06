using UnityEngine;

public class SpriteSpinController : MonoBehaviour
{
	public SpriteRenderer targetSprite;

	public float spinDuration;

	public float spinSpeed;

	private float elapsedTime;

	private bool isSpinning;

	private void Update()
	{
	}

	public void StartSpin(float? duration = null, float? speed = null)
	{
	}

	public void StopSpin()
	{
	}
}
