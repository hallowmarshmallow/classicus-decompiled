using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class HeliSabotageSystem : MonoBehaviour, ISystemType, ICriticalSabotage, IActivatable
{
	private struct ActiveConsoleData(byte playerId, byte consoleId)
	{
		public readonly byte PlayerId = 0;

		public readonly byte ConsoleId = 0;
	}

	public enum Tags
	{
		DamageBit = 128,
		ActiveBit = 64,
		DeactiveBit = 32,
		FixBit = 16
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public int consoleId;

		internal bool _003CIsConsoleActive_003Eb__0(ActiveConsoleData s)
		{
			return false;
		}
	}

	public const float CountdownStopped = 10000f;

	public const byte TagMask = 240;

	public const byte IdMask = 15;

	public SpriteRenderer Helicopter;

	public AnimationCurve ScaleCurve;

	private const float CharlesDuration = 90f;

	private const float CodeActiveDuration = 10f;

	private const float SyncRate = 1f;

	private HashSet<ActiveConsoleData> ActiveConsoles;

	private HashSet<byte> CompletedConsoles;

	private float codeResetTimer;

	private float syncTimer;

	private bool wasActive;

	private float _003CCountdown_003Ek__BackingField;

	private int _003CTargetCode_003Ek__BackingField;

	private bool _003CIsDirty_003Ek__BackingField;

	public float Countdown
	{
		get
		{
			return _003CCountdown_003Ek__BackingField;
		}
		private set
		{
			_003CCountdown_003Ek__BackingField = value;
		}
	}

	public bool IsActive => false;

	public float PercentActive => 0f;

	public int TargetCode
	{
		get
		{
			return _003CTargetCode_003Ek__BackingField;
		}
		private set
		{
			_003CTargetCode_003Ek__BackingField = value;
		}
	}

	public bool IsDirty
	{
		get
		{
			return _003CIsDirty_003Ek__BackingField;
		}
		private set
		{
			_003CIsDirty_003Ek__BackingField = value;
		}
	}

	public int UserCount => 0;

	public void ClearSabotage()
	{
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	private void UpdateHeliSize()
	{
	}

	internal bool IsConsoleActive(int consoleId)
	{
		return false;
	}

	internal bool IsConsoleOkay(int consoleId)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
