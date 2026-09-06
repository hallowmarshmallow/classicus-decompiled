using System.Collections.Generic;
using UnityEngine;

public sealed class RunnerBot : MonoBehaviour
{
	public byte BotId;

	public PlayerControl Player;

	public Rigidbody2D Body;

	public PlayerControl Target;

	public int TrailIndex;

	public float FrozenUntil;

	public float FreezeTint;

	public float NextRetarget;

	public float SpawnedAt;

	public float KillCooldownUntil;

	public Vector2 StuckCheckPos;

	public float StuckCheckAt;

	public Vector2 DetourDir;

	public float DetourUntil;

	public float DirectOkSince;

	public float NoDirectUntil;

	public float DetourSign;

	public float WallSide;

	public float WallSideUntil;

	public Vector2 WallSideAnchor;

	public float TargetBlockedSince;

	public float TargetLockedUntil;

	public readonly Dictionary<byte, float> AvoidTargetUntil;

	public float LastStuckAt;

	public int StuckStreak;

	public bool PathBroken;

	public float NextPathScan;

	public float HoldSince;

	public bool HoldingPath;

	public Vector2 StillAnchor;

	public float StillSince;

	public float DeconWaitSince;

	public Vector2 TargetVelEstimate;

	public Vector2 TargetVelSamplePos;

	public float TargetVelSampleTime;

	public bool Warping;

	public float WarpUntil;

	public int WarpCrumbs;

	public bool Replaying;

	public int ReplayIndex;

	public float ReplayUntil;

	public float ReplayStuckSince;

	public Vector2 ReplayAnchor;

	public byte LastReplayVictim;

	public int LastReplayIndex;

	public Vector2 LastReplayFrom;

	public float ReplayRefuseUntil;

	public Vector2 LocalStep;

	public bool LocalHasStep;

	public float LocalPlanAt;

	public readonly List<Vector2> NavPath;

	public int NavIdx;

	public float NavExpires;

	public Vector2 NavGoal;

	public int NavLink;

	public bool NavLinkReversed;

	public float NextGapPlanAt;

	public bool Traversing;

	public int TravPhase;

	public Vector2 TravFrom;

	public Vector2 TravTo;

	public RunnerBotNav.LinkKind TravKind;

	public float TravWaitUntil;

	public ElevatorTransition TravElevFrom;

	public ElevatorTransition TravElevTo;

	public float LinkCooldownUntil;

	public float NextDiagLogAt;

	public byte KillArmVictim;

	public float KillArmSince;

	public float KillArmLostAt;

	public byte PinnedVictim;

	public float PinnedSince;

	public float PinnedBestDist;

	public Vector2 PinnedAnchor;

	public byte CloseVictim;

	public float CloseBestDist;

	public float CloseNoProgressSince;

	public float CloseSince;

	public float RawDriveUntil;

	public bool HasSync;

	public Vector2 SyncPos;

	public Vector2 SyncVel;

	public float SyncTime;

	public float ImmobileSinceTime;

	public bool IsStaffBot;
}
