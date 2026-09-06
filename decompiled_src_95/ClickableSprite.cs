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
	}

	public virtual void OnMouseUp()
	{
	}

	public virtual void OnMouseUpAsButton()
	{
	}

	public virtual void OnMouseEnter()
	{
	}

	public virtual void OnMouseOver()
	{
	}

	public virtual void OnMouseExit()
	{
	}

	public virtual void OnMouseDrag()
	{
	}

	public virtual void OnTriggerEnter2D(Collider2D collider)
	{
	}

	public virtual void OnTriggerStay2D(Collider2D collider)
	{
	}

	public virtual void OnTriggerExit2D(Collider2D collider)
	{
	}
}
