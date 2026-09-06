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
			return _003CDelta_003Ek__BackingField;
		}
		private set
		{
			_003CDelta_003Ek__BackingField = value;
		}
	}

	protected virtual void FixedUpdate()
	{
	}

	private Vector2 WorldToLocal(Vector2 worldPos)
	{
		return default(Vector2);
	}

	private void Start()
	{
	}

	public void SetJSize()
	{
	}

	public virtual void UpdateJoystick(FingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}
}
