using UnityEngine;

public class ScreenJoystick : MonoBehaviour, IVirtualJoystick
{
	private Collider2D[] hitBuffer;

	private Controller myController;

	private int touchId;

	private Vector2 _003CDelta_003Ek__BackingField;

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

	private void FixedUpdate()
	{
	}
}
