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

	public bool AtTop
	{
		get
		{
			throw null;
		}
	}

	public bool AtBottom
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

	private void Update()
	{
		throw null;
	}

	public void ScrollDown()
	{
		throw null;
	}

	public void ScrollUp()
	{
		throw null;
	}

	public void ScrollPercentY(float p)
	{
		throw null;
	}

	private void ApplyScrollDelta(Vector2 delta)
	{
		throw null;
	}

	private void ApplyScrollDeltaFromOrigin(Vector3 origin, Vector2 delta)
	{
		throw null;
	}

	private void ClampTarget()
	{
		throw null;
	}

	public void CalculateAndSetYBounds(float amount, float numPerRow, float numRowsVisible, float spacing)
	{
		throw null;
	}

	private void UpdateScrollBars()
	{
		throw null;
	}

	private void UpdateScrollBars(Vector3 pos)
	{
		throw null;
	}

	public void SetYBoundsMin(float yMin)
	{
		throw null;
	}

	public void ScrollToTop()
	{
		throw null;
	}

	private bool IsMouseOverHitBox()
	{
		throw null;
	}

	public Scroller()
	{
		throw null;
	}
}
