using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using InnerNet;
using PowerTools;
using TMPro;
using UnityEngine;

public class PlayerControl : InnerNetObject
{
	public class ColliderComparer : IEqualityComparer<Collider2D>
	{
		public static readonly ColliderComparer Instance;

		public bool Equals(Collider2D x, Collider2D y)
		{
			throw null;
		}

		public int GetHashCode(Collider2D obj)
		{
			throw null;
		}

		public ColliderComparer()
		{
			throw null;
		}

		static ColliderComparer()
		{
			throw null;
		}
	}

	public enum RpcCalls : byte
	{
		PlayAnimation = 0,
		CompleteTask = 1,
		SyncSettings = 2,
		SetInfected = 3,
		Exiled = 4,
		CheckName = 5,
		SetName = 6,
		CheckColor = 7,
		SetColor = 8,
		SetHat = 9,
		SetSkin = 10,
		ReportDeadBody = 11,
		MurderPlayer = 12,
		SendChat = 13,
		TimesImpostor = 14,
		StartMeeting = 15,
		SetScanner = 16,
		SendChatNote = 17,
		SetPet = 18,
		SetStartCounter = 19,
		SetPlayerScale = 20,
		SetRole = 21,
		StartGame = 22,
		CheckMurder = 23,
		SetCooldown = 24,
		RoleRpc = 25,
		SyncRoleSettings = 26,
		SyncRoleOption = 28,
		Voice = 29
	}

	private enum RoleCapabilityFlags : byte
	{
		None = 0,
		CanUseKillButton = 1,
		CanSabotage = 2,
		CanVent = 4,
		CanUseScanner = 8,
		ShouldDoTasks = 0x10,
		IsAffectedByComms = 0x20
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__93_1;

		public static Action _003C_003E9__93_3;

		public static Func<bool> _003C_003E9__93_4;

		public static Action _003C_003E9__96_1;

		public static Func<RoleBehaviour, bool> _003C_003E9__127_2;

		public static Func<RoleBehaviour, int> _003C_003E9__127_3;

		public static Func<RoleBehaviour, bool> _003C_003E9__127_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CStart_003Eb__93_1()
		{
			throw null;
		}

		internal void _003CStart_003Eb__93_3()
		{
			throw null;
		}

		internal bool _003CStart_003Eb__93_4()
		{
			throw null;
		}

		internal void _003CClientInitialize_003Eb__96_1()
		{
			throw null;
		}

		internal bool _003CDie_003Eb__127_2(RoleBehaviour role)
		{
			throw null;
		}

		internal int _003CDie_003Eb__127_3(RoleBehaviour r)
		{
			throw null;
		}

		internal bool _003CDie_003Eb__127_0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public uint idx;

		public _003C_003Ec__DisplayClass132_0()
		{
			throw null;
		}

