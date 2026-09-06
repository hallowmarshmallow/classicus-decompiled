using System.Collections.Generic;
using KlassicHideNSeek;
using UnityEngine;

internal sealed class HnSGameManager
{
	private struct AdminMapDot
	{
		internal float X;

		internal float Y;

		internal Color Col;
	}

	public enum MatchPhase
	{
		Idle,
		Escape,
		Hunt,
		FinalHunt,
		Done
	}

	private static float sinceLastRoleResync;

	private static float sinceLastTimerSync;

	private static bool localSeekerLocked;

	private static float _winCheckGraceUntil;

	private static float _huntStartedAt;

	private static int lastTickFrame;

	private static int _cachedProximityBars;

	private static bool _cachedHnSActive;

	private static bool _cachedGameRunning;

	private static bool _cachedLocalAlive;

	private static bool _cachedLocalIsSeeker;

	private static bool _cachedLocalInVent;

	private static float _cachedVentScreenX;

	private static float _cachedVentScreenY;

	private static bool _cachedVentScreenValid;

	private static bool _firstSyncReceived;

	internal static Sprite KillBannerIcon;

	private static bool _cachedAdminMapOpen;

	private static readonly List<AdminMapDot> _cachedAdminDots;

	private static bool _cachedNonHostHnSLobby;

	internal static Animator HnSAnimator;

	private static bool _showHnSIntro;

	private static bool _introSceneSetupDone;

	private static bool _introCutsceneEverSeen;

	private static IntroCutscene _introCutsceneRef;

	private static string _introPlayerName;

	private static string _introRoleText;

	private static bool _introSeekerResolved;

	private static float _introAutoHideAt;

	private static float _introStuckDeadline;

	private static bool _screamPlayed;

	private static bool _transformSoundPlayed;

	private static float _escapeStartRealtime;

	private static float _worldMorphUntil;

	private static bool _morphRestorePending;

	private static bool _worldMorphFired;

	private static float _groundMorphReplayAt;

	private static readonly List<Transform> _groundMorphHatRoots;

	private static float _groundHatRevealAt;

	private static float _groundMorphStartAt;

	private static readonly List<PlayerPhysics> _morphedPhysics;

	private static readonly List<AnimationClip> _morphPrevSpawn;

	private static GameObject _seekerLockMorph;

	internal static Sprite IntroCard01Sprite;

	internal static Sprite IntroCard02Sprite;

	internal static Sprite IntroCard03Sprite;

	private static VentButton _cachedVentButton;

	internal static int CachedAliveCrewCount;

	private static readonly GameObject[] _pingGOs;

	private static readonly HnSPingBehaviour[] _pingBehaviours;

	private static Sprite _pingSprite;

	private static float _pingVisibleUntil;

	private static float _nextPingAt;

	private static float _crewDotNotifyUntil;

	private static bool _cachedInFinalHunt;

	private static bool _prevInFinalHunt;

	private static float _finalHuntFlashUntil;

	internal static HnSThemeSettings ThemeSettings;

	private static HnSMusicManager _musicManager;

	private static HnSDangerLevel _dangerLevel;

	private static bool _musicInitialized;

	private static bool _beepCoroutineRunning;

	private static int _lastBeepSecond;

	private static readonly List<string> _ovStrBuf;

	private static readonly List<float> _ovFloatBuf;

	private static readonly List<Vector2> _ovPtsBuf;

	private static readonly List<Color> _ovColBuf;

	private static readonly List<Color> _admScratchColors;

	private static float _seekerLockMorphHatAt;

	private static float _morphHoldReplayAt;

	private static bool _morphHoldLatched;

	private static int _lastSeenCompletedTasks;

	private static int _lastSyncedEscape;

	private static int _lastSyncedHunt;

	private static int _lastSyncedFinal;

	private static readonly HashSet<PlayerPhysics> _hatOffsetApplied;

	private static bool lobbySyncedToClients;

	internal static bool DebugForceHnSNextGame;

	private static float _lastTickRealtime;

	private static readonly HnSGameManager _instance;

	private MatchPhase _003CPhase_003Ek__BackingField;

	private bool _003CEnabled_003Ek__BackingField;

	private bool _003CPendingEnabled_003Ek__BackingField;

