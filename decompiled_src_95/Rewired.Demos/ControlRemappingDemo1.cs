using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos;

public class ControlRemappingDemo1 : MonoBehaviour
{
	private class ControllerSelection
	{
		private int _id;

		private int _idPrev;

		private ControllerType _type;

		private ControllerType _typePrev;

		public int id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ControllerType type
		{
			get
			{
				return default(ControllerType);
			}
			set
			{
			}
		}

		public bool hasSelection => false;

		public void Set(int id, ControllerType type)
		{
		}

		public void Clear()
		{
		}
	}

	private class DialogHelper
	{
		public enum DialogType
		{
			None = 0,
			JoystickConflict = 1,
			ElementConflict = 2,
			KeyConflict = 3,
			DeleteAssignmentConfirmation = 10,
			AssignElement = 11
		}

		private const float openBusyDelay = 0.25f;

		private const float closeBusyDelay = 0.1f;

		private DialogType _type;

		private bool _enabled;

		private float _busyTime;

		private bool _busyTimerRunning;

		private Action<int> drawWindowDelegate;

		private GUI.WindowFunction drawWindowFunction;

		private WindowProperties windowProperties;

		private int currentActionId;

		private Action<int, UserResponse> resultCallback;

		private float busyTimer => 0f;

		public bool enabled => false;

		public DialogType type
		{
			set
			{
			}
		}

