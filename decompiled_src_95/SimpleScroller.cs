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

	private Camera _cam;

	private void OnEnable()
	{
	}

	private void OnApplicationFocus(bool focused)
	{
	}

	private Vector3 MouseWorld(Collider2D box)
	{
		return default(Vector3);
	}

	public void ResetScroll()
	{
	}

	private void Update()
	{
	}

	private void HandleWheelScroll()
	{
	}

	private void HandleSliderDrag()
	{
	}

	private void HandleDragScroll()
	{
	}

	private void HandleClickToBottom()
	{
	}

	private void SyncSliderHandle()
	{
	}

	public void ToggleClickToBottom()
	{
	}

	public void ScrollToBottom()
	{
	}

	public void ScrollToTop()
	{
	}
}
