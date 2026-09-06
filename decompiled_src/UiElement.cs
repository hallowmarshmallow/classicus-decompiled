using UnityEngine;
using UnityEngine.Events;

public abstract class UiElement : MonoBehaviour
{
	public UnityEvent OnMouseOver;

	public UnityEvent OnMouseOut;

	public virtual void ReceiveMouseOut()
	{
		throw null;
	}

	public virtual void ReceiveMouseOver()
	{
		throw null;
	}

	protected UiElement()
	{
		throw null;
	}
}
