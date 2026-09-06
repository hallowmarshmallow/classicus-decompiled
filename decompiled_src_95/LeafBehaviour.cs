using UnityEngine;

public class LeafBehaviour : MonoBehaviour
{
	public Sprite[] Images;

	public FloatRange SpinSpeed;

	public Vector2Range StartVel;

	public float AccelRate;

	public LeafMinigame Parent;

	public bool Held;

	private static RandomFill<Sprite> ImageFiller;

	public Rigidbody2D body;

	public void Start()
	{
	}

	public void FixedUpdate()
	{
	}
}
