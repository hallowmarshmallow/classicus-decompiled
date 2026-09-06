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
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public bool ContainsElement(int elementId)
		{
			throw null;
		}

		public void SetAxisPosition(int elementId, float value)
		{
			throw null;
		}
	}

	private class UIElement
	{
		public int id;

		public ControllerUIElement element;

		public UIElement(int id, ControllerUIElement element)
		{
			throw null;
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

	private Player player
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

	private void Start()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void DrawActiveElements()
	{
		throw null;
	}

	private void ActivateElements(Player player, int actionId)
	{
		throw null;
	}

	private void DrawLabels()
	{
		throw null;
	}

	private void DrawLabels(Player player, InputAction action)
	{
		throw null;
	}

	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
		throw null;
	}

	private Stick GetStick(int elementId)
	{
		throw null;
	}

	private void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	public GamepadTemplateUI()
	{
		throw null;
	}
}
