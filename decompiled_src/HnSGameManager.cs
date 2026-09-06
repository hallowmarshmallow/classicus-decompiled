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

	internal static HnSGameManager Current
	{
		get
		{
			throw null;
		}
	}

	private static HnSGameManager ModeState
	{
		get
		{
			throw null;
		}
	}

	internal static HnSGameManager HnSInstance
	{
		get
		{
			throw null;
		}
	}

	public MatchPhase Phase
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

	public bool Enabled
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

	public bool PendingEnabled
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

	public bool SettingsSnapshotDone
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

	public float ConfiguredEscapeSeconds
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

	public float ConfiguredHuntSeconds
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

	public float ConfiguredCrewVentDurationSeconds
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

	public float ConfiguredDotIntervalSeconds
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

	public float ConfiguredFinalHuntSeconds
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

	public float ConfiguredVentCooldownSeconds
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

	public int ConfiguredVentAmount
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

	public int LocalVentUsesLeft
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

	public float EscapeRemaining
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

	public float HuntRemaining
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

	public float FinalHuntRemaining
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

	public float TotalHuntSeconds
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

	public bool GameEnded
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

	public bool WaitingForIntro
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

	public bool InFinalHunt
	{
		set
		{
			throw null;
		}
	}

	public Dictionary<byte, float> CrewVentEnteredAt
	{
		get
		{
			throw null;
		}
	}

	public Dictionary<byte, int> CrewVentCurrentVentId
	{
		get
		{
			throw null;
		}
	}

	private static bool WithinHuntGrace()
	{
		throw null;
	}

	internal static void StartMatchIfEnabled()
	{
		throw null;
	}

	private static void DisableEmergencyButtons()
	{
		throw null;
	}

	internal static void StopMatch()
	{
		throw null;
	}

	internal static void Tick(float dt)
	{
		throw null;
	}

	private static void TickBody(float dt)
	{
		throw null;
	}

	internal static void DriveHudOverlay()
	{
		throw null;
	}

	private static void DriveProximityOverlay(HnSHudOverlay ov)
	{
		throw null;
	}

	private static void HideTransientOverlay(HnSHudOverlay ov)
	{
		throw null;
	}

	private static void ClearBuffers()
	{
		throw null;
	}

	private static int ComputeProximityBars(PlayerControl local)
	{
		throw null;
	}

	private static void EnsureUiResourcesLoaded()
	{
		throw null;
	}

	private static void PlaySeekerScream()
	{
		throw null;
	}

	private static void PlaySeekerTransformSound()
	{
		throw null;
	}

	internal static void OnHnSPlayerDeath(PlayerControl victim)
	{
		throw null;
	}

	internal static void ShowHnSIntro()
	{
		throw null;
	}

	internal static void CacheIntroInstance(IntroCutscene intro)
	{
		throw null;
	}

	internal static void PreSetupIntroScene(IntroCutscene intro = null)
	{
		throw null;
	}

	internal static void HideHnSIntro()
	{
		throw null;
	}

	private static void PlaySeekerWorldMorph()
	{
		throw null;
	}

	private static bool HasVisibleHat(PlayerControl pc)
	{
		throw null;
	}

	private static void SetupGroundMorphCosmetics(PlayerControl pc, PlayerPhysics phys)
	{
		throw null;
	}

	private static void UpdateGroundMorphHats()
	{
		throw null;
	}

	private static void RestoreMorphedSpawnAnims()
	{
		throw null;
	}

	private static void EnsureSeekerLockMorph(PlayerControl local)
	{
		throw null;
	}

	private static void ApplyHandOffset(Transform hand)
	{
		throw null;
	}

	private static void UpdateSeekerMorphHold()
	{
		throw null;
	}

	private static void DestroySeekerLockMorph()
	{
		throw null;
	}

	private static void SetLayerRecursive(GameObject go, int layer)
	{
		throw null;
	}

	private static void ApplySeekerLocomotionAnims(PlayerPhysics phys)
	{
		throw null;
	}

	private static void EnsureSeekerBodyVisible(PlayerPhysics phys)
	{
		throw null;
	}

	internal static void SetIntroSeekerInfo(string seekerName)
	{
		throw null;
	}

	private static void SetupIntroScene(IntroCutscene intro)
	{
		throw null;
	}

	internal static void CacheVentButton(VentButton vb)
	{
		throw null;
	}

	internal static void ApplyTaskTimeDeduction(uint taskId)
	{
		throw null;
	}

	private static void UpdateTaskCompleteSfx()
	{
		throw null;
	}

	private static void CheckHostWinConditions()
	{
		throw null;
	}

	private static void EndAsSeekerWin()
	{
		throw null;
	}

	private static void EndAsCrewmateWin()
	{
		throw null;
	}

	private static void SetSeekerHatsHidden(bool hidden)
	{
		throw null;
	}

	private static bool IsLongTask(uint taskId)
	{
		throw null;
	}

	private static void ApplyRoleRulesToAllPlayers()
	{
		throw null;
	}

	private static void StartFinalHuntPhase()
	{
		throw null;
	}

	private static void StartHuntPhase()
	{
		throw null;
	}

	private static float TickOrSnap(float current, int hostValue, ref int lastHostValue, float dt)
	{
		throw null;
	}

	private static void SyncTimerStateToOptions(bool pushRpc)
	{
		throw null;
	}

	private static void EnforceLocalVentDuration()
	{
		throw null;
	}

	private static void UpdateLocalSeekerHideRestrictions()
	{
		throw null;
	}

	private static void UpdateFinalHuntFullScreenVignette()
	{
		throw null;
	}

	private static void PlayAnimation(string trigger)
	{
		throw null;
	}

	private static void UpdateAdminMapDotCache()
	{
		throw null;
	}

	private static void UpdateAliveCrewCount()
	{
		throw null;
	}

	private static void CloseOpenTaskForFinalHunt()
	{
		throw null;
	}

	private static void UpdateFinalHuntState(float dt)
	{
		throw null;
	}

	private static void ApplySeekerHatOffsets()
	{
		throw null;
	}

	private static void EnsurePingSprite()
	{
		throw null;
	}

	private static void DropPings()
	{
		throw null;
	}

	private static void HideAllPings()
	{
		throw null;
	}

	private static void DestroyAllPings()
	{
		throw null;
	}

	private static void ReleaseLocalSeekerLock()
	{
		throw null;
	}

	private static void InitAudioSystems()
	{
		throw null;
	}

	private static void ShutdownAudioSystems()
	{
		throw null;
	}

	internal static void OnMinigameOpened()
	{
		throw null;
	}

	internal static void OnMinigameClosed()
	{
		throw null;
	}

	private static float PlayerSpeedMod()
	{
		throw null;
	}

	private static float ConfiguredSeekerSpeed()
	{
		throw null;
	}

	private static float SeekerSpeedForPhase()
	{
		throw null;
	}

	private static float GhostPhysicsSpeed()
	{
		throw null;
	}

	private static float SeekerPhysicsSpeed(float seekerMultiplier)
	{
		throw null;
	}

	private static void ApplySeekerFinalSpeed()
	{
		throw null;
	}

	private static void UpdateCountdownBeeps()
	{
		throw null;
	}

	private static void PlayKillSting()
	{
		throw null;
	}

	private static void PlayFinalHuntAlertSFX()
	{
		throw null;
	}

	private static void PlayTaskFinishedSFX()
	{
		throw null;
	}

	private static void PlayPingSFX()
	{
		throw null;
	}

	private static void PlayDeathNotificationSFX()
	{
		throw null;
	}

	private static void PlayHiderKillSting()
	{
		throw null;
	}

	internal static void OnGameStartManagerStart(GameStartManager gsm)
	{
		throw null;
	}

	internal static void OnGameStartManagerUpdate(GameStartManager gsm)
	{
		throw null;
	}

	internal static void OnBeforeTryStartGame()
	{
		throw null;
	}

	private static bool IsFreeplayOrTutorial()
	{
		throw null;
	}

	internal static void OnShipStatusBegin()
	{
		throw null;
	}

	internal static void OnShipStatusTick(float dt)
	{
		throw null;
	}

	internal static void OnGameEnd()
	{
		throw null;
	}

	internal static bool LocalIsHider()
	{
		throw null;
	}

	internal static bool IsFinalHunt()
	{
		throw null;
	}

	internal static bool IsHideNSeekActive()
	{
		throw null;
	}

	internal static void ArmAndCreateGame(CreateGameOptions createGameOptions)
	{
		throw null;
	}

	private static void ArmHideNSeekMode()
	{
		throw null;
	}

	private static void SyncHnSSettings()
	{
		throw null;
	}

	public void SnapshotFromOptions(GameOptionsData options)
	{
		throw null;
	}

	public void MarkCrewEnteredVent(byte playerId, float time, int ventId)
	{
		throw null;
	}

	public void MarkCrewExitedVent(byte playerId)
	{
		throw null;
	}

	public float GetConfiguredCrewVentDurationSeconds()
	{
		throw null;
	}

	public float GetConfiguredVentCooldownSeconds()
	{
		throw null;
	}

	public int GetCrewVentUsesLeft(byte playerId)
	{
		throw null;
	}

	public void ConsumeLocalVentUse()
	{
		throw null;
	}

	public float GetConfiguredEscapeSeconds()
	{
		throw null;
	}

	public float GetConfiguredHuntSeconds()
	{
		throw null;
	}

	public bool IsHideNSeekActiveOrSelected()
	{
		throw null;
	}

	public void ResetMatch()
	{
		throw null;
	}

	public HnSGameManager()
	{
		throw null;
	}

	static HnSGameManager()
	{
		throw null;
	}
}