	private bool _003CSettingsSnapshotDone_003Ek__BackingField;

	private float _003CConfiguredEscapeSeconds_003Ek__BackingField;

	private float _003CConfiguredHuntSeconds_003Ek__BackingField;

	private float _003CConfiguredCrewVentDurationSeconds_003Ek__BackingField;

	private float _003CConfiguredDotIntervalSeconds_003Ek__BackingField;

	private float _003CConfiguredFinalHuntSeconds_003Ek__BackingField;

	private float _003CConfiguredVentCooldownSeconds_003Ek__BackingField;

	private int _003CConfiguredVentAmount_003Ek__BackingField;

	private int _003CLocalVentUsesLeft_003Ek__BackingField;

	private float _003CEscapeRemaining_003Ek__BackingField;

	private float _003CHuntRemaining_003Ek__BackingField;

	private float _003CFinalHuntRemaining_003Ek__BackingField;

	private float _003CTotalHuntSeconds_003Ek__BackingField;

	private bool _003CGameEnded_003Ek__BackingField;

	private bool _003CWaitingForIntro_003Ek__BackingField;

	private bool _003CInFinalHunt_003Ek__BackingField;

	private readonly Dictionary<byte, float> _003CCrewVentEnteredAt_003Ek__BackingField;

	private readonly Dictionary<byte, int> _003CCrewVentCurrentVentId_003Ek__BackingField;

	internal static HnSGameManager Current => null;

	private static HnSGameManager ModeState => null;

	internal static HnSGameManager HnSInstance => null;

	public MatchPhase Phase
	{
		get
		{
			return _003CPhase_003Ek__BackingField;
		}
		set
		{
			_003CPhase_003Ek__BackingField = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _003CEnabled_003Ek__BackingField;
		}
		set
		{
			_003CEnabled_003Ek__BackingField = value;
		}
	}

	public bool PendingEnabled
	{
		get
		{
			return _003CPendingEnabled_003Ek__BackingField;
		}
		set
		{
			_003CPendingEnabled_003Ek__BackingField = value;
		}
	}

	public bool SettingsSnapshotDone
	{
		get
		{
			return _003CSettingsSnapshotDone_003Ek__BackingField;
		}
		set
		{
			_003CSettingsSnapshotDone_003Ek__BackingField = value;
		}
	}

	public float ConfiguredEscapeSeconds
	{
		get
		{
			return _003CConfiguredEscapeSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredEscapeSeconds_003Ek__BackingField = value;
		}
	}

	public float ConfiguredHuntSeconds
	{
		get
		{
			return _003CConfiguredHuntSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredHuntSeconds_003Ek__BackingField = value;
		}
	}

	public float ConfiguredCrewVentDurationSeconds
	{
		get
		{
			return _003CConfiguredCrewVentDurationSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredCrewVentDurationSeconds_003Ek__BackingField = value;
		}
	}

	public float ConfiguredDotIntervalSeconds
	{
		get
		{
			return _003CConfiguredDotIntervalSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredDotIntervalSeconds_003Ek__BackingField = value;
		}
	}

	public float ConfiguredFinalHuntSeconds
	{
		get
		{
			return _003CConfiguredFinalHuntSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredFinalHuntSeconds_003Ek__BackingField = value;
		}
	}

	public float ConfiguredVentCooldownSeconds
	{
		get
		{
			return _003CConfiguredVentCooldownSeconds_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredVentCooldownSeconds_003Ek__BackingField = value;
		}
	}

	public int ConfiguredVentAmount
	{
		get
		{
			return _003CConfiguredVentAmount_003Ek__BackingField;
		}
		set
		{
			_003CConfiguredVentAmount_003Ek__BackingField = value;
		}
	}

	public int LocalVentUsesLeft
	{
		get
		{
			return _003CLocalVentUsesLeft_003Ek__BackingField;
		}
		set
		{
			_003CLocalVentUsesLeft_003Ek__BackingField = value;
		}
	}

	public float EscapeRemaining
	{
		get
		{
			return _003CEscapeRemaining_003Ek__BackingField;
		}
		set
		{
			_003CEscapeRemaining_003Ek__BackingField = value;
		}
	}

