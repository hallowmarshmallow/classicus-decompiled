using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using PowerTools;
using UnityEngine;

public class ShipStatus : MonoBehaviour
{
	public class SystemTypeComparer : IEqualityComparer<SystemTypes>
	{
		public static readonly SystemTypeComparer Instance;

		public bool Equals(SystemTypes x, SystemTypes y)
		{
			return false;
		}

		public int GetHashCode(SystemTypes obj)
		{
			return 0;
		}
	}

	public enum RpcCalls
	{
		CloseDoorsOfType,
		RepairSystem,
		SetWinners
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<IStepWatcher, int> _003C_003E9__77_0;

		public static Func<NormalPlayerTask, bool> _003C_003E9__95_0;

		public static Func<NormalPlayerTask, bool> _003C_003E9__95_1;

		public static Func<NormalPlayerTask, bool> _003C_003E9__95_2;

		public static Func<PlayerTask, bool> _003C_003E9__112_0;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__112_2;

		public static Func<PlayerTask, bool> _003C_003E9__112_1;

		public static Action<DeadBody> _003C_003E9__123_0;

		public static Func<PlayerTask, bool> _003C_003E9__124_0;

		public static Func<PlayerTask, bool> _003C_003E9__124_1;

		internal int _003CAwake_003Eb__77_0(IStepWatcher s)
		{
			return 0;
		}

		internal bool _003CBegin_003Eb__95_0(NormalPlayerTask t)
		{
			return false;
		}

		internal bool _003CBegin_003Eb__95_1(NormalPlayerTask t)
		{
			return false;
		}

