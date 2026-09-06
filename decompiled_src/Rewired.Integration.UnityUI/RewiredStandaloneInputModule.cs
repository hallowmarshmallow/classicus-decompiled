using System;
using System.Collections.Generic;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
{
	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

	private const string DEFAULT_ACTION_CANCEL = "UICancel";

	private InputManager_Base rewiredInputManager;

	private bool useAllRewiredGamePlayers;

	private bool useRewiredSystemPlayer;

	private int[] rewiredPlayerIds;

	private bool usePlayingPlayersOnly;

	private List<Rewired.Components.PlayerMouse> playerMice;

	private bool moveOneElementPerAxisPress;

	private bool setActionsById;

	private int horizontalActionId;

	private int verticalActionId;

	private int submitActionId;

	private int cancelActionId;

	private string m_HorizontalAxis;

	private string m_VerticalAxis;

	private string m_SubmitButton;

	private string m_CancelButton;

	private float m_InputActionsPerSecond;

	private float m_RepeatDelay;

	private bool m_allowMouseInput;

	private bool m_allowMouseInputIfTouchSupported;

	private bool m_allowTouchInput;

	private bool m_deselectIfBackgroundClicked;

	private bool m_deselectBeforeSelecting;

	private bool m_ForceModuleActive;

	[NonSerialized]
	private int[] playerIds;

	private bool recompiling;

	[NonSerialized]
	private bool isTouchSupported;

	[NonSerialized]
	private double m_PrevActionTime;

	[NonSerialized]
	private Vector2 m_LastMoveVector;

	[NonSerialized]
	private int m_ConsecutiveMoveCount;

	[NonSerialized]
	private bool m_HasFocus;

	public InputManager_Base RewiredInputManager
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

	public bool UseAllRewiredGamePlayers
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

	public bool UseRewiredSystemPlayer
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

	public int[] RewiredPlayerIds
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

	public bool UsePlayingPlayersOnly
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

	public List<Rewired.Components.PlayerMouse> PlayerMice
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

	public bool MoveOneElementPerAxisPress
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

	public bool allowMouseInput
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

	public bool allowMouseInputIfTouchSupported
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

	public bool allowTouchInput
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

	public bool deselectIfBackgroundClicked
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

	private bool deselectBeforeSelecting
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

	public bool SetActionsById
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

	public int HorizontalActionId
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

	public int VerticalActionId
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

	public int SubmitActionId
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

	public int CancelActionId
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

	protected override bool isMouseSupported
	{
		get
		{
			throw null;
		}
	}

	private bool isTouchAllowed
	{
		get
		{
			throw null;
		}
	}

	public bool allowActivationOnMobileDevice
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

	public bool forceModuleActive
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

	public float inputActionsPerSecond
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

	public float repeatDelay
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

	public string horizontalAxis
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

	public string verticalAxis
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

	public string submitButton
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

	public string cancelButton
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

	private RewiredStandaloneInputModule()
	{
		throw null;
	}

	protected override void Awake()
	{
		throw null;
	}

	public override void UpdateModule()
	{
		throw null;
	}

	public override bool IsModuleSupported()
	{
		throw null;
	}

	public override bool ShouldActivateModule()
	{
		throw null;
	}

	public override void ActivateModule()
	{
		throw null;
	}

	public override void DeactivateModule()
	{
		throw null;
	}

	public override void Process()
	{
		throw null;
	}

	private bool ProcessTouchEvents()
	{
		throw null;
	}

	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
		throw null;
	}

	private bool SendSubmitEventToSelectedObject()
	{
		throw null;
	}

	private Vector2 GetRawMoveVector()
	{
		throw null;
	}

	private bool SendMoveEventToSelectedObject()
	{
		throw null;
	}

	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		throw null;
	}

	private void ProcessMouseEvents()
	{
		throw null;
	}

	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
		throw null;
	}

	private bool SendUpdateEventToSelectedObject()
	{
		throw null;
	}

	private void ProcessMousePress(MouseButtonEventData data)
	{
		throw null;
	}

	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
		throw null;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
		throw null;
	}

	private bool ShouldIgnoreEventsOnNoFocus()
	{
		throw null;
	}

	protected override void OnDestroy()
	{
		throw null;
	}

	protected override bool IsDefaultPlayer(int playerId)
	{
		throw null;
	}

	private void InitializeRewired()
	{
		throw null;
	}

	private void SetupRewiredVars()
	{
		throw null;
	}

	private void SetUpRewiredPlayerMice()
	{
		throw null;
	}

	private void SetUpRewiredActions()
	{
		throw null;
	}

	private bool GetButton(Player player, int actionId)
	{
		throw null;
	}

	private bool GetButtonDown(Player player, int actionId)
	{
		throw null;
	}

	private bool GetNegativeButton(Player player, int actionId)
	{
		throw null;
	}

	private bool GetNegativeButtonDown(Player player, int actionId)
	{
		throw null;
	}

	private float GetAxis(Player player, int actionId)
	{
		throw null;
	}

	private void CheckEditorRecompile()
	{
		throw null;
	}

	private void OnEditorRecompile()
	{
		throw null;
	}

	private void ClearRewiredVars()
	{
		throw null;
	}

	private bool DidAnyMouseMove()
	{
		throw null;
	}

	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
	{
		throw null;
	}

	private void OnRewiredInitialized()
	{
		throw null;
	}

	private void OnRewiredShutDown()
	{
		throw null;
	}
}
