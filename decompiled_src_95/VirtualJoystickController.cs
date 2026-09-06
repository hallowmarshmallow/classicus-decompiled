using UnityEngine;

public class VirtualJoystickController
{
	private Camera _003CmainCam_003Ek__BackingField;

	private const float ReleaseHysteresis = 0.15f;

	private Collider2D amTouching;

	private int fingerId;

	private Controller.TouchState MyTouch;

	public Vector2 DragPosition => default(Vector2);

	public Camera mainCam
	{
		get
		{
			return _003CmainCam_003Ek__BackingField;
		}
		set
		{
			_003CmainCam_003Ek__BackingField = value;
		}
	}

	public void Update()
	{
	}

	public DragState CheckDrag(Collider2D coll, Collider2D deadZone = null)
	{
		return default(DragState);
	}
}
