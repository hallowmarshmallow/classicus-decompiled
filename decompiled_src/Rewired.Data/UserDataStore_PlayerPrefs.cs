using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Data;

public class UserDataStore_PlayerPrefs : UserDataStore
{
	private class ControllerAssignmentSaveInfo
	{
		public class PlayerInfo
		{
			public int id;

			public bool hasKeyboard;

			public bool hasMouse;

			public JoystickInfo[] joysticks;

			public int joystickCount
			{
				get
				{
					throw null;
				}
			}

			public PlayerInfo()
			{
				throw null;
			}
		}

		public class JoystickInfo
		{
			public Guid instanceGuid;

			public string hardwareIdentifier;

			public int id;

			public JoystickInfo()
			{
				throw null;
			}
		}

		public PlayerInfo[] players;

		public int playerCount
		{
			get
			{
				throw null;
			}
		}

		public ControllerAssignmentSaveInfo(int playerCount)
		{
			throw null;
		}

		public int IndexOfPlayer(int playerId)
		{
			throw null;
		}

		public bool ContainsPlayer(int playerId)
		{
			throw null;
		}
	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick;

		public readonly int oldJoystickId;

		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public Joystick joystick;

		public _003C_003Ec__DisplayClass78_0()
		{
			throw null;
		}

		internal bool _003CLoadJoystickAssignmentsNow_003Eb__0(JoystickAssignmentHistoryInfo x)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_1
	{
		public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

		public _003C_003Ec__DisplayClass78_1()
		{
			throw null;
		}

		internal bool _003CLoadJoystickAssignmentsNow_003Eb__1(JoystickAssignmentHistoryInfo x)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_2
	{
		public Joystick match;

		public _003C_003Ec__DisplayClass78_2()
		{
			throw null;
		}

		internal bool _003CLoadJoystickAssignmentsNow_003Eb__2(JoystickAssignmentHistoryInfo x)
		{
			throw null;
		}
	}

	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserDataStore_PlayerPrefs _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CLoadJoystickAssignmentsDeferred_003Ed__80(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private const string thisScriptName = "UserDataStore_PlayerPrefs";

	private const string logPrefix = "Rewired: ";

	private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

	private const int controllerMapPPKeyVersion_original = 0;

	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

	private const int controllerMapPPKeyVersion = 2;

	private bool isEnabled;

	private bool loadDataOnStart;

	private bool loadJoystickAssignments;

	private bool loadKeyboardAssignments;

	private bool loadMouseAssignments;

	private string playerPrefsKeyPrefix;

	[NonSerialized]
	private bool allowImpreciseJoystickAssignmentMatching;

	[NonSerialized]
	private bool deferredJoystickAssignmentLoadPending;

	[NonSerialized]
	private bool wasJoystickEverDetected;

	[NonSerialized]
	private List<int> __allActionIds;

	[NonSerialized]
	private string __allActionIdsString;

	public bool IsEnabled
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

	public bool LoadDataOnStart
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

	public bool LoadJoystickAssignments
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

	public bool LoadKeyboardAssignments
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

	public bool LoadMouseAssignments
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

	public string PlayerPrefsKeyPrefix
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

	private string playerPrefsKey_controllerAssignments
	{
		get
		{
			throw null;
		}
	}

	private bool loadControllerAssignments
	{
		get
		{
			throw null;
		}
	}

	private List<int> allActionIds
	{
		get
		{
			throw null;
		}
	}

	private string allActionIdsString
	{
		get
		{
			throw null;
		}
	}

	public override void Save()
	{
		throw null;
	}

	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	public override void SavePlayerData(int playerId)
	{
		throw null;
	}

	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
		throw null;
	}

	public override void Load()
	{
		throw null;
	}

	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	public override void LoadPlayerData(int playerId)
	{
		throw null;
	}

	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
		throw null;
	}

	protected override void OnInitialize()
	{
		throw null;
	}

	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
		throw null;
	}

	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		throw null;
	}

	private int LoadAll()
	{
		throw null;
	}

	private int LoadPlayerDataNow(int playerId)
	{
		throw null;
	}

	private int LoadPlayerDataNow(Player player)
	{
		throw null;
	}

	private int LoadAllJoystickCalibrationData()
	{
		throw null;
	}

	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		throw null;
	}

	private int LoadJoystickCalibrationData(int joystickId)
	{
		throw null;
	}

	private int LoadJoystickData(int joystickId)
	{
		throw null;
	}

	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		throw null;
	}

	private int LoadInputBehaviors(int playerId)
	{
		throw null;
	}

	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		throw null;
	}

	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		throw null;
	}

	private bool LoadControllerAssignmentsNow()
	{
		throw null;
	}

	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		throw null;
	}

	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		throw null;
	}

	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		throw null;
	}

	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		throw null;
	}

	private void SaveAll()
	{
		throw null;
	}

	private void SavePlayerDataNow(int playerId)
	{
		throw null;
	}

	private void SavePlayerDataNow(Player player)
	{
		throw null;
	}

	private void SaveAllJoystickCalibrationData()
	{
		throw null;
	}

	private void SaveJoystickCalibrationData(int joystickId)
	{
		throw null;
	}

	private void SaveJoystickCalibrationData(Joystick joystick)
	{
		throw null;
	}

	private void SaveJoystickData(int joystickId)
	{
		throw null;
	}

	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
		throw null;
	}

	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		throw null;
	}

	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
		throw null;
	}

	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
		throw null;
	}

	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
		throw null;
	}

	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		throw null;
	}

	private bool SaveControllerAssignments()
	{
		throw null;
	}

	private bool ControllerAssignmentSaveDataExists()
	{
		throw null;
	}

	private string GetBasePlayerPrefsKey(Player player)
	{
		throw null;
	}

	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		throw null;
	}

	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		throw null;
	}

	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		throw null;
	}

	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		throw null;
	}

	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		throw null;
	}

	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		throw null;
	}

	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		throw null;
	}

	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		throw null;
	}

	private string GetInputBehaviorXml(Player player, int id)
	{
		throw null;
	}

	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
		throw null;
	}

	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		throw null;
	}

	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		throw null;
	}

	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		throw null;
	}

	private void RefreshLayoutManager(int playerId)
	{
		throw null;
	}

	private static Type GetControllerMapType(ControllerType controllerType)
	{
		throw null;
	}

	public UserDataStore_PlayerPrefs()
	{
		throw null;
	}
}