		internal bool _003CCompleteTask_003Eb__0(PlayerTask p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public PlayerControl _003C_003E4__this;

		public string cleanName;

		public _003C_003Ec__DisplayClass147_0()
		{
			throw null;
		}

		internal bool _003CCheckName_003Eb__0(GameData.PlayerInfo i)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass202_0
	{
		public ushort roleId;

		public _003C_003Ec__DisplayClass202_0()
		{
			throw null;
		}

		internal bool _003CRpcSyncRoleOption_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass217_0
	{
		public PlayerControl _003C_003E4__this;

		public PlayerControl t;

		public _003C_003Ec__DisplayClass217_0()
		{
			throw null;
		}

		internal bool _003CCheckMurder_003Eb__0(PlayerControl pc)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass226_0
	{
		public string roleName;

		public _003C_003Ec__DisplayClass226_0()
		{
			throw null;
		}

		internal bool _003CHandleRpc_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003CAssertWithTimeout_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> assertion;

		public float timeoutInSeconds;

		public Action onTimeout;

		private bool _003Cfailed_003E5__2;

		private float _003Ctimer_003E5__3;

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

		public _003CAssertWithTimeout_003Ed__92(int _003C_003E1__state)
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

	private sealed class _003CClientInitialize_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

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

		public _003CClientInitialize_003Ed__96(int _003C_003E1__state)
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

	private sealed class _003CCoEnsureCameraTarget_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private int _003Ci_003E5__2;

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

		public _003CCoEnsureCameraTarget_003Ed__117(int _003C_003E1__state)
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

	private sealed class _003CCoSetName_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public string playerName;

		private int _003Cattempts_003E5__2;

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

		public _003CCoSetName_003Ed__150(int _003C_003E1__state)
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

	private sealed class _003CCoSetTasks_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public byte[] tasks;

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

		public _003CCoSetTasks_003Ed__122(int _003C_003E1__state)
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

	private sealed class _003CCoStartMeeting_003Ed__189 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameData.PlayerInfo target;

		public PlayerControl _003C_003E4__this;

		private Vector3 _003CpreMeetingPos_003E5__2;

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

		public _003CCoStartMeeting_003Ed__189(int _003C_003E1__state)
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

	private sealed class _003CCoWaitForLobbyAndSpawn_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private float _003Cgrace_003E5__2;

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

		public _003CCoWaitForLobbyAndSpawn_003Ed__101(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoWaitForLobbyThenSpawnRemote_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

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

		public _003CCoWaitForLobbyThenSpawnRemote_003Ed__102(int _003C_003E1__state)
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

	private sealed class _003CStart_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private bool _003CamOwner_003E5__2;

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

		public _003CStart_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CWaitForLobbyOrShip_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Cwaited_003E5__2;

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

		public _003CWaitForLobbyOrShip_003Ed__100(int _003C_003E1__state)
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

	public byte PlayerId;

	public const float HideNSeekKillDistance = 0.6f;

	public const float MinKillIntervalSeconds = 0.35f;

	public const float KillRangeLagTolerance = 2f;

	[NonSerialized]
	public float pendingKillUntil;

	public float MaxReportDistance;

	public bool moveable;

	public bool inVent;

	public bool onLadder;

	public bool inMovingPlat;

	public bool ForceKillTimerContinue;

	public static PlayerControl LocalPlayer;

	private GameData.PlayerInfo _cachedData;

	public AudioSource FootSteps;

	public AudioClip KillSfx;

	public KillAnimation[] KillAnimations;

	public float killTimer;

	public int RemainingEmergencies;

	public TextMeshPro nameText;

	public LightSource LightPrefab;

	public LightSource myLight;

	public Collider2D Collider;

	public PlayerPhysics MyPhysics;

	public CustomNetworkTransform NetTransform;

	public Vector2 DeathPosition;

	public bool HasDeathPosition;

	public PetBehaviour CurrentPet;

	public HatParent HatRenderer;

	public SpriteRenderer VoiceVolumeIcon;

	public Sprite VoiceVolumeMaxSprite;

	public Sprite VoiceVolumeMediumSprite;

	public Sprite VoiceVolumeLowSprite;

	public Sprite VoiceVolumeZeroSprite;

	public Sprite VoiceVolumeMutedSprite;

	private Rigidbody2D rigidbody2D;

	private Collider2D[] hitBuffer;

	public static GameOptionsData GameOptions;

	public List<PlayerTask> myTasks;

	[NonSerialized]
	public uint TaskIdCount;

	public SpriteAnim[] ScannerAnims;

	public SpriteRenderer[] ScannersImages;

	public AudioClip[] VentMoveSounds;

	public AudioClip VentEnterSound;

	public AudioClip VentScarySound;

	private IUsable closest;

	private bool isNew;

	public static List<PlayerControl> AllPlayerControls;

	private Dictionary<Collider2D, IUsable> cache;

	private List<IUsable> itemsInRange;

	private List<IUsable> newItemsInRange;

	private byte scannerCount;

	private byte[] _pendingTaskIds;

	private int LastStartCounter;

	private const float VoiceIndicatorLowThreshold = 0.0025f;

	private const float VoiceIndicatorMediumThreshold = 0.012f;

	private const float VoiceIndicatorMaxThreshold = 0.035f;

	private const float VoiceIndicatorDecayPerSecond = 0.08f;

	private float voiceIndicatorLevel;

	public Vent closestVent;

	public HatBehaviour CurrentHat;

	public bool dragedMask;

	public bool roleAllowMove;

	public bool notRealPlayer;

	public XMLSkinAnimator XMLSkin;

	private const float LobbyInputStuckSeconds = 3f;

	private static float _lobbyInputBlockedSince;

	private static bool _lobbyInputReported;

	private const float LobbySpawnWaitTimeout = 15f;

	private const float LobbyRecoveryGraceSeconds = 2f;

	public ImportantTextTask importantTextTask;

	private TextMeshPro _playerTagText;

	private bool _playerTagSearched;

	private string _roleTagPrefix;

	private const float VoiceIconBaseY = 0.28f;

	private const float VoiceIconTaggedY = 0.4f;

	private const string SystemAlertNameMarker = "§SA§";

	private string _alertRestoreName;

	public SpriteRenderer myRend
	{
		get
		{
			throw null;
		}
	}

	public IUsable ClosestUsable
	{
		get
		{
			throw null;
		}
	}

	public bool CanMove
	{
		get
		{
			throw null;
		}
	}

	public bool IsMe
	{
		get
		{
			throw null;
		}
	}

	public GameData.PlayerInfo Data
	{
		get
		{
			throw null;
		}
	}

	public bool Visible
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

	public float KillTimer
	{
		get
		{
			throw null;
		}
	}

	private bool IsServerFakeClient
	{
		get
		{
			throw null;
		}
	}

	public static void HideCursorTemporarily()
	{
		throw null;
	}

	private void LobbyInputWatchdog()
	{
		throw null;
	}

	public void SetKillTimerBasic(float time)
	{
		throw null;
	}

	public void SetKillTimerOld(float time)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	public void ResetPlayer()
	{
		throw null;
	}

	private IEnumerator AssertWithTimeout(Func<bool> assertion, Action onTimeout, float timeoutInSeconds)
	{
		throw null;
	}

	private IEnumerator Start()
	{
		throw null;
	}

	private IEnumerator ClientInitialize()
	{
		throw null;
	}

	private static bool ShouldWaitForLobbySpawn()
	{
		throw null;
	}

	private static IEnumerator WaitForLobbyOrShip()
	{
		throw null;
	}

	private IEnumerator CoWaitForLobbyAndSpawn()
	{
		throw null;
	}

	private IEnumerator CoWaitForLobbyThenSpawnRemote()
	{
		throw null;
	}

	public void OnUpdateSystem(SystemTypes systemType, byte amount, bool affected)
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void UseClosest()
	{
		throw null;
	}

	public void UseClosestVent()
	{
		throw null;
	}

	public void ReportClosest()
	{
		throw null;
	}

	public DeadBody GetClosestBody(float maxReportDistance)
	{
		throw null;
	}

	public void PlayStepSound()
	{
		throw null;
	}

	private void HideVoiceVolumeIcon()
	{
		throw null;
	}

	private void UpdateVoiceVolumeIcon()
	{
		throw null;
	}

	private void SetVoiceVolumeIcon(Sprite sprite)
	{
		throw null;
	}

	private void SetScanner(bool on, byte cnt)
	{
		throw null;
	}

	public void SetPlayerScale(float scale)
	{
		throw null;
	}

	public Vector2 GetTruePosition()
	{
		throw null;
	}

	private IEnumerator CoEnsureCameraTarget()
	{
		throw null;
	}

	private bool EnsureCameraTarget()
	{
		throw null;
	}

	public PlayerControl FindClosestTarget()
	{
		throw null;
	}

	public bool IsFriend(GameData.PlayerInfo target)
	{
		throw null;
	}

	public void SetTasks(byte[] tasks)
	{
		throw null;
	}

	private IEnumerator CoSetTasks(byte[] tasks)
	{
		throw null;
	}

	public void AddSystemTask(SystemTypes system)
	{
		throw null;
	}

	private static PlayerTask FindSpecialTask<T>(int fallbackIndex) where T : PlayerTask
	{
		throw null;
	}

	public void RemoveTask(PlayerTask task)
	{
		throw null;
	}

	private void ClearTasks()
	{
		throw null;
	}

	public void Die(DeathReason reason, PlayerControl killer = null)
	{
		throw null;
	}

	public void Revive()
	{
		throw null;
	}

	private void RemoveMyDeadBody()
	{
		throw null;
	}

	public void SetPetPosition(Vector3 newPosition)
	{
		throw null;
	}

	public void PlayAnimation(byte animType)
	{
		throw null;
	}

	public void CompleteTask(uint idx)
	{
		throw null;
	}

	public void NewTaskText()
	{
		throw null;
	}

	public void CustomTaskText(string text, Color color)
	{
		throw null;
	}

	public void DestroyTaskTextIfPossible()
	{
		throw null;
	}

	public void ReloadTextAndNames()
	{
		throw null;
	}

	public void SetRole(string roleName)
	{
		throw null;
	}

	public ClientData GetClient()
	{
		throw null;
	}

	public void RpcSetKillTimer(float killTimer)
	{
		throw null;
	}

	public void RpcStartGame()
	{
		throw null;
	}

	public void StartGame()
	{
		throw null;
	}

	public void RpcSetRole(string roleName)
	{
		throw null;
	}

	private RoleCapabilityFlags GetRoleCapabilityFlags()
	{
		throw null;
	}

	public void SetKinematic(bool b)
	{
		throw null;
	}

	public void Exiled()
	{
		throw null;
	}

	public void CheckName(string name)
	{
		throw null;
	}

	public void CheckColor(byte bodyColor)
	{
		throw null;
	}

	public void SetName(string name)
	{
		throw null;
	}

	private IEnumerator CoSetName(string playerName)
	{
		throw null;
	}

	public void RawSetOutfit(GameData.PlayerInfo target)
	{
		throw null;
	}

	public void SetRunnerBotOutfit(GameData.PlayerInfo info)
	{
		throw null;
	}

	private void RawSetName(string name)
	{
		throw null;
	}

	public static void SplitRolePrefix(string full, out string rolePrefix, out string cleanName)
	{
		throw null;
	}

	private void EnsurePlayerTagResolved()
	{
		throw null;
	}

	private void RefreshPlayerTagVisibility()
	{
		throw null;
	}

	private void ApplyVoiceIconHeight(bool tagShown)
	{
		throw null;
	}

	public static string DisplayNameForContext(string rawName)
	{
		throw null;
	}

	private void UpdatePlayerTag(string rolePrefix)
	{
		throw null;
	}

	private static bool IsGradientRoleTag(string markup)
	{
		throw null;
	}

	private static bool TryParseRoleTag(string markup, out string label, out Color color)
	{
		throw null;
	}

	public void SetHatAlpha(float a)
	{
		throw null;
	}

	public void SetColor(int bodyColor)
	{
		throw null;
	}

	private void RawSetColor(int bodyColor)
	{
		throw null;
	}

	public void ApplyColorFromData()
	{
		throw null;
	}

	public void SetSkin(string skinId)
	{
		throw null;
	}

	private void RawSetSkin(string skinId)
	{
		throw null;
	}

	public void SetHat(string hatId)
	{
		throw null;
	}

	private void RawSetHat(string hatId)
	{
		throw null;
	}

	public void SetPet(string petId)
	{
		throw null;
	}

	private void RawSetPet(string petId)
	{
		throw null;
	}

	public static void SetPetImage(string petId, int colorId, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetPetImage(PetBehaviour pet, byte colorId, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetSkinImage(string skinId, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetSkinImage(SkinData skin, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetHatImage(string hatId, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetHatImage(HatBehaviour hat, SpriteRenderer target)
	{
		throw null;
	}

	public static void SetHatImage(string hatId, HatParent target)
	{
		throw null;
	}

	public static void SetHatImage(HatBehaviour hat, HatParent target)
	{
		throw null;
	}

	public void DragMask()
	{
		throw null;
	}

	private void ReportDeadBody(GameData.PlayerInfo target)
	{
		throw null;
	}

	public IEnumerator CoStartMeeting(GameData.PlayerInfo target)
	{
		throw null;
	}

	public void MurderPlayer(PlayerControl target)
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public void SetPlayerMaterialColors(Renderer rend)
	{
		throw null;
	}

	public static void SetPlayerMaterialColors(int colorId, Renderer rend)
	{
		throw null;
	}

	public static bool InvalidColor(int colorId)
	{
		throw null;
	}

	public void RpcSetScanner(bool value)
	{
		throw null;
	}

	public void RpcPlayAnimation(byte animType)
	{
		throw null;
	}

	public void RpcSetStartCounter(int secondsLeft)
	{
		throw null;
	}

	public void RpcCompleteTask(uint idx)
	{
		throw null;
	}

	public void RpcSyncSettings(GameOptionsData gameOptions)
	{
		throw null;
	}

	public void RpcSyncRoleOption(string roleName, string optionName, float value)
	{
		throw null;
	}

	public void RpcSyncRoleOption(ushort roleId, byte optionId, float value)
	{
		throw null;
	}

	public void RpcSyncRoleSettings(string roleOptions)
	{
		throw null;
	}

	public void RpcSetSkin(string skinId)
	{
		throw null;
	}

	public void RpcSetHat(string hatId)
	{
		throw null;
	}

	public void RpcSetPet(string petId)
	{
		throw null;
	}

	public void RpcSetName(string name)
	{
		throw null;
	}

	public void RpcSetColor(byte bodyColor)
	{
		throw null;
	}

	public void CmdCheckColor(byte bodyColor)
	{
		throw null;
	}

	public bool RpcSendChat(string chatText)
	{
		throw null;
	}

	public void RpcBroadcastSystemAlert(string message)
	{
		throw null;
	}

	public void RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType)
	{
		throw null;
	}

	public void CmdReportDeadBody(GameData.PlayerInfo target)
	{
		throw null;
	}

	public void RpcStartMeeting(GameData.PlayerInfo info)
	{
		throw null;
	}

	private bool IsWithinKillRange(PlayerControl target)
	{
		throw null;
	}

	public void CmdCheckMurder(PlayerControl target)
	{
		throw null;
	}

	public void CheckMurder(PlayerControl t)
	{
		throw null;
	}

	public void RpcMurderPlayer(PlayerControl target, MurderResultFlags status)
	{
		throw null;
	}

	public void RpcSetPlayerScale(float scale)
	{
		throw null;
	}

	public MessageWriter StartRoleRpc(int rpcId, int target = -1)
	{
		throw null;
	}

	public void RpcExile()
	{
		throw null;
	}

	public void CmdCheckName(string name)
	{
		throw null;
	}

	private static string SanitizeNameForServer(string name)
	{
		throw null;
	}

	private static bool IsCharAllowedByServer(char i)
	{
		throw null;
	}

	public void HandleVoice(MessageReader reader)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public PlayerControl()
	{
		throw null;
	}

	static PlayerControl()
	{
		throw null;
	}

	private bool _003CStart_003Eb__93_0()
	{
		throw null;
	}

	private bool _003CStart_003Eb__93_2()
	{
		throw null;
	}

	private bool _003CClientInitialize_003Eb__96_0()
	{
		throw null;
	}

	private bool _003CDie_003Eb__127_1(RoleBehaviour r)
	{
		throw null;
	}

	private bool _003CGetClient_003Eb__139_0(ClientData cd)
	{
		throw null;
	}
}
