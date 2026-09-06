using UnityEngine;

public class Scroller : MonoBehaviour
{
	public Transform Inner;

	public Collider2D HitBox;

	private Controller myController;

	private Vector3 dragOrigin;

	private Vector3 targetPosition;

	private Vector3 velocity;

	public bool allowX;

	public FloatRange XBounds;

	public bool allowY;

	public FloatRange YBounds;

	public float YBoundPerItem;

	public FloatRange ScrollerYRange;

	public SpriteRenderer ScrollerY;

	public float smoothTime;

	public float scrollSpeed;

	public float mouseScrollAmount;

	public bool AtTop => false;

	public bool AtBottom => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ScrollDown()
	{
	}

	public void ScrollUp()
	{
	}

	public void ScrollPercentY(float p)
	{
	}

	private void ApplyScrollDelta(Vector2 delta)
	{
	}

	private void ApplyScrollDeltaFromOrigin(Vector3 origin, Vector2 delta)
	{
	}

	private void ClampTarget()
	{
	}

	public void CalculateAndSetYBounds(float amount, float numPerRow, float numRowsVisible, float spacing)
	{
	}

	private void UpdateScrollBars()
	{
	}

	private void UpdateScrollBars(Vector3 pos)
	{
	}

	public void SetYBoundsMin(float yMin)
	{
	}

	public void ScrollToTop()
	{
	}

	private bool IsMouseOverHitBox()
	{
		return false;
	}
}
