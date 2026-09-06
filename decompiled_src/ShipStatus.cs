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
			throw null;
		}

		public int GetHashCode(SystemTypes obj)
		{
			throw null;
		}

		public SystemTypeComparer()
		{
			throw null;
		}

		static SystemTypeComparer()
		{
			throw null;
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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal int _003CAwake_003Eb__77_0(IStepWatcher s)
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__95_0(NormalPlayerTask t)
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__95_1(NormalPlayerTask t)
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__95_2(NormalPlayerTask t)
		{
			throw null;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_0(PlayerTask t)
		{
			throw null;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_2(GameData.PlayerInfo pc)
		{
			throw null;
		}

		internal bool _003CCheckEndCriteriaClassic_003Eb__112_1(PlayerTask t)
		{
			throw null;
		}

		internal void _003CReviveEveryone_003Eb__123_0(DeadBody b)
		{
			throw null;
		}

		internal bool _003CCheckTaskCompletion_003Eb__124_0(PlayerTask task)
		{
			throw null;
		}

		internal bool _003CCheckTaskCompletion_003Eb__124_1(PlayerTask t)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public byte[] winningPlayerIds;

		public _003C_003Ec__DisplayClass122_0()
		{
			throw null;
		}

		internal bool _003CSetWinners_003Eb__0(GameData.PlayerInfo player)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public ShipRoom room;

		public ShipStatus _003C_003E4__this;

		public _003C_003Ec__DisplayClass78_0()
		{
			throw null;
		}

		internal void _003CStart_003Eb__0(AudioSource player, float dt)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public byte idx;

		public _003C_003Ec__DisplayClass84_0()
		{
			throw null;
		}

		internal bool _003CGetTaskById_003Eb__0(NormalPlayerTask t)
		{
			throw null;
		}

		internal bool _003CGetTaskById_003Eb__1(NormalPlayerTask t)
		{
			throw null;
		}

		internal bool _003CGetTaskById_003Eb__2(NormalPlayerTask t)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public HashSet<TaskTypes> usedTaskTypes;

		public Func<NormalPlayerTask, bool> _003C_003E9__0;

		public _003C_003Ec__DisplayClass98_0()
		{
			throw null;
		}

		internal bool _003CAddTasksFromList_003Eb__0(NormalPlayerTask t)
		{
			throw null;
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

		public _003CCoStartEndGame_003Ed__118(int _003C_003E1__state)
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

	private sealed class _003CPrespawnStep_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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

		public _003CPrespawnStep_003Ed__93(int _003C_003E1__state)
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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public Dictionary<SystemTypes, ShipRoom> FastRooms
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

	public Vent[] AllVents
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

	public virtual bool ShouldHaveTasks
	{
		get
		{
			throw null;
		}
	}

	public IStepWatcher[] AllStepWatchers
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

	public uint DirtyBits
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

	public uint NetId
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

	public virtual void OnEnable()
	{
		throw null;
	}

	public virtual void AddSystems()
	{
		throw null;
	}

	public virtual void SetupCustomStrings()
	{
		throw null;
	}

	public virtual void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
		throw null;
	}

	public virtual void Awake()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public virtual void OnDestroy()
	{
		throw null;
	}

	public Vector2 GetSpawnLocation(int playerId, int numPlayer, bool initialSpawn)
	{
		throw null;
	}

	public void StartShields()
	{
		throw null;
	}

	public void FireWeapon()
	{
		throw null;
	}

	protected void SetDirtyBit(uint val)
	{
		throw null;
	}

	public NormalPlayerTask GetTaskById(byte idx)
	{
		throw null;
	}

	public void OpenHatch()
	{
		throw null;
	}

	public void CloseDoorsOfType(SystemTypes room)
	{
		throw null;
	}

	public void RepairSystem(SystemTypes systemType, PlayerControl player, byte amount)
	{
		throw null;
	}

	private void DisableRunnerEmergencyButtons()
	{
		throw null;
	}

	public virtual void SelectInfected()
	{
		throw null;
	}

	internal void SelectInfectedClassic()
	{
		throw null;
	}

	private void AssignTaskIndexes()
	{
		throw null;
	}

	public virtual void PostIntroCutscene()
	{
		throw null;
	}

	public virtual IEnumerator PrespawnStep()
	{
		throw null;
	}

	public virtual void PostExile(GameData.PlayerInfo exiled)
	{
		throw null;
	}

	public virtual void Begin()
	{
		throw null;
	}

	public virtual void PreBegin()
	{
		throw null;
	}

	public virtual void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
		throw null;
	}

	internal void ClearCriticalSabotages()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void GetAmbientSoundVolume(ShipRoom room, AudioSource player, float dt)
	{
		throw null;
	}

	public virtual float CalculateLightRadius(GameData.PlayerInfo player)
	{
		throw null;
	}

	public virtual bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public virtual void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	protected (int, int, int, int, int) GetPlayerCounts()
	{
		throw null;
	}

	private string GetImpostorDeadPopUpText()
	{
		throw null;
	}

	private string GetRevivePopUpText()
	{
		throw null;
	}

	private string GetTaskWinPopUpText()
	{
		throw null;
	}

	private string GetSabotageWinPopUpText()
	{
		throw null;
	}

	public virtual void CheckEndCriteria()
	{
		throw null;
	}

	private void CheckEndCriteriaRunner()
	{
		throw null;
	}

	internal void CheckEndCriteriaClassic()
	{
		throw null;
	}

	private void EndGameForSabotage()
	{
		throw null;
	}

	public void StartEndGame(GameOverReason endReason, float delay = 0.25f)
	{
		throw null;
	}

	public IEnumerator CoStartEndGame(GameOverReason reason, float firstDelay)
	{
		throw null;
	}

	public static void EndGameDueToError()
	{
		throw null;
	}

	public void WinAlone(PlayerControl target)
	{
		throw null;
	}

	public void RpcSetWinners(byte[] winningPlayerIds)
	{
		throw null;
	}

	public void SetWinners(byte[] winningPlayerIds)
	{
		throw null;
	}

	private static void ReviveEveryone()
	{
		throw null;
	}

	public virtual bool CheckTaskCompletion()
	{
		throw null;
	}

	public void RpcCloseDoorsOfType(SystemTypes type)
	{
		throw null;
	}

	public void RpcRepairSystem(SystemTypes systemType, int amount)
	{
		throw null;
	}

	public virtual void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public ShipStatus()
	{
		throw null;
	}
}