	public float HuntRemaining
	{
		get
		{
			return _003CHuntRemaining_003Ek__BackingField;
		}
		set
		{
			_003CHuntRemaining_003Ek__BackingField = value;
		}
	}

	public float FinalHuntRemaining
	{
		get
		{
			return _003CFinalHuntRemaining_003Ek__BackingField;
		}
		set
		{
			_003CFinalHuntRemaining_003Ek__BackingField = value;
		}
	}

	public float TotalHuntSeconds
	{
		get
		{
			return _003CTotalHuntSeconds_003Ek__BackingField;
		}
		set
		{
			_003CTotalHuntSeconds_003Ek__BackingField = value;
		}
	}

	public bool GameEnded
	{
		get
		{
			return _003CGameEnded_003Ek__BackingField;
		}
		set
		{
			_003CGameEnded_003Ek__BackingField = value;
		}
	}

	public bool WaitingForIntro
	{
		get
		{
			return _003CWaitingForIntro_003Ek__BackingField;
		}
		set
		{
			_003CWaitingForIntro_003Ek__BackingField = value;
		}
	}

	public bool InFinalHunt
	{
		set
		{
			_003CInFinalHunt_003Ek__BackingField = value;
		}
	}

	public Dictionary<byte, float> CrewVentEnteredAt => _003CCrewVentEnteredAt_003Ek__BackingField;

	public Dictionary<byte, int> CrewVentCurrentVentId => _003CCrewVentCurrentVentId_003Ek__BackingField;

	private static bool WithinHuntGrace()
	{
		return false;
	}

	internal static void StartMatchIfEnabled()
	{
	}

	private static void DisableEmergencyButtons()
	{
	}

	internal static void StopMatch()
	{
	}

	internal static void Tick(float dt)
	{
	}

	private static void TickBody(float dt)
	{
	}

	internal static void DriveHudOverlay()
	{
	}

	private static void DriveProximityOverlay(HnSHudOverlay ov)
	{
	}

	private static void HideTransientOverlay(HnSHudOverlay ov)
	{
	}

	private static void ClearBuffers()
	{
	}

	private static int ComputeProximityBars(PlayerControl local)
	{
		return 0;
	}

	private static void EnsureUiResourcesLoaded()
	{
	}

	private static void PlaySeekerScream()
	{
	}

	private static void PlaySeekerTransformSound()
	{
	}

	internal static void OnHnSPlayerDeath(PlayerControl victim)
	{
	}

	internal static void ShowHnSIntro()
	{
	}

	internal static void CacheIntroInstance(IntroCutscene intro)
	{
	}

	internal static void PreSetupIntroScene(IntroCutscene intro = null)
	{
	}

	internal static void HideHnSIntro()
	{
	}

	private static void PlaySeekerWorldMorph()
	{
	}

	private static bool HasVisibleHat(PlayerControl pc)
	{
		return false;
	}

	private static void SetupGroundMorphCosmetics(PlayerControl pc, PlayerPhysics phys)
	{
	}

	private static void UpdateGroundMorphHats()
	{
	}

	private static void RestoreMorphedSpawnAnims()
	{
	}

	private static void EnsureSeekerLockMorph(PlayerControl local)
	{
	}

	private static void ApplyHandOffset(Transform hand)
	{
	}

	private static void UpdateSeekerMorphHold()
	{
	}

	private static void DestroySeekerLockMorph()
	{
	}

	private static void SetLayerRecursive(GameObject go, int layer)
	{
	}

	private static void ApplySeekerLocomotionAnims(PlayerPhysics phys)
	{
	}

	private static void EnsureSeekerBodyVisible(PlayerPhysics phys)
	{
	}

	internal static void SetIntroSeekerInfo(string seekerName)
	{
	}

	private static void SetupIntroScene(IntroCutscene intro)
	{
	}

	internal static void CacheVentButton(VentButton vb)
	{
	}

	internal static void ApplyTaskTimeDeduction(uint taskId)
	{
	}

	private static void UpdateTaskCompleteSfx()
	{
	}

	private static void CheckHostWinConditions()
	{
	}

	private static void EndAsSeekerWin()
	{
	}

	private static void EndAsCrewmateWin()
	{
	}

	private static void SetSeekerHatsHidden(bool hidden)
	{
	}

