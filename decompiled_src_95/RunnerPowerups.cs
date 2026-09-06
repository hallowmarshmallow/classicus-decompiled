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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRespawnRevivedLocal_003Ed__82(int _003C_003E1__state)
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

	public static int LocalShieldCharges => 0;

	public static float SpeedFadeSeconds => 0f;

	public static float LocalSpeedRemaining => 0f;

	public static int MaxShieldCharges => 0;

	public static int ShieldCharges(byte playerId)
	{
		return 0;
	}

	public static bool HasSpeedBoost(byte playerId)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private static bool IsRunnerGameRunning()
	{
		return false;
	}

	private void Update()
	{
	}

	private static float RollSpawnInterval()
	{
		return 0f;
	}

	private void Teardown()
	{
	}

	private bool TryTakePickupId(out byte id)
	{
		id = default(byte);
		return false;
	}

	private void ReleasePickupId(byte id)
	{
	}

	private void BuildFreeAuthoredSpawns()
	{
	}

	private void FillUltimateSpeedOrbs()
	{
	}

	private void TryRollSpawns()
	{
	}

	private void RollSpawn(RunnerPowerupType type, int chancePercent)
	{
	}

	private void EnsureAuthoredSpawns()
	{
	}

	private bool TryGetAuthoredSpawnPoint(out Vector2 pos)
	{
		pos = default(Vector2);
		return false;
	}

	private static Transform FindDeep(Transform t, string name)
	{
		return null;
	}

	private bool TryGetRoomSpawnPoint(out Vector2 pos)
	{
		pos = default(Vector2);
		return false;
	}

	private static bool TryGetOpenNavPoint(out Vector2 pos)
	{
		pos = default(Vector2);
		return false;
	}

	private void HostExpireStalePickups()
	{
	}

	private void BroadcastSpawn(byte id, RunnerPowerupType type, Vector2 pos)
	{
	}

	public static void HandlePowerupSpawn(MessageReader reader)
	{
	}

	private void SpawnPickup(byte id, RunnerPowerupType type, Vector2 pos)
	{
	}

	public void RequestCollect(byte pickupId)
	{
	}

	public static void HandleCollectRequest(MessageReader reader, PlayerControl requester)
	{
	}

	private void ProcessCollect(byte pickupId, PlayerControl requester)
	{
	}

	private static IEnumerator CoRespawnRevivedLocal()
	{
		return null;
	}

	private static void TeleportToSpawn(PlayerControl target)
	{
	}

	private static PlayerControl FindRandomDeadPlayer()
	{
		return null;
	}

	private void BroadcastApply(byte pickupId, RunnerPowerupType type, byte collectorId, byte extra, List<byte> frozenBots = null)
	{
	}

	public static void HandlePowerupApply(MessageReader reader)
	{
	}

	private void ExecuteApply(byte pickupId, RunnerPowerupType type, byte collectorId, byte extra, List<byte> frozenBots = null)
	{
	}

	public ShieldHit TryConsumeShield(byte playerId)
	{
		return default(ShieldHit);
	}

	public void BroadcastShieldBlock(byte playerId)
	{
	}

	public static void HandleShieldBlock(MessageReader reader)
	{
	}

	private void ExecuteShieldBlock(byte playerId)
	{
	}

	private static AudioClip ShieldBreakClip()
	{
		return null;
	}

	private void UpdatePowerupOutlines()
	{
	}

	private void ApplyOutline(PlayerControl pc, int wanted)
	{
	}

	private void ClearAllOutlines()
	{
	}

	private float StackedSpeedUntil(byte playerId)
	{
		return 0f;
	}

	private void BeginLocalSpeedBoost()
	{
	}

	private void ApplyLocalSpeedExpiry()
	{
	}

	private void RestoreSpeedImmediate()
	{
	}

	public static Color ColorFor(RunnerPowerupType type)
	{
		return default(Color);
	}

	public static void CollectActivePickups(List<RunnerPowerupPickup> into)
	{
	}

	private static string Loc(StringNames id, string fallback, object[] parts)
	{
		return null;
	}

	private static string CleanName(string stored)
	{
		return null;
	}

	private static void ShowFloatingText(PlayerControl pc, string message, Color color)
	{
	}

	private static Sprite GetIconSprite(RunnerPowerupType type)
	{
		return null;
	}

	private static Sprite GetPlaceholderSprite(RunnerPowerupType type)
	{
		return null;
	}

	private static Color GetTypeColor(RunnerPowerupType type)
	{
		return default(Color);
	}
}
