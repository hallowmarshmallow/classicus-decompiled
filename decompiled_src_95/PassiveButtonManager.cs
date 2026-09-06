using System.Collections.Generic;
using UnityEngine;

public class PassiveButtonManager : DestroyableSingleton<PassiveButtonManager>
{
	private class DepthComparer : IComparer<PassiveUiElement>
	{
		public static readonly DepthComparer Instance;

		public int Compare(PassiveUiElement x, PassiveUiElement y)
		{
			return 0;
		}
	}

	public List<PassiveUiElement> Buttons;

	private List<IFocusHolder> FocusHolders;

	private PassiveUiElement currentOver;

	public Controller Controller;

	public void RegisterOne(PassiveUiElement button)
	{
	}

	public void RemoveOne(PassiveUiElement passiveButton)
	{
	}

	public void RegisterOne(IFocusHolder focusHolder)
	{
	}

	public void RemoveOne(IFocusHolder focusHolder)
	{
	}

	public void Update()
	{
	}

	private void HandleFocus(Vector2 pt)
	{
	}

	private void HandleMouseOut()
	{
	}

	private void HandleMouseOver(PassiveUiElement button, Collider2D col)
	{
	}

	private Vector2 GetTouch(bool getDownTouch)
	{
		return default(Vector2);
	}

	private static bool OverlapsAnyCollider(Collider2D[] colliders, Vector2 point)
	{
		return false;
	}

	private bool AnyButtonHandlesDragAbove(Collider2D col)
	{
		return false;
	}
}
