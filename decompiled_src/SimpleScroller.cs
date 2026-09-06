using UnityEngine;

public class SimpleScroller : MonoBehaviour
{
	public Transform Inner;

	public Collider2D HitBox;

	public float YDown;

	public float YUp;

	public float ScrollSpeed;

	public float DragSpeed;

	public Transform SliderHandle;

	public Collider2D SliderHitBox;

	public float SliderYTop;

	public float SliderYBottom;

	public bool clickJumpsToBottom;

	private bool draggingContent;

	private bool draggingSlider;

	private Vector3 dragStartLocal;

	private Vector3 mouseStartWorld;

	private float sliderDragStartY;

	private float sliderMouseStartY;

	private void OnEnable()
	{
		throw null;
	}

	public void ResetScroll()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void HandleWheelScroll()
	{
		throw null;
	}

	private void HandleSliderDrag()
	{
		throw null;
	}

	private void HandleDragScroll()
	{
		throw null;
	}

	private void HandleClickToBottom()
	{
		throw null;
	}

	private void SyncSliderHandle()
	{
		throw null;
	}

	public void ToggleClickToBottom()
	{
		throw null;
	}

	public void ScrollToBottom()
	{
		throw null;
	}

	public void ScrollToTop()
	{
		throw null;
	}

	public SimpleScroller()
	{
		throw null;
	}
}
