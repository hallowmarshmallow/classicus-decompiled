using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public sealed class RunnerPowerups : MonoBehaviour
{
	public enum ShieldHit : byte
	{
		None,
		Blocked,
		Grace
	}

	private sealed class _003CCoRespawnRevivedLocal_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Cdeadline_003E5__2;

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

		public _003CCoRespawnRevivedLocal_003Ed__82(int _003C_003E1__state)
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

	private const byte SpawnRpc = 84;

	private const byte CollectRequestRpc = 85;

	private const byte ApplyRpc = 86;

	private const byte ShieldBlockRpc = 87;

	private const float MinSpawnInterval = 20f;

	private const float MaxSpawnInterval = 28f;

	private const float PickupLifetime = 60f;

	private static readonly float[] SpawnClearanceLadder;

	private const float MaxNavSnapDistance = 0.75f;

	private const int SpawnAttemptsPerRoom = 24;

	private const float RoomEdgeInset = 0.5f;

	private const float FreezeSeconds = 5f;

	private const float SpeedSeconds = 3f;

	private const float SpeedMultiplier = 3f;

	private const float SpeedStackStep = 0.5f;

	private const int MaxSpeedStacks = 3;

	private const float MaxSpeedSeconds = 15f;

	private const float FreezeRadius = 6f;

	private const int MaxShieldStacks = 5;

	private static readonly Color ReviveColor;

	private static readonly Color FreezeColor;

	private static readonly Color SpeedColor;

	private static readonly Color ShieldColor;

	internal static RunnerPowerups Instance;

	private readonly Dictionary<byte, RunnerPowerupPickup> _pickups;

	private readonly Dictionary<byte, int> _shieldedPlayers;

	private readonly List<byte> _expireScan;

	private readonly List<byte> _frozenBots;

	private static readonly List<byte> _frozenBotsRead;

	private readonly Dictionary<byte, float> _speedUntilById;

	private byte _nextPickupId;

	private bool _ultimateFilled;

	private readonly List<byte> _freePickupIds;

	private float _nextSpawnAt;

	private bool _running;

	private int _roomCursor;

	private readonly List<ShipRoom> _roomScratch;

	private const string SpawnPointRootName = "powerupplace";

	private const float MinSpawnSeparation = 1.5f;

	private readonly List<Vector2> _authoredSpawns;

	private ShipStatus _authoredFrom;

	private readonly List<Vector2> _freeSpawnScratch;

	private static RunnerSpawnPoints _baked;

	private static bool _bakedLoaded;

	private bool _speedActive;

	private float _speedUntil;

	private float _baseSpeed;

	private int _speedStacks;

	private const float ShieldBreakGrace = 2f;

	private readonly Dictionary<byte, float> _shieldGraceUntil;

	private static AudioClip _shieldBreakClip;

	private static bool _shieldBreakLoaded;

	private const int OutlineNone = 0;

	private const int OutlineShield = 1;

	private const int OutlineSpeed = 2;

	private readonly Dictionary<byte, int> _outlineState;

	private readonly List<byte> _outlineScan;

	private static readonly Dictionary<RunnerPowerupType, Sprite> _spriteCache;

	private const float PickupWorldSize = 0.9f;

	private const float IconWorldSize = 0.42f;

	private static readonly Dictionary<RunnerPowerupType, Sprite> _iconCache;

	public static int LocalShieldCharges
	{
		get
		{
			throw null;
		}
	}

	public static float SpeedFadeSeconds
	{
		get
		{
			throw null;
		}
	}

	public static float LocalSpeedRemaining
	{
		get
		{
			throw null;
		}
	}

	public static int MaxShieldCharges
	{
		get
		{
			throw null;
		}
	}

	public static int ShieldCharges(byte playerId)
	{
		throw null;
	}

	public static bool HasSpeedBoost(byte playerId)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private static bool IsRunnerGameRunning()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static float RollSpawnInterval()
	{
		throw null;
	}

	private void Teardown()
	{
		throw null;
	}

	private bool TryTakePickupId(out byte id)
	{
		throw null;
	}

	private void ReleasePickupId(byte id)
	{
		throw null;
	}

	private void BuildFreeAuthoredSpawns()
	{
		throw null;
	}

	private void FillUltimateSpeedOrbs()
	{
		throw null;
	}

	private void TryRollSpawns()
	{
		throw null;
	}

	private void RollSpawn(RunnerPowerupType type, int chancePercent)
	{
		throw null;
	}

	private void EnsureAuthoredSpawns()
	{
		throw null;
	}

	private bool TryGetAuthoredSpawnPoint(out Vector2 pos)
	{
		throw null;
	}

	private static Transform FindDeep(Transform t, string name)
	{
		throw null;
	}

	private bool TryGetRoomSpawnPoint(out Vector2 pos)
	{
		throw null;
	}

	private static bool TryGetOpenNavPoint(out Vector2 pos)
	{
		throw null;
	}

	private void HostExpireStalePickups()
	{
		throw null;
	}

	private void BroadcastSpawn(byte id, RunnerPowerupType type, Vector2 pos)
	{
		throw null;
	}

	public static void HandlePowerupSpawn(MessageReader reader)
	{
		throw null;
	}

	private void SpawnPickup(byte id, RunnerPowerupType type, Vector2 pos)
	{
		throw null;
	}

	public void RequestCollect(byte pickupId)
	{
		throw null;
	}

	public static void HandleCollectRequest(MessageReader reader, PlayerControl requester)
	{
		throw null;
	}

	private void ProcessCollect(byte pickupId, PlayerControl requester)
	{
		throw null;
	}

	private static IEnumerator CoRespawnRevivedLocal()
	{
		throw null;
	}

	private static void TeleportToSpawn(PlayerControl target)
	{
		throw null;
	}

	private static PlayerControl FindRandomDeadPlayer()
	{
		throw null;
	}

	private void BroadcastApply(byte pickupId, RunnerPowerupType type, byte collectorId, byte extra, List<byte> frozenBots = null)
	{
		throw null;
	}

	public static void HandlePowerupApply(MessageReader reader)
	{
		throw null;
	}

	private void ExecuteApply(byte pickupId, RunnerPowerupType type, byte collectorId, byte extra, List<byte> frozenBots = null)
	{
		throw null;
	}

	public ShieldHit TryConsumeShield(byte playerId)
	{
		throw null;
	}

	public void BroadcastShieldBlock(byte playerId)
	{
		throw null;
	}

	public static void HandleShieldBlock(MessageReader reader)
	{
		throw null;
	}

	private void ExecuteShieldBlock(byte playerId)
	{
		throw null;
	}

	private static AudioClip ShieldBreakClip()
	{
		throw null;
	}

	private void UpdatePowerupOutlines()
	{
		throw null;
	}

	private void ApplyOutline(PlayerControl pc, int wanted)
	{
		throw null;
	}

	private void ClearAllOutlines()
	{
		throw null;
	}

	private float StackedSpeedUntil(byte playerId)
	{
		throw null;
	}

	private void BeginLocalSpeedBoost()
	{
		throw null;
	}

	private void ApplyLocalSpeedExpiry()
	{
		throw null;
	}

	private void RestoreSpeedImmediate()
	{
		throw null;
	}

	public static Color ColorFor(RunnerPowerupType type)
	{
		throw null;
	}

	public static void CollectActivePickups(List<RunnerPowerupPickup> into)
	{
		throw null;
	}

	private static string Loc(StringNames id, string fallback, object[] parts)
	{
		throw null;
	}

	private static string CleanName(string stored)
	{
		throw null;
	}

	private static void ShowFloatingText(PlayerControl pc, string message, Color color)
	{
		throw null;
	}

	private static Sprite GetIconSprite(RunnerPowerupType type)
	{
		throw null;
	}

	private static Sprite GetPlaceholderSprite(RunnerPowerupType type)
	{
		throw null;
	}

	private static Color GetTypeColor(RunnerPowerupType type)
	{
		throw null;
	}

	public RunnerPowerups()
	{
		throw null;
	}

	static RunnerPowerups()
	{
		throw null;
	}
}
