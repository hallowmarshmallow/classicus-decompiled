using UnityEngine;

public class VirtualJoystick : MonoBehaviour, IVirtualJoystick
{
	public float InnerRadius;

	public float OuterRadius;

	public float JoystickSize;

	public CircleCollider2D Outer;

	public SpriteRenderer Inner;

	public bool IsDragged;

	private Vector2 _003CDelta_003Ek__BackingField;

	private VirtualJoystickController myController;

	private Vector2 _smoothedVector;

	private const float SmoothingSpeed = 20f;

	public Vector2 Delta
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	protected virtual void FixedUpdate()
	{
		throw null;
	}

	private Vector2 WorldToLocal(Vector2 worldPos)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public void SetJSize()
	{
		throw null;
	}

	public virtual void UpdateJoystick(FingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
		throw null;
	}

	public VirtualJoystick()
	{
		throw null;
	}
}
