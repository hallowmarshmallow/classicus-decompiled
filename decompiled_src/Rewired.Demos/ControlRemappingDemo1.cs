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
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public ControllerType type
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

		public bool hasSelection
		{
			get
			{
				throw null;
			}
		}

		public ControllerSelection()
		{
			throw null;
		}

		public void Set(int id, ControllerType type)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
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

		private float busyTimer
		{
			get
			{
				throw null;
			}
		}

		public bool enabled
		{
			get
			{
				throw null;
			}
		}

		public DialogType type
		{
			set
			{
				throw null;
			}
		}

		public bool busy
		{
			get
			{
				throw null;
			}
		}

		public DialogHelper()
		{
			throw null;
		}

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
			throw null;
		}

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
			throw null;
		}

		public void Update()
		{
			throw null;
		}

		public void Draw()
		{
			throw null;
		}

		public void DrawConfirmButton(string title)
		{
			throw null;
		}

		public void DrawConfirmButton(UserResponse response, string title)
		{
			throw null;
		}

		public void DrawCancelButton()
		{
			throw null;
		}

		public void DrawCancelButton(string title)
		{
			throw null;
		}

		public void Confirm()
		{
			throw null;
		}

		public void Confirm(UserResponse response)
		{
			throw null;
		}

		public void Cancel()
		{
			throw null;
		}

		private void DrawWindow(int windowId)
		{
			throw null;
		}

		private void UpdateTimers()
		{
			throw null;
		}

		private void StartBusyTimer(float time)
		{
			throw null;
		}

		private void Close()
		{
			throw null;
		}

		private void StateChanged(float delay)
		{
			throw null;
		}

		private void Reset()
		{
			throw null;
		}

		private void ResetTimers()
		{
			throw null;
		}

		public void FullReset()
		{
			throw null;
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
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		public QueueActionType queueActionType
		{
			get
			{
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		public State state
		{
			get
			{
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		public UserResponse response
		{
			get
			{
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		protected static int nextId
		{
			get
			{
				throw null;
			}
		}

		public QueueEntry(QueueActionType queueActionType)
		{
			throw null;
		}

		public void Confirm(UserResponse response)
		{
			throw null;
		}

		public void Cancel()
		{
			throw null;
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
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public int joystickId
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public bool assign
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
		{
			throw null;
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
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public InputMapper.Context context
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
		{
			throw null;
		}

		public ElementAssignmentChange(ElementAssignmentChange other)
		{
			throw null;
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
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public string joystickName
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public FallbackJoystickIdentification(int joystickId, string joystickName)
		{
			throw null;
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
				throw null;
			}
		}

		public Joystick joystick
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public CalibrationMap calibrationMap
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
		{
			throw null;
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
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void Initialize()
	{
		throw null;
	}

	private void Setup()
	{
		throw null;
	}

	private void Subscribe()
	{
		throw null;
	}

	private void Unsubscribe()
	{
		throw null;
	}

	public void OnGUI()
	{
		throw null;
	}

	private void HandleMenuControl()
	{
		throw null;
	}

	private void Close()
	{
		throw null;
	}

	private void Open()
	{
		throw null;
	}

	private void DrawInitialScreen()
	{
		throw null;
	}

	private void DrawPage()
	{
		throw null;
	}

	private void DrawPlayerSelector()
	{
		throw null;
	}

	private void DrawMouseAssignment()
	{
		throw null;
	}

	private void DrawJoystickSelector()
	{
		throw null;
	}

	private void DrawControllerSelector()
	{
		throw null;
	}

	private void DrawCalibrateButton()
	{
		throw null;
	}

	private void DrawMapCategories()
	{
		throw null;
	}

	private void DrawCategoryActions()
	{
		throw null;
	}

	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
		throw null;
	}

	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
		throw null;
	}

	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
		throw null;
	}

	private void ShowDialog()
	{
		throw null;
	}

	private void DrawModalWindow(string title, string message)
	{
		throw null;
	}

	private void DrawModalWindow_OkayOnly(string title, string message)
	{
		throw null;
	}

	private void DrawElementAssignmentWindow(string title, string message)
	{
		throw null;
	}

	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
		throw null;
	}

	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
		throw null;
	}

	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
		throw null;
	}

	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
		throw null;
	}

	private void DrawCalibrationWindow(string title, string message)
	{
		throw null;
	}

	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
		throw null;
	}

	private Rect GetScreenCenteredRect(float width, float height)
	{
		throw null;
	}

	private void EnqueueAction(QueueEntry entry)
	{
		throw null;
	}

	private void ProcessQueue()
	{
		throw null;
	}

	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		throw null;
	}

	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		throw null;
	}

	private bool ProcessCalibration(Calibration entry)
	{
		throw null;
	}

	private void PlayerSelectionChanged()
	{
		throw null;
	}

	private void ControllerSelectionChanged()
	{
		throw null;
	}

	private void ClearControllerSelection()
	{
		throw null;
	}

	private void ClearMapSelection()
	{
		throw null;
	}

	private void ResetAll()
	{
		throw null;
	}

	private void ClearWorkingVars()
	{
		throw null;
	}

	private void SetGUIStateStart()
	{
		throw null;
	}

	private void SetGUIStateEnd()
	{
		throw null;
	}

	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
		throw null;
	}

	private void OnStopped(InputMapper.StoppedEventData data)
	{
		throw null;
	}

	public void IdentifyAllJoysticks()
	{
		throw null;
	}

	public ControlRemappingDemo1()
	{
		throw null;
	}
}
