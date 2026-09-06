using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
	public static ControllerManager Instance;

	private int playerId;

	private const string DISCONNECT_POPUP_MENUNAME = "DisconnectPopup_Real";

	private const float DELTA_SINCE_LAST_BUTTON_HIGHLIGHT_THRESHOLD = 0.25f;

	private const float DELTA_SINCE_LAST_SLIDER_MOVEMENT_THRESHOLD = 0.1f;

	private bool inputDetectedLastFrame;

	private GameObject PrefabMouseCursorForConsole;

	private GameObject ConsoleMouse;

	public bool IsButtonHeld;

	public ControllerUiElementsState CurrentUiState;

	public List<ControllerUiElementsState> CurrentUiStateStack;

	private float deltaSinceLastUiHighlight;

	private bool disabledVirtualCursor;

	private int frameDelaySinceInputChanged;

	private string currentScene;

	public bool IsMenuActiveAtAll(string menuName)
	{
		return false;
	}

	public void AddSelectableUiElement(UiElement uiElement, bool forceSelect = false)
	{
	}

	private void HighlightSelection(UiElement selection)
	{
	}

	public void RemoveSelectableUiElement(UiElement uiElement)
	{
	}

	public void AddSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}

	public void RemoveSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}
}
