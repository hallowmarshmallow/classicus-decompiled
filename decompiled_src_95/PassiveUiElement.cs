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
			return _003CCachedZ_003Ek__BackingField;
		}
		set
		{
			_003CCachedZ_003Ek__BackingField = value;
		}
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void ReceiveClickDown()
	{
	}

	public virtual void ReceiveRepeatDown()
	{
	}

	public virtual void ReceiveClickUp()
	{
	}

	public virtual void ReleaseButton()
	{
	}

	public virtual void ReceiveClickDrag(Vector2 dragDelta)
	{
	}
}
