using UnityEngine;

public class DemoKeyboardStick : VirtualJoystick
{
	public SpriteRenderer UpKey;

	public SpriteRenderer DownKey;

	public SpriteRenderer LeftKey;

	public SpriteRenderer RightKey;

	protected override void FixedUpdate()
	{
	}

	public override void UpdateJoystick(FingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}
}
