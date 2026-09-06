using System.Collections.Generic;
using UnityEngine;

public class PassiveButtonManager : DestroyableSingleton<PassiveButtonManager>
{
	private class DepthComparer : IComparer<PassiveUiElement>
	{
		public static readonly DepthComparer Instance;

		public int Compare(PassiveUiElement x, PassiveUiElement y)
		{
			throw null;
		}

		public DepthComparer()
		{
			throw null;
		}

		static DepthComparer()
		{
			throw null;
		}
	}

	public List<PassiveUiElement> Buttons;

	private List<IFocusHolder> FocusHolders;

	private PassiveUiElement currentOver;

	public Controller Controller;

	public void RegisterOne(PassiveUiElement button)
	{
		throw null;
	}

	public void RemoveOne(PassiveUiElement passiveButton)
	{
		throw null;
	}

	public void RegisterOne(IFocusHolder focusHolder)
	{
		throw null;
	}

	public void RemoveOne(IFocusHolder focusHolder)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void HandleFocus(Vector2 pt)
	{
		throw null;
	}

	private void HandleMouseOut()
	{
		throw null;
	}

	private void HandleMouseOver(PassiveUiElement button, Collider2D col)
	{
		throw null;
	}

	private Vector2 GetTouch(bool getDownTouch)
	{
		throw null;
	}

	private static bool OverlapsAnyCollider(Collider2D[] colliders, Vector2 point)
	{
		throw null;
	}

	private bool AnyButtonHandlesDragAbove(Collider2D col)
	{
		throw null;
	}

	public PassiveButtonManager()
	{
		throw null;
	}
}