	private static bool IsLongTask(uint taskId)
	{
		return false;
	}

	private static void ApplyRoleRulesToAllPlayers()
	{
	}

	private static void HideLocalTaskArrows()
	{
	}

	private static void StartFinalHuntPhase()
	{
	}

	private static void StartHuntPhase()
	{
	}

	private static float TickOrSnap(float current, int hostValue, ref int lastHostValue, float dt)
	{
		return 0f;
	}

	private static void SyncTimerStateToOptions(bool pushRpc)
	{
	}

	private static void EnforceLocalVentDuration()
	{
	}

	private static void UpdateLocalSeekerHideRestrictions()
	{
	}

	private static void UpdateFinalHuntFullScreenVignette()
	{
	}

	private static void PlayAnimation(string trigger)
	{
	}

	private static void UpdateAdminMapDotCache()
	{
	}

	private static void UpdateAliveCrewCount()
	{
	}

	private static void CloseOpenTaskForFinalHunt()
	{
	}

	private static void UpdateFinalHuntState(float dt)
	{
	}

	private static void ApplySeekerHatOffsets()
	{
	}

	private static void EnsurePingSprite()
	{
	}

	private static void DropPings()
	{
	}

	private static void HideAllPings()
	{
	}

	private static void DestroyAllPings()
	{
	}

	private static void ReleaseLocalSeekerLock()
	{
	}

	private static void InitAudioSystems()
	{
	}

	private static void ShutdownAudioSystems()
	{
	}

	internal static void OnMinigameOpened()
	{
	}

	internal static void OnMinigameClosed()
	{
	}

	private static float PlayerSpeedMod()
	{
		return 0f;
	}

	private static float ConfiguredSeekerSpeed()
	{
		return 0f;
	}

	private static float SeekerSpeedForPhase()
	{
		return 0f;
	}

	private static float GhostPhysicsSpeed()
	{
		return 0f;
	}

	private static float SeekerPhysicsSpeed(float seekerMultiplier)
	{
		return 0f;
	}

	private static void ApplySeekerFinalSpeed()
	{
	}

	private static void UpdateCountdownBeeps()
	{
	}

	private static void PlayKillSting()
	{
	}

	private static void PlayFinalHuntAlertSFX()
	{
	}

	private static void PlayTaskFinishedSFX()
	{
	}

	private static void PlayPingSFX()
	{
	}

	private static void PlayDeathNotificationSFX()
	{
	}

	private static void PlayHiderKillSting()
	{
	}

	internal static void OnGameStartManagerStart(GameStartManager gsm)
	{
	}

	internal static void OnGameStartManagerUpdate(GameStartManager gsm)
	{
	}

	internal static void OnBeforeTryStartGame()
	{
	}

	private static bool IsFreeplayOrTutorial()
	{
		return false;
	}

	internal static void OnShipStatusBegin()
	{
	}

	internal static void OnShipStatusTick(float dt)
	{
	}

	internal static void OnGameEnd()
	{
	}

	internal static bool LocalIsHider()
	{
		return false;
	}

	internal static bool IsFinalHunt()
	{
		return false;
	}

	internal static bool IsHideNSeekActive()
	{
		return false;
	}

	internal static void ArmAndCreateGame(CreateGameOptions createGameOptions)
	{
	}

	private static void ArmHideNSeekMode()
	{
	}

	private static void SyncHnSSettings()
	{
	}

	public void SnapshotFromOptions(GameOptionsData options)
	{
	}

	public void MarkCrewEnteredVent(byte playerId, float time, int ventId)
	{
	}

	public void MarkCrewExitedVent(byte playerId)
	{
	}

	public float GetConfiguredCrewVentDurationSeconds()
	{
		return 0f;
	}

	public float GetConfiguredVentCooldownSeconds()
	{
		return 0f;
	}

	public int GetCrewVentUsesLeft(byte playerId)
	{
		return 0;
	}

	public void ConsumeLocalVentUse()
	{
	}

	public float GetConfiguredEscapeSeconds()
	{
		return 0f;
	}

	public float GetConfiguredHuntSeconds()
	{
		return 0f;
	}

	public bool IsHideNSeekActiveOrSelected()
	{
		return false;
	}

	public void ResetMatch()
	{
	}
}
