using UnityEngine;

public abstract class PassiveUiElement : UiElement
{
	public Collider2D ClickMask;

	public Collider2D[] Colliders;

	public bool HandleUp;

	public bool HandleDown;

	public bool HandleRepeat;

	public bool HandleDrag;

	public bool HandleOverOut;

	private float _003CCachedZ_003Ek__BackingField;

	public float CachedZ
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

	protected virtual void OnEnable()
	{
		throw null;
	}

	protected virtual void Start()
	{
		throw null;
	}

	protected virtual void OnDisable()
	{
		throw null;
	}

	protected virtual void OnDestroy()
	{
		throw null;
	}

	public virtual void ReceiveClickDown()
	{
		throw null;
	}

	public virtual void ReceiveRepeatDown()
	{
		throw null;
	}

	public virtual void ReceiveClickUp()
	{
		throw null;
	}

	public virtual void ReleaseButton()
	{
		throw null;
	}

	public virtual void ReceiveClickDrag(Vector2 dragDelta)
	{
		throw null;
	}

	protected PassiveUiElement()
	{
		throw null;
	}
}