		public bool busy => false;

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
		}

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
		}

		public void Update()
		{
		}

		public void Draw()
		{
		}

		public void DrawConfirmButton(string title)
		{
		}

		public void DrawConfirmButton(UserResponse response, string title)
		{
		}

		public void DrawCancelButton()
		{
		}

		public void DrawCancelButton(string title)
		{
		}

		public void Confirm()
		{
		}

		public void Confirm(UserResponse response)
		{
		}

		public void Cancel()
		{
		}

		private void DrawWindow(int windowId)
		{
		}

		private void UpdateTimers()
		{
		}

		private void StartBusyTimer(float time)
		{
		}

		private void Close()
		{
		}

		private void StateChanged(float delay)
		{
		}

		private void Reset()
		{
		}

		private void ResetTimers()
		{
		}

		public void FullReset()
		{
		}
	}

	private abstract class QueueEntry
	{
		public enum State
		{
			Waiting,
			Confirmed,
			Canceled
		}

		private int _003Cid_003Ek__BackingField;

		private QueueActionType _003CqueueActionType_003Ek__BackingField;

		private State _003Cstate_003Ek__BackingField;

		private UserResponse _003Cresponse_003Ek__BackingField;

		private static int uidCounter;

		public int id
		{
			get
			{
				return _003Cid_003Ek__BackingField;
			}
			protected set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		public QueueActionType queueActionType
		{
			get
			{
				return _003CqueueActionType_003Ek__BackingField;
			}
			protected set
			{
				_003CqueueActionType_003Ek__BackingField = value;
			}
		}

		public State state
		{
			get
			{
				return _003Cstate_003Ek__BackingField;
			}
			protected set
			{
				_003Cstate_003Ek__BackingField = value;
			}
		}

		public UserResponse response
		{
			get
			{
				return _003Cresponse_003Ek__BackingField;
			}
			protected set
			{
				_003Cresponse_003Ek__BackingField = value;
			}
		}

		protected static int nextId => 0;

		public QueueEntry(QueueActionType queueActionType)
		{
		}

		public void Confirm(UserResponse response)
		{
		}

		public void Cancel()
		{
		}
	}

	private class JoystickAssignmentChange : QueueEntry
	{
		private int _003CplayerId_003Ek__BackingField;

		private int _003CjoystickId_003Ek__BackingField;

		private bool _003Cassign_003Ek__BackingField;

		public int playerId
		{
			get
			{
				return _003CplayerId_003Ek__BackingField;
			}
			private set
			{
				_003CplayerId_003Ek__BackingField = value;
			}
		}

		public int joystickId
		{
			get
			{
				return _003CjoystickId_003Ek__BackingField;
			}
			private set
			{
				_003CjoystickId_003Ek__BackingField = value;
			}
		}

		public bool assign
		{
			get
			{
				return _003Cassign_003Ek__BackingField;
			}
			private set
			{
				_003Cassign_003Ek__BackingField = value;
			}
		}

		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
		{
		}
	}

	private class ElementAssignmentChange : QueueEntry
	{
		private ElementAssignmentChangeType _003CchangeType_003Ek__BackingField;

		private InputMapper.Context _003Ccontext_003Ek__BackingField;

		public ElementAssignmentChangeType changeType
		{
			get
			{
				return _003CchangeType_003Ek__BackingField;
			}
			set
			{
				_003CchangeType_003Ek__BackingField = value;
			}
		}

		public InputMapper.Context context
		{
			get
			{
				return _003Ccontext_003Ek__BackingField;
			}
			private set
			{
				_003Ccontext_003Ek__BackingField = value;
			}
		}

		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
		{
		}

		public ElementAssignmentChange(ElementAssignmentChange other)
		{
		}
	}

	private class FallbackJoystickIdentification : QueueEntry
	{
		private int _003CjoystickId_003Ek__BackingField;

		private string _003CjoystickName_003Ek__BackingField;

		public int joystickId
		{
			get
			{
				return _003CjoystickId_003Ek__BackingField;
			}
			private set
			{
				_003CjoystickId_003Ek__BackingField = value;
			}
		}

		public string joystickName
		{
			get
			{
				return _003CjoystickName_003Ek__BackingField;
			}
			private set
			{
				_003CjoystickName_003Ek__BackingField = value;
			}
		}

		public FallbackJoystickIdentification(int joystickId, string joystickName)
		{
		}
	}

	private class Calibration : QueueEntry
	{
		private Player _003Cplayer_003Ek__BackingField;

		private Joystick _003Cjoystick_003Ek__BackingField;

		private CalibrationMap _003CcalibrationMap_003Ek__BackingField;

		public int selectedElementIdentifierId;

		public bool recording;

		private Player player
		{
			set
			{
				_003Cplayer_003Ek__BackingField = value;
			}
		}

		public Joystick joystick
		{
			get
			{
				return _003Cjoystick_003Ek__BackingField;
			}
			private set
			{
				_003Cjoystick_003Ek__BackingField = value;
			}
		}

		public CalibrationMap calibrationMap
		{
			get
			{
				return _003CcalibrationMap_003Ek__BackingField;
			}
			private set
			{
				_003CcalibrationMap_003Ek__BackingField = value;
			}
		}

		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
		{
		}
	}

	private struct WindowProperties
	{
		public int windowId;

		public Rect rect;

		public Action<string, string> windowDrawDelegate;

		public string title;

		public string message;
	}

	private enum QueueActionType
	{
		None,
		JoystickAssignment,
		ElementAssignment,
		FallbackJoystickIdentification,
		Calibrate
	}

	private enum ElementAssignmentChangeType
	{
		Add,
		Replace,
		Remove,
		ReassignOrRemove,
		ConflictCheck
	}

	public enum UserResponse
	{
		Confirm,
		Cancel,
		Custom1,
		Custom2
	}

	private const float defaultModalWidth = 250f;

	private const float defaultModalHeight = 200f;

	private const float assignmentTimeout = 5f;

	private DialogHelper dialog;

	private InputMapper inputMapper;

	private InputMapper.ConflictFoundEventData conflictFoundEventData;

	private bool guiState;

	private bool busy;

	private bool pageGUIState;

	private Player selectedPlayer;

	private int selectedMapCategoryId;

	private ControllerSelection selectedController;

	private ControllerMap selectedMap;

	private bool showMenu;

	private bool startListening;

	private Vector2 actionScrollPos;

	private Vector2 calibrateScrollPos;

	private Queue<QueueEntry> actionQueue;

	private bool setupFinished;

	[NonSerialized]
	private bool initialized;

	private bool isCompiling;

	private GUIStyle style_wordWrap;

	private GUIStyle style_centeredBox;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Initialize()
	{
	}

	private void Setup()
	{
	}

	private void Subscribe()
	{
	}

	private void Unsubscribe()
	{
	}

	public void OnGUI()
	{
	}

	private void HandleMenuControl()
	{
	}

	private void Close()
	{
	}

	private void Open()
	{
	}

	private void DrawInitialScreen()
	{
	}

	private void DrawPage()
	{
	}

	private void DrawPlayerSelector()
	{
	}

	private void DrawMouseAssignment()
	{
	}

	private void DrawJoystickSelector()
	{
	}

	private void DrawControllerSelector()
	{
	}

	private void DrawCalibrateButton()
	{
	}

	private void DrawMapCategories()
	{
	}

	private void DrawCategoryActions()
	{
	}

	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
	}

	private void ShowDialog()
	{
	}

	private void DrawModalWindow(string title, string message)
	{
	}

	private void DrawModalWindow_OkayOnly(string title, string message)
	{
	}

	private void DrawElementAssignmentWindow(string title, string message)
	{
	}

	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
	}

	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
	}

	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
	}

	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
	}

	private void DrawCalibrationWindow(string title, string message)
	{
	}

	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
	}

	private Rect GetScreenCenteredRect(float width, float height)
	{
		return default(Rect);
	}

	private void EnqueueAction(QueueEntry entry)
	{
	}

	private void ProcessQueue()
	{
	}

	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		return false;
	}

	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		return false;
	}

	private bool ProcessCalibration(Calibration entry)
	{
		return false;
	}

	private void PlayerSelectionChanged()
	{
	}

	private void ControllerSelectionChanged()
	{
	}

	private void ClearControllerSelection()
	{
	}

	private void ClearMapSelection()
	{
	}

	private void ResetAll()
	{
	}

	private void ClearWorkingVars()
	{
	}

	private void SetGUIStateStart()
	{
	}

	private void SetGUIStateEnd()
	{
	}

	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
	}

	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	public void IdentifyAllJoysticks()
	{
	}
}
