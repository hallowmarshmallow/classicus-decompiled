using UnityEngine;

public class Draggable : ClickableSprite
{
	public Vector3 initialPosition;

	public bool forceStop;

	public bool dragging;

	private Camera _mainCam;

	private Vector2 _offset;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public override void OnMouseDown()
	{
	}

	public override void OnMouseDrag()
	{
	}

	public override void OnMouseUp()
	{
	}
}
