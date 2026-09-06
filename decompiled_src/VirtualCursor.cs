using UnityEngine;

public class VirtualCursor : MonoBehaviour
{
	public float speed;

	private float currentSpeed;

	public float acceleration;

	public Vector2 screenBounds;

	public Vector3 position;

	private const float deadzone = 0.03f;

	private const float touchpadSensitivity = 4f;

	public Camera cam;

	public static Vector2 currentPosition;

	public static bool buttonDown;

	public static bool joystickMoved;

	public static VirtualCursor instance;

	public static int horizontalAxis;

	public static int verticalAxis;

	private int framesVisible;

	private const int minFramesToAppear = 3;

	private SpriteRenderer sr;

	private Vector2 prevTouchPos;

	private bool setTouchPos;

	public static bool CursorActive
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public void SetWorldPosition(Vector2 worldPos)
	{
		throw null;
	}

	public void SetScreenPosition(Vector2 screenPos)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public VirtualCursor()
	{
		throw null;
	}

	static VirtualCursor()
	{
		throw null;
	}
}
