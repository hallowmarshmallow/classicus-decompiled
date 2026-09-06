using UnityEngine;

public class Controller
{
	public class TouchState
	{
		public Vector2 ScreenDownAt;

		public Vector2 ScreenPosition;

		public Vector2 DownAt;

		public Vector2 Position;

		public bool WasDown;

		public bool IsDown;

		public bool TouchStart;

		public bool TouchEnd;

		public DragState dragState;

		public bool active;

		public int FingerId;
	}

	public enum TouchType
	{
		Joystick,
		Mouse,
		Touch
	}

	public readonly TouchState[] Touches;

	private Collider2D amTouching;

	private int touchId;

	private Camera _003CmainCam_003Ek__BackingField;

	public static TouchType currentTouchType => default(TouchType);

	public bool AnyTouch => false;

	public bool AnyTouchDown => false;

	public bool AnyTouchUp => false;

	public Vector2 DragPosition => default(Vector2);

	public Vector2 DragStartPosition => default(Vector2);

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

	public bool CheckHover(Collider2D coll)
	{
		return false;
	}

	public DragState CheckDrag(Collider2D coll)
	{
		return default(DragState);
	}

	public void ResetDragPosition()
	{
	}

	public void ClearTouch()
	{
	}

	public void Update()
	{
	}

	public void Reset()
	{
	}

	public TouchState GetTouch(int i)
	{
		return null;
	}
}
