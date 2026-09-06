using UnityEngine;

public class SensorDoor : MonoBehaviour
{
	public SpriteRenderer LeftSide;

	public SpriteRenderer RightSide;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	public float ActivationDistance;

	public bool Opening;

	public float OpenDuration;

	private float openTimer;

	public void OnEnable()
	{
	}

	public void SetUvs()
	{
	}

	private void Update()
	{
	}

	private void CheckDoor()
	{
	}
}