		internal bool _003CBegin_003Eb__95_2(NormalPlayerTask t)
		{
			return false;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_0(PlayerTask t)
		{
			return false;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_2(GameData.PlayerInfo pc)
		{
			return false;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_1(PlayerTask t)
		{
			return false;
		}

		internal void _003CReviveEveryone_003Eb__123_0(DeadBody b)
		{
		}

		internal bool _003CCheckTaskCompletion_003Eb__124_0(PlayerTask task)
		{
			return false;
		}

		internal bool _003CCheckTaskCompletion_003Eb__124_1(PlayerTask t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public byte[] winningPlayerIds;

		internal bool _003CSetWinners_003Eb__0(GameData.PlayerInfo player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public ShipRoom room;

		public ShipStatus _003C_003E4__this;

		internal void _003CStart_003Eb__0(AudioSource player, float dt)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public byte idx;

		internal bool _003CGetTaskById_003Eb__0(NormalPlayerTask t)
		{
			return false;
		}

		internal bool _003CGetTaskById_003Eb__1(NormalPlayerTask t)
		{
			return false;
		}

		internal bool _003CGetTaskById_003Eb__2(NormalPlayerTask t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public HashSet<TaskTypes> usedTaskTypes;

		public Func<NormalPlayerTask, bool> _003C_003E9__0;

		internal bool _003CAddTasksFromList_003Eb__0(NormalPlayerTask t)
		{
			return false;
		}
	}

	private sealed class _003CCoStartEndGame_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShipStatus _003C_003E4__this;

		public float firstDelay;

		public GameOverReason reason;

		private int _003Cattempt_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartEndGame_003Ed__118(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPrespawnStep_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPrespawnStep_003Ed__93(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static ShipStatus Instance;

	public Color CameraColor;

	public float MaxLightRadius;

	public float MinLightRadius;

	public float MapScale;

	public Vector3 cafeSpawn;

	public MapBehaviour MapPrefab;

	public ExileController ExileCutscenePrefab;

	public Vector2 InitialSpawnCenter;

	public Vector2 MeetingSpawnCenter;

	public Vector2 UpperSpawnCenter;

	public float SpawnRadius;

	public AudioClip shipHum;

	public AudioClip EmergencyMeetingSound;

	public AudioClip BodyReportSound;

	public AudioClip[] VentMoveSounds;

	public AudioClip VentEnterSound;

	public AudioClip VentExitSound;

	public NormalPlayerTask[] CommonTasks;

	public NormalPlayerTask[] LongTasks;

	public NormalPlayerTask[] NormalTasks;

	public PlayerTask[] SpecialTasks;

	public List<Transform> DummyLocations;

	public OpenableDoor[] AllDoors;

	public Console[] AllConsoles;

	public SurvCamera[] AllCameras;

	public Ladder[] Ladders;

	public Dictionary<SystemTypes, ISystemType> Systems;

	public AnimationClip[] WeaponFires;

	public SpriteAnim WeaponsImage;

	public AnimationClip HatchActive;

	public SpriteAnim Hatch;

	public ParticleSystem HatchParticles;

	public AnimationClip ShieldsActive;

	public SpriteAnim[] ShieldsImages;

	public SpriteRenderer ShieldBorder;

	public Sprite ShieldBorderOn;

	public MedScannerBehaviour MedScanner;

	private int WeaponFireIdx;

	public float Timer;

	public float EmergencyCooldown;

	private readonly RaycastHit2D[] volumeBuffer;

	private ShipRoom[] _003CAllRooms_003Ek__BackingField;

	private Dictionary<SystemTypes, ShipRoom> _003CFastRooms_003Ek__BackingField;

	public Dictionary<SystemTypes, string> SystemOverrides;

	public Dictionary<TaskTypes, string> TaskOverrides;

	private Vent[] _003CAllVents_003Ek__BackingField;

	public bool hasBegin;

	private IStepWatcher[] _003CAllStepWatchers_003Ek__BackingField;

	private uint _003CDirtyBits_003Ek__BackingField;

	private uint _003CNetId_003Ek__BackingField;

	private static int BeginCalls;

	public bool startedEnding;

	private const int EndGameSendAttempts = 8;

	private const float EndGameRetryDelay = 1f;

	public ShipRoom[] AllRooms
	{
		get
		{
			return _003CAllRooms_003Ek__BackingField;
		}
		set
		{
			_003CAllRooms_003Ek__BackingField = value;
		}
	}

	public Dictionary<SystemTypes, ShipRoom> FastRooms
	{
		get
		{
			return _003CFastRooms_003Ek__BackingField;
		}
		private set
		{
			_003CFastRooms_003Ek__BackingField = value;
		}
	}

	public Vent[] AllVents
	{
		get
		{
			return _003CAllVents_003Ek__BackingField;
		}
		private set
		{
			_003CAllVents_003Ek__BackingField = value;
		}
	}

	public virtual bool ShouldHaveTasks => false;

	public IStepWatcher[] AllStepWatchers
	{
		get
		{
			return _003CAllStepWatchers_003Ek__BackingField;
		}
		private set
		{
			_003CAllStepWatchers_003Ek__BackingField = value;
		}
	}

	public uint DirtyBits
	{
		get
		{
			return _003CDirtyBits_003Ek__BackingField;
		}
		set
		{
			_003CDirtyBits_003Ek__BackingField = value;
		}
	}

	public uint NetId
	{
		get
		{
			return _003CNetId_003Ek__BackingField;
		}
		set
		{
			_003CNetId_003Ek__BackingField = value;
		}
	}

	public virtual void OnEnable()
	{
	}

	public virtual void AddSystems()
	{
	}

	public virtual void SetupCustomStrings()
	{
	}

	public virtual void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	public virtual void Awake()
	{
	}

	public void Start()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public Vector2 GetSpawnLocation(int playerId, int numPlayer, bool initialSpawn)
	{
		return default(Vector2);
	}

	public void StartShields()
	{
	}

	public void FireWeapon()
	{
	}

	protected void SetDirtyBit(uint val)
	{
	}

	public NormalPlayerTask GetTaskById(byte idx)
	{
		return null;
	}

	public void OpenHatch()
	{
	}

	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	public void RepairSystem(SystemTypes systemType, PlayerControl player, byte amount)
	{
	}

	private void DisableRunnerEmergencyButtons()
	{
	}

	public virtual void SelectInfected()
	{
	}

	internal void SelectInfectedClassic()
	{
	}

	private void AssignTaskIndexes()
	{
	}

	public virtual void PostIntroCutscene()
	{
	}

	public virtual IEnumerator PrespawnStep()
	{
		return null;
	}

	public virtual void PostExile(GameData.PlayerInfo exiled)
	{
	}

	public virtual void Begin()
	{
	}

	public virtual void PreBegin()
	{
	}

	public virtual void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
	}

	internal void ClearCriticalSabotages()
	{
	}

	public void FixedUpdate()
	{
	}

	private void GetAmbientSoundVolume(ShipRoom room, AudioSource player, float dt)
	{
	}

	public virtual float CalculateLightRadius(GameData.PlayerInfo player)
	{
		return 0f;
	}

	public virtual bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public virtual void Deserialize(MessageReader reader, bool initialState)
	{
	}

	protected (int, int, int, int, int) GetPlayerCounts()
	{
		return default((int, int, int, int, int));
	}

	private string GetImpostorDeadPopUpText()
	{
		return null;
	}

	private string GetRevivePopUpText()
	{
		return null;
	}

	private string GetTaskWinPopUpText()
	{
		return null;
	}

	private string GetSabotageWinPopUpText()
	{
		return null;
	}

	public virtual void CheckEndCriteria()
	{
	}

	private void CheckEndCriteriaRunner()
	{
	}

	internal void CheckEndCriteriaClassic()
	{
	}

	private void EndGameForSabotage()
	{
	}

	public void StartEndGame(GameOverReason endReason, float delay = 0.25f)
	{
	}

	public IEnumerator CoStartEndGame(GameOverReason reason, float firstDelay)
	{
		return null;
	}

	public static void EndGameDueToError()
	{
	}

	public void WinAlone(PlayerControl target)
	{
	}

	public void RpcSetWinners(byte[] winningPlayerIds)
	{
	}

	public void SetWinners(byte[] winningPlayerIds)
	{
	}

	private static void ReviveEveryone()
	{
	}

	public virtual bool CheckTaskCompletion()
	{
		return false;
	}

	public void RpcCloseDoorsOfType(SystemTypes type)
	{
	}

	public void RpcRepairSystem(SystemTypes systemType, int amount)
	{
	}

	public virtual void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
