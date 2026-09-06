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

		public TouchState()
		{
			throw null;
		}
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

	public static TouchType currentTouchType
	{
		get
		{
			throw null;
		}
	}

	public bool AnyTouch
	{
		get
		{
			throw null;
		}
	}

	public bool AnyTouchDown
	{
		get
		{
			throw null;
		}
	}

	public bool AnyTouchUp
	{
		get
		{
			throw null;
		}
	}

	public Vector2 DragPosition
	{
		get
		{
			throw null;
		}
	}

	public Vector2 DragStartPosition
	{
		get
		{
			throw null;
		}
	}

	public Camera mainCam
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public Controller()
	{
		throw null;
	}

	public bool CheckHover(Collider2D coll)
	{
		throw null;
	}

	public DragState CheckDrag(Collider2D coll)
	{
		throw null;
	}

	public void ResetDragPosition()
	{
		throw null;
	}

	public void ClearTouch()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public TouchState GetTouch(int i)
	{
		throw null;
	}
}
