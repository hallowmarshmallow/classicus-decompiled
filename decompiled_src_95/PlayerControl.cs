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
			return false;
		}

		public int GetHashCode(Collider2D obj)
		{
			return 0;
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

		public static Func<PlayerTask, bool> _003C_003E9__134_0;

		internal void _003CStart_003Eb__93_1()
		{
		}

		internal void _003CStart_003Eb__93_3()
		{
		}

		internal bool _003CStart_003Eb__93_4()
		{
			return false;
		}

		internal void _003CClientInitialize_003Eb__96_1()
		{
		}

		internal bool _003CDie_003Eb__127_2(RoleBehaviour role)
		{
			return false;
		}

		internal int _003CDie_003Eb__127_3(RoleBehaviour r)
		{
			return 0;
		}

		internal bool _003CDie_003Eb__127_0(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003CNewTaskText_003Eb__134_0(PlayerTask t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public uint idx;

		internal bool _003CCompleteTask_003Eb__0(PlayerTask p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public PlayerControl _003C_003E4__this;

		public string cleanName;

		internal bool _003CCheckName_003Eb__0(GameData.PlayerInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass202_0
	{
		public ushort roleId;

		internal bool _003CRpcSyncRoleOption_003Eb__0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass217_0
	{
		public PlayerControl _003C_003E4__this;

		public PlayerControl t;

		internal bool _003CCheckMurder_003Eb__0(PlayerControl pc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass226_0
	{
		public string roleName;

		internal bool _003CHandleRpc_003Eb__0(RoleBehaviour r)
		{
			return false;
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAssertWithTimeout_003Ed__92(int _003C_003E1__state)
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

	private sealed class _003CClientInitialize_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClientInitialize_003Ed__96(int _003C_003E1__state)
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

	private sealed class _003CCoEnsureCameraTarget_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoEnsureCameraTarget_003Ed__117(int _003C_003E1__state)
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

	private sealed class _003CCoSetName_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public string playerName;

		private int _003Cattempts_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSetName_003Ed__150(int _003C_003E1__state)
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

	private sealed class _003CCoSetTasks_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public byte[] tasks;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSetTasks_003Ed__122(int _003C_003E1__state)
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

	private sealed class _003CCoStartMeeting_003Ed__189 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameData.PlayerInfo target;

		public PlayerControl _003C_003E4__this;

		private Vector3 _003CpreMeetingPos_003E5__2;

		private float _003Cwaited_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartMeeting_003Ed__189(int _003C_003E1__state)
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

	private sealed class _003CCoWaitForLobbyAndSpawn_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private float _003Cgrace_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWaitForLobbyAndSpawn_003Ed__101(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoWaitForLobbyThenSpawnRemote_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWaitForLobbyThenSpawnRemote_003Ed__102(int _003C_003E1__state)
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

	private sealed class _003CStart_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		private bool _003CamOwner_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStart_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CWaitForLobbyOrShip_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Cwaited_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForLobbyOrShip_003Ed__100(int _003C_003E1__state)
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

	public SpriteRenderer myRend => null;

	public IUsable ClosestUsable => null;

	public bool CanMove => false;

	public bool IsMe => false;

	public GameData.PlayerInfo Data => null;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float KillTimer => 0f;

	private bool IsServerFakeClient => false;

	public static void HideCursorTemporarily()
	{
	}

	private void LobbyInputWatchdog()
	{
	}

	public void SetKillTimerBasic(float time)
	{
	}

	public void SetKillTimerOld(float time)
	{
	}

	private void Awake()
	{
	}

	public void ResetPlayer()
	{
	}

	private IEnumerator AssertWithTimeout(Func<bool> assertion, Action onTimeout, float timeoutInSeconds)
	{
		return null;
	}

	private IEnumerator Start()
	{
		return null;
	}

	private IEnumerator ClientInitialize()
	{
		return null;
	}

	private static bool ShouldWaitForLobbySpawn()
	{
		return false;
	}

	private static IEnumerator WaitForLobbyOrShip()
	{
		return null;
	}

	private IEnumerator CoWaitForLobbyAndSpawn()
	{
		return null;
	}

	private IEnumerator CoWaitForLobbyThenSpawnRemote()
	{
		return null;
	}

	public void OnUpdateSystem(SystemTypes systemType, byte amount, bool affected)
	{
	}

	public override void OnDestroy()
	{
	}

	public void FixedUpdate()
	{
	}

	public void UseClosest()
	{
	}

	public void UseClosestVent()
	{
	}

	public void ReportClosest()
	{
	}

	public DeadBody GetClosestBody(float maxReportDistance)
	{
		return null;
	}

	public void PlayStepSound()
	{
	}

	private void HideVoiceVolumeIcon()
	{
	}

	private void UpdateVoiceVolumeIcon()
	{
	}

	private void SetVoiceVolumeIcon(Sprite sprite)
	{
	}

	private void SetScanner(bool on, byte cnt)
	{
	}

	public void SetPlayerScale(float scale)
	{
	}

	public Vector2 GetTruePosition()
	{
		return default(Vector2);
	}

	private IEnumerator CoEnsureCameraTarget()
	{
		return null;
	}

	private bool EnsureCameraTarget()
	{
		return false;
	}

	public PlayerControl FindClosestTarget()
	{
		return null;
	}

	public bool IsFriend(GameData.PlayerInfo target)
	{
		return false;
	}

	public void SetTasks(byte[] tasks)
	{
	}

	private IEnumerator CoSetTasks(byte[] tasks)
	{
		return null;
	}

	public void AddSystemTask(SystemTypes system)
	{
	}

	private static PlayerTask FindSpecialTask<T>(int fallbackIndex) where T : PlayerTask
	{
		return null;
	}

	public void RemoveTask(PlayerTask task)
	{
	}

	private void ClearTasks()
	{
	}

	public void Die(DeathReason reason, PlayerControl killer = null)
	{
	}

	public void Revive()
	{
	}

	private void RemoveMyDeadBody()
	{
	}

	public void SetPetPosition(Vector3 newPosition)
	{
	}

	public void PlayAnimation(byte animType)
	{
	}

	public void CompleteTask(uint idx)
	{
	}

	public void NewTaskText()
	{
	}

	public void CustomTaskText(string text, Color color)
	{
	}

	public void DestroyTaskTextIfPossible()
	{
	}

	public void ReloadTextAndNames()
	{
	}

	public void SetRole(string roleName)
	{
	}

	public ClientData GetClient()
	{
		return null;
	}

	public void RpcSetKillTimer(float killTimer)
	{
	}

	public void RpcStartGame()
	{
	}

	public void StartGame()
	{
	}

	public void RpcSetRole(string roleName)
	{
	}

	private RoleCapabilityFlags GetRoleCapabilityFlags()
	{
		return default(RoleCapabilityFlags);
	}

	public void SetKinematic(bool b)
	{
	}

	public void Exiled()
	{
	}

	public void CheckName(string name)
	{
	}

	public void CheckColor(byte bodyColor)
	{
	}

	public void SetName(string name)
	{
	}

	private IEnumerator CoSetName(string playerName)
	{
		return null;
	}

	public void RawSetOutfit(GameData.PlayerInfo target)
	{
	}

	public void SetRunnerBotOutfit(GameData.PlayerInfo info)
	{
	}

	private void RawSetName(string name)
	{
	}

	public static void SplitRolePrefix(string full, out string rolePrefix, out string cleanName)
	{
		rolePrefix = null;
		cleanName = null;
	}

	private void EnsurePlayerTagResolved()
	{
	}

	private void RefreshPlayerTagVisibility()
	{
	}

	private void ApplyVoiceIconHeight(bool tagShown)
	{
	}

	public static string DisplayNameForContext(string rawName)
	{
		return null;
	}

	private void UpdatePlayerTag(string rolePrefix)
	{
	}

	private static bool IsGradientRoleTag(string markup)
	{
		return false;
	}

	private static bool TryParseRoleTag(string markup, out string label, out Color color)
	{
		label = null;
		color = default(Color);
		return false;
	}

	public void SetHatAlpha(float a)
	{
	}

	public void SetColor(int bodyColor)
	{
	}

	private void RawSetColor(int bodyColor)
	{
	}

	public void ApplyColorFromData()
	{
	}

	public void SetSkin(string skinId)
	{
	}

	private void RawSetSkin(string skinId)
	{
	}

	public void SetHat(string hatId)
	{
	}

	private void RawSetHat(string hatId)
	{
	}

	public void SetPet(string petId)
	{
	}

	private void RawSetPet(string petId)
	{
	}

	public static void SetPetImage(string petId, int colorId, SpriteRenderer target)
	{
	}

	public static void SetPetImage(PetBehaviour pet, byte colorId, SpriteRenderer target)
	{
	}

	public static void SetSkinImage(string skinId, SpriteRenderer target)
	{
	}

	public static void SetSkinImage(SkinData skin, SpriteRenderer target)
	{
	}

	public static void SetHatImage(string hatId, SpriteRenderer target)
	{
	}

	public static void SetHatImage(HatBehaviour hat, SpriteRenderer target)
	{
	}

	public static void SetHatImage(string hatId, HatParent target)
	{
	}

	public static void SetHatImage(HatBehaviour hat, HatParent target)
	{
	}

	public void DragMask()
	{
	}

	private void ReportDeadBody(GameData.PlayerInfo target)
	{
	}

	public IEnumerator CoStartMeeting(GameData.PlayerInfo target)
	{
		return null;
	}

	public void MurderPlayer(PlayerControl target)
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public void SetPlayerMaterialColors(Renderer rend)
	{
	}

	public static void SetPlayerMaterialColors(int colorId, Renderer rend)
	{
	}

	public static bool InvalidColor(int colorId)
	{
		return false;
	}

	public void RpcSetScanner(bool value)
	{
	}

	public void RpcPlayAnimation(byte animType)
	{
	}

	public void RpcSetStartCounter(int secondsLeft)
	{
	}

	public void RpcCompleteTask(uint idx)
	{
	}

	public void RpcSyncSettings(GameOptionsData gameOptions)
	{
	}

	public void RpcSyncRoleOption(string roleName, string optionName, float value)
	{
	}

	public void RpcSyncRoleOption(ushort roleId, byte optionId, float value)
	{
	}

	public void RpcSyncRoleSettings(string roleOptions)
	{
	}

	public void RpcSetSkin(string skinId)
	{
	}

	public void RpcSetHat(string hatId)
	{
	}

	public void RpcSetPet(string petId)
	{
	}

	public void RpcSetName(string name)
	{
	}

	public void RpcSetColor(byte bodyColor)
	{
	}

	public void CmdCheckColor(byte bodyColor)
	{
	}

	public bool RpcSendChat(string chatText)
	{
		return false;
	}

	public void RpcBroadcastSystemAlert(string message)
	{
	}

	public void RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType)
	{
	}

	public void CmdReportDeadBody(GameData.PlayerInfo target)
	{
	}

	public void RpcStartMeeting(GameData.PlayerInfo info)
	{
	}

	private bool IsWithinKillRange(PlayerControl target)
	{
		return false;
	}

	public void CmdCheckMurder(PlayerControl target)
	{
	}

	public void CheckMurder(PlayerControl t)
	{
	}

	public void RpcMurderPlayer(PlayerControl target, MurderResultFlags status)
	{
	}

	public void RpcSetPlayerScale(float scale)
	{
	}

	public MessageWriter StartRoleRpc(int rpcId, int target = -1)
	{
		return null;
	}

	public void RpcExile()
	{
	}

	public void CmdCheckName(string name)
	{
	}

	private static string SanitizeNameForServer(string name)
	{
		return null;
	}

	private static bool IsCharAllowedByServer(char i)
	{
		return false;
	}

	public void HandleVoice(MessageReader reader)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	private bool _003CStart_003Eb__93_0()
	{
		return false;
	}

	private bool _003CStart_003Eb__93_2()
	{
		return false;
	}

	private bool _003CClientInitialize_003Eb__96_0()
	{
		return false;
	}

	private bool _003CDie_003Eb__127_1(RoleBehaviour r)
	{
		return false;
	}

	private bool _003CGetClient_003Eb__139_0(ClientData cd)
	{
		return false;
	}
}
