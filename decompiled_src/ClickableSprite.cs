using System;
using UnityEngine;

public class ClickableSprite : MonoBehaviour
{
	public Action onDown;

	public Action onDrag;

	public Action onEnter;

	public Action onExit;

	public Action onOver;

	public Action<Collider2D> onTriggerEnter;

	public Action<Collider2D> onTriggerExit;

	public Action<Collider2D> onTriggerStay;

	public Action onUp;

	public Action onUpAsButton;

	public virtual void OnMouseDown()
	{
		throw null;
	}

	public virtual void OnMouseUp()
	{
		throw null;
	}

	public virtual void OnMouseUpAsButton()
	{
		throw null;
	}

	public virtual void OnMouseEnter()
	{
		throw null;
	}

	public virtual void OnMouseOver()
	{
		throw null;
	}

	public virtual void OnMouseExit()
	{
		throw null;
	}

	public virtual void OnMouseDrag()
	{
		throw null;
	}

	public virtual void OnTriggerEnter2D(Collider2D collider)
	{
		throw null;
	}

	public virtual void OnTriggerStay2D(Collider2D collider)
	{
		throw null;
	}

	public virtual void OnTriggerExit2D(Collider2D collider)
	{
		throw null;
	}

	public ClickableSprite()
	{
		throw null;
	}
}
