using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI;

public class GamepadTemplateUI : MonoBehaviour
{
	private class Stick
	{
		private RectTransform _transform;

		private Vector2 _origPosition;

		private int _xAxisElementId;

		private int _yAxisElementId;

		public Vector2 position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
		}

		public void Reset()
		{
		}

		public bool ContainsElement(int elementId)
		{
			return false;
		}

		public void SetAxisPosition(int elementId, float value)
		{
		}
	}

	private class UIElement
	{
		public int id;

		public ControllerUIElement element;

		public UIElement(int id, ControllerUIElement element)
		{
		}
	}

	private const float stickRadius = 20f;

	public int playerId;

	private RectTransform leftStick;

	private RectTransform rightStick;

	private ControllerUIElement leftStickX;

	private ControllerUIElement leftStickY;

	private ControllerUIElement leftStickButton;

	private ControllerUIElement rightStickX;

	private ControllerUIElement rightStickY;

	private ControllerUIElement rightStickButton;

	private ControllerUIElement actionBottomRow1;

	private ControllerUIElement actionBottomRow2;

	private ControllerUIElement actionBottomRow3;

	private ControllerUIElement actionTopRow1;

	private ControllerUIElement actionTopRow2;

	private ControllerUIElement actionTopRow3;

	private ControllerUIElement leftShoulder;

	private ControllerUIElement leftTrigger;

	private ControllerUIElement rightShoulder;

	private ControllerUIElement rightTrigger;

	private ControllerUIElement center1;

	private ControllerUIElement center2;

	private ControllerUIElement center3;

	private ControllerUIElement dPadUp;

	private ControllerUIElement dPadRight;

	private ControllerUIElement dPadDown;

	private ControllerUIElement dPadLeft;

	private UIElement[] _uiElementsArray;

	private Dictionary<int, ControllerUIElement> _uiElements;

	private IList<ControllerTemplateElementTarget> _tempTargetList;

	private Stick[] _sticks;

	private Player player => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void DrawActiveElements()
	{
	}

	private void ActivateElements(Player player, int actionId)
	{
	}

	private void DrawLabels()
	{
	}

	private void DrawLabels(Player player, InputAction action)
	{
	}

	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
	}

	private Stick GetStick(int elementId)
	{
		return null;
	}

	private void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}
}
