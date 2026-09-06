using UnityEngine;

public class CreditsAutoScroll : MonoBehaviour
{
	public RectTransform creditsTransform;

	public float speed;

	public float stoppingPoint;

	public float initialDelay;

	public GameObject endText;

	public Collider2D hitBox;

	public float dragSpeed;

	public float wheelSpeed;

	public float resumeDelayAfterDrag;

	private Vector2 startPos;

	private float delayTimer;

	private bool finished;

	private bool dragging;

	private float lastDragWorldY;

	private float resumeTimer;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void ResetCredits()
	{
	}

	private void Update()
	{
	}

	private void MoveTo(float newY)
	{
	}

	private Vector3 PointerWorld()
	{
		return default(Vector3);
	}

	private bool PointerOverArea(Vector3 world)
	{
		return false;
	}

	private void HandleWheel()
	{
	}

	private void HandleDrag()
	{
	}

	private void UpdateEndState()
	{
	}
}
