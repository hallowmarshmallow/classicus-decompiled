using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public sealed class RunnerBotDirector : MonoBehaviour
{
	private sealed class VictimMotion
	{
		public Vector2 LastPos;

		public float LastMoveAt;

		public float MoveSpeed;

		public bool Seeded;
	}

	private sealed class BrokenConsole
	{
		internal SystemConsole Console;

		internal SpriteRenderer Image;

		internal Sprite OriginalSprite;

		internal Collider2D[] Colliders;
	}

	private sealed class _003CCoBakeNav_003Ed__168 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotDirector _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBakeNav_003Ed__168(int _003C_003E1__state)
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

	private sealed class _003CCoRefloodLearnedRoutes_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotDirector _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRefloodLearnedRoutes_003Ed__147(int _003C_003E1__state)
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

	private const byte BotSyncRpc = 82;

	private const byte BotKillRpc = 83;

	private const byte BotIdBase = 128;

	private const byte StaffBotIdBase = 210;

	private const int StaffTierIndex = 0;

	private const float StaleReplicaTimeout = 1.5f;

	private const float SpawnDelayAfterRun = 5f;

	private const float KillCooldown = 2f;

	private const float RetargetInterval = 0.5f;

	private const float ClaimPenalty = 6f;

	private const float UnreachablePenalty = 25f;

	private const float BlacklistPenalty = 40f;

	private const float TargetBlockedGrace = 2f;

	private const float TargetBlacklistTime = 5f;

	private const float TargetDwell = 1.5f;

	private const float SwitchMargin = 2f;

	private const float SwitchFreeze = 0.5f;

	private const float SpawnRevealSeconds = 2f;

	private const float SpawnSfxWindow = 1f;

	private const float DeconPressCooldown = 1.5f;

	private const float DeconGlobalThrottle = 0.25f;

	private const float DeconWaitGrace = 14f;

	private const float SyncInterval = 0.15f;

	private const float CrumbSpacing = 0.3f;

	private const int MaxTrail = 1200;

	private const float WaypointReached = 0.35f;

	private const float BotRadius = 0.22f;

	private const float DetourProbe = 0.9f;

	private const float DetourTime = 0.5f;

	private const float StuckCheckInterval = 0.35f;

	private const float StuckStillDuration = 0.7f;

	private const float StuckMoveThreshold = 0.35f;

	private const float StillWindow = 0.5f;

	private const float CloseRangeRadius = 4f;

	private const float ReplayMaxDuration = 6f;

	private const float ReplaySnapRadius = 3f;

	private const int StuckWarpStreak = 5;

	private const int CurveArcSteps = 6;

	private const float CurveArcDegrees = 15f;

	private static readonly float[] CurveBendDistances;

	private const float LocalCell = 0.15f;

	private const float LocalProbe = 0.2f;

	private const float LocalPad = 0.6f;

	private const int LocalMaxAxis = 48;

	private const float LocalReplanInterval = 0.05f;

	private static readonly int[] TierBotCount;

	private static readonly float[] TierSpeedMult;

	public const float UltimateWaveSeconds = 20f;

	public const int UltimateWaveBots = 2;

	private const int MaxRunnerBots = 82;

	public static float CfgReplanInterval;

	private const float GapPlanRetryInterval = 0.75f;

	private const float CloseProgressEpsilon = 0.05f;

	private const float CloseRawDriveAfter = 0.6f;

	private const float RawDriveHold = 2.5f;

	private const float ReplayRestartMoved = 0.5f;

	private const float ReplayRefuseWindow = 3f;

	private const float CloseLoiterRadius = 1.6f;

	private const float CloseLoiterTime = 1.25f;

	public static float CfgWaypointRadius;

	public static float CfgLadderSpeed;

	public static float CfgPlatformSpeed;

	public static float CfgLinkCooldown;

	public static bool CfgVerboseLogs;

	public static float CfgKillRadius;

	public static float CfgKillGrace;

	public static float CfgLagShieldSecs;

	public static float LungeKillRadius;

	public static float LungeKillGrace;

	public static float KillArmDropGrace;

	internal static RunnerBotDirector Instance;

	private readonly Dictionary<byte, RunnerBot> _bots;

	private readonly Dictionary<byte, List<Vector2>> _trails;

	private readonly Dictionary<byte, Vector2> _lastCrumb;

	private DeconSystem[] _deconSystems;

	private EastDeconSystem[] _eastDecons;

	private readonly Dictionary<EastDeconSystem, float> _eastPressedAt;

	private float _nextDeconUse;

	private OpenDoorConsole[] _doorConsoles;

	private OpenableDoor[] _doorConsoleDoors;

	private readonly Dictionary<OpenDoorConsole, float> _doorPressedAt;

	private ElevatorTransition[] _elevators;

	private readonly Dictionary<ElevatorTransition, float> _elevPressedAt;

	private readonly Dictionary<DeconSystem, float> _deconPressedAt;

	private Vector3[] _spawnInPoints;

	private readonly Dictionary<byte, VictimMotion> _victimMotion;

	private float _lastMotionSampleAt;

	private RunnerBotNav _nav;

	private bool _navBaking;

	private readonly List<Vector2> _scratchPath;

	private int _spawned;

	private float _nextSpawnResolveAt;

	private float _nextSync;

	private AudioClip _spawnSfx;

	private float _lastSpawnSfxAt;

	private ushort _sendSeq;

	private ushort _recvSeq;

	private int _syncSender;

	private float _lastSyncAt;

	private const float SyncResyncGapSeconds = 1f;

	private const float BotImmobileRecoverSeconds = 2.5f;

	private const float BotSyncStaleWarnSeconds = 2f;

	private const float BotSyncStaleWarnCooldown = 5f;

	private float _lastStaleSyncWarnAt;

	private bool _running;

	private bool _emergencyBroken;

	private int _staffBotCount;

	private bool _staffReplicaActive;

	private bool _versionLogged;

	private readonly List<BrokenConsole> _brokenConsoles;

	private const float LearnedRefloodInterval = 1f;

	private float _nextLearnedReflood;

	private Coroutine _learnedRefloodRoutine;

	private const float BotSeparationRadius = 0.5f;

	private const float BotSeparationWeight = 0.6f;

	private const float WallSideHold = 1.5f;

	private const float WallSideProgress = 0.45f;

	private const float TargetLeadTime = 0.25f;

	private const float TargetLeadMaxDist = 1f;

	private readonly List<int> _routeQueue;

	private readonly HashSet<int> _routeVisited;

	private readonly List<int> _routeFirstHop;

	private static readonly Dictionary<int, float> _logBudget;

	private static readonly RaycastHit2D[] CastBuffer;

	private static ContactFilter2D _castFilter;

	private static bool _castFilterReady;

	private const float ContactProbeRadius = 0.05f;

	private const float BodyProbeMargin = 0.014f;

	private static float BodyProbeRadius;

	private static Vector2 BodyOffset;

	private static readonly Collider2D[] ContactOverlap;

	private static readonly Collider2D[] LocalOverlap;

	private static readonly byte[] _lWalk;

	private static readonly int[] _lgCost;

	private static readonly int[] _lParent;

	private static readonly int[] _lStampArr;

	private static int _lStamp;

	private static readonly List<long> _lHeap;

	private static readonly List<int> _lTrace;

	private static readonly int[] _lDX;

	private static readonly int[] _lDY;

	private static Vector2 _lOrigin;

	private static int _lW;

	private static int _lH;

	private const float LocalStepReached = 0.15f;

	private static readonly Dictionary<long, bool> _cellFree;

	private readonly Dictionary<int, bool> _isleReach;

	private const float PinnedKillRadius = 0.95f;

	private const float PinnedWindow = 0.45f;

	private const float PinnedProgress = 0.08f;

	private const float PinnedMaxDrift = 0.3f;

	private bool? _taskAdderWanted;

	private const float RainbowSpeed = 0.1f;

	private const float BotOutlineWidth = 1f;

	private const float FreezeTintFadeSpeed = 3.5f;

	public const float FreezeTintAlpha = 0.6f;

	private static readonly Color BotOutlineColor;

	public static readonly Color FrozenBodyColor;

	public static readonly Color FrozenShadowColor;

	private float _rainbowHue;

	private readonly List<byte> _pruneScratch;

	internal IEnumerable<RunnerBot> ActiveBots => null;

	public bool NavReady => false;

	private static int DesiredBotCount(int tier)
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public bool TryGetRandomNavPoint(out Vector2 world)
	{
		world = default(Vector2);
		return false;
	}

	public bool TrySnapToNavPoint(Vector2 p, out Vector2 world)
	{
		world = default(Vector2);
		return false;
	}

	public bool IsNavSpotClear(Vector2 p, float radius)
	{
		return false;
	}

	public bool IsReachableByPlayers(Vector2 p)
	{
		return false;
	}

	public bool TryFreezeBotsNear(Vector2 center, float radius, float seconds, List<byte> frozenIds)
	{
		return false;
	}

	public static void PlayFreezeVisual(List<byte> botIds, float seconds)
	{
	}

	private static bool IsRunnerGameRunning()
	{
		return false;
	}

	private static bool InActiveGame()
	{
		return false;
	}

	private bool StaffActive()
	{
		return false;
	}

	public static RunnerBotDirector EnsureInstance()
	{
		return null;
	}

	public static RunnerBot SpawnStaffChaser()
	{
		return null;
	}

	private RunnerBot SpawnStaffChaserInternal()
	{
		return null;
	}

	private byte AllocateStaffBotId()
	{
		return 0;
	}

	private Vector2 ChooseStaffSpawnPos()
	{
		return default(Vector2);
	}

	public static int RemoveStaffChasers()
	{
		return 0;
	}

	private int RemoveStaffChasersInternal()
	{
		return 0;
	}

	private void FixedUpdate()
	{
	}

	private void Teardown()
	{
	}

	private void RestoreEmergencyButtons()
	{
	}

	private void BreakEmergencyButtons()
	{
	}

	private void HostTick(bool runner)
	{
	}

	private Vector2 GetBotSpawnPosition(int index)
	{
		return default(Vector2);
	}

	private void TryResolveSpawnInPoints()
	{
	}

	private void RecordTrails()
	{
	}

	private void MaybeRefloodLearnedRoutes()
	{
	}

	private IEnumerator CoRefloodLearnedRoutes()
	{
		return null;
	}

	private List<Vector2> GetTrail(byte playerId)
	{
		return null;
	}

	private void DriveBot(RunnerBot bot, int tier)
	{
	}

	private Vector2 ApplySeparation(RunnerBot self, Vector2 botPos, Vector2 desired)
	{
		return default(Vector2);
	}

	private static Vector2 SteerAroundWalls(Vector2 pos, Vector2 desired, RunnerBot bot = null, float travel = float.MaxValue)
	{
		return default(Vector2);
	}

	private static void CommitWallSide(RunnerBot bot, float side, Vector2 pos)
	{
	}

	private void TryOpenClickDoors(Vector2 botPos)
	{
	}

	private void TryOpenElevatorDoors(Vector2 botPos)
	{
	}

	private bool NearAnyDecon(Vector2 botPos)
	{
		return false;
	}

	private bool IsWaitingOnDecon(RunnerBot bot, Vector2 botPos)
	{
		return false;
	}

	private bool IsNearCyclingDecon(Vector2 botPos)
	{
		return false;
	}

	private void OnBotStuck(RunnerBot bot, Vector2 botPos)
	{
	}

	private static bool NearestDoorIsUpper(SomeKindaDoor upper, SomeKindaDoor lower, Vector2 from, Vector2 fallbackCenter)
	{
		return false;
	}

	private static bool IsBetweenDoors(SomeKindaDoor a, SomeKindaDoor b, Vector2 p)
	{
		return false;
	}

	private void TryUseDeconDoors(RunnerBot bot, Vector2 botPos)
	{
	}

	private static float EastDeconDistance(EastDeconSystem sys, Vector2 from)
	{
		return 0f;
	}

	private static float DeconDistance(DeconSystem sys, Vector2 from)
	{
		return 0f;
	}

	private IEnumerator CoBakeNav()
	{
		return null;
	}

	private void UpdateTargetVelocityEstimate(RunnerBot bot)
	{
	}

	private Vector2 PredictedTargetPos(RunnerBot bot)
	{
		return default(Vector2);
	}

	private bool PlanNavPath(RunnerBot bot, Vector2 botPos, Vector2 targetPos)
	{
		return false;
	}

	private bool FindLinkRoute(int fromIsle, int toIsle, Vector2 botPos, out int linkIndex, out bool reversed)
	{
		linkIndex = default(int);
		reversed = default(bool);
		return false;
	}

	private static float PathLength(Vector2 from, List<Vector2> path)
	{
		return 0f;
	}

	private bool NextNavWaypoint(RunnerBot bot, Vector2 botPos, out Vector2 waypoint)
	{
		waypoint = default(Vector2);
		return false;
	}

	private void TraverseLink(RunnerBot bot, float speed)
	{
	}

	private void FinishTraverse(RunnerBot bot, Vector2 goal)
	{
	}

	private static void BotLog(RunnerBot bot, string message, int callSite = 0)
	{
	}

	private void BeginWarp(RunnerBot bot, Vector2 botPos)
	{
	}

	private void EndWarp(RunnerBot bot)
	{
	}

	private void WarpAlongTrail(RunnerBot bot, Vector2 botPos, float speed)
	{
	}

	private static Vector2 Rotate(Vector2 v, float degrees)
	{
		return default(Vector2);
	}

	private static void EnsureCastFilter()
	{
	}

	private static void SyncBodyModel(PlayerControl pc)
	{
	}

	private static bool StartedInCollider()
	{
		return false;
	}

	private static bool ClearPath(Vector2 from, Vector2 to)
	{
		return false;
	}

	private static bool ContactNormal(Vector2 pos, out Vector2 normal)
	{
		normal = default(Vector2);
		return false;
	}

	private static bool ProbeWall(Vector2 pos, Vector2 dir, float probe, out Vector2 normal)
	{
		normal = default(Vector2);
		return false;
	}

	private bool TryCurvedApproach(Vector2 from, Vector2 to, out Vector2 elbow)
	{
		elbow = default(Vector2);
		return false;
	}

	private bool TryCloseRangePursuit(RunnerBot bot, Vector2 botPos, float speed)
	{
		return false;
	}

	private bool TryLocalApproach(RunnerBot bot, Vector2 from, Vector2 to, out Vector2 step)
	{
		step = default(Vector2);
		return false;
	}

	private static int LocalCellIndex(Vector2 p)
	{
		return 0;
	}

	private static Vector2 LocalCellCenter(int idx)
	{
		return default(Vector2);
	}

	private static bool LocalWalkable(int idx)
	{
		return false;
	}

	private static int LocalNearestFree(int idx)
	{
		return 0;
	}

	private static int LocalHeuristic(int a, int b)
	{
		return 0;
	}

	private static void LocalPush(int index, int fScore)
	{
	}

	private static int LocalPop()
	{
		return 0;
	}

	private void EnterRecovery(RunnerBot bot, Vector2 botPos)
	{
	}

	private void BeginReplay(RunnerBot bot, Vector2 botPos)
	{
	}

	private void EndReplay(RunnerBot bot)
	{
	}

	private void ReplayTick(RunnerBot bot, Vector2 botPos, float speed)
	{
	}

	private static int FindReplayStart(List<Vector2> trail, Vector2 botPos)
	{
		return 0;
	}

	private Vector2 NextTrailWaypoint(RunnerBot bot, Vector2 botPos, Vector2 targetPos, out bool pathBroken, out bool hold)
	{
		pathBroken = default(bool);
		hold = default(bool);
		return default(Vector2);
	}

	private static int FindTrailEntry(List<Vector2> trail, Vector2 botPos)
	{
		return 0;
	}

	private void UpdateVictimMotion()
	{
	}

	private bool VictimFeedFrozen(PlayerControl victim)
	{
		return false;
	}

	private static PlayerControl FindNearestAlive(Vector2 from)
	{
		return null;
	}

	private PlayerControl FindSpreadTarget(RunnerBot self, Vector2 from, int fromIsle)
	{
		return null;
	}

	private float TargetScore(RunnerBot self, Vector2 from, int fromIsle, PlayerControl p)
	{
		return 0f;
	}

	private bool Reachable(int fromIsle, Vector2 to)
	{
		return false;
	}

	private static bool IsTargetBlacklisted(RunnerBot bot, byte playerId)
	{
		return false;
	}

	private void SwitchTarget(RunnerBot bot, PlayerControl next, bool freeze)
	{
	}

	private static PlayerControl FindAliveWithin(Vector2 from, float radius)
	{
		return null;
	}

	private static void ClearPinned(RunnerBot bot)
	{
	}

	private static bool IsPinned(RunnerBot bot, PlayerControl victim, Vector2 botPos, float dist)
	{
		return false;
	}

	private void SyncTaskAdderConsole(bool runnerActive)
	{
	}

	private void TintBots()
	{
	}

	private void SendSync()
	{
	}

	private void BroadcastKill(RunnerBot bot, PlayerControl victim)
	{
	}

	public static void HandleBotSync(MessageReader reader, int senderId)
	{
	}

	public static void HandleBotKill(MessageReader reader)
	{
	}

	private void ExecuteKill(byte botId, byte victimId, Vector2 botPos, float survivalSeconds)
	{
	}

	private RunnerBot CreateBot(byte botId, Vector2 pos)
	{
		return null;
	}

	private void PruneStaleStaffReplicas()
	{
	}

	private void RecoverBotMotion(RunnerBot bot)
	{
	}

	private void ReplicaTick()
	{
	}
}
