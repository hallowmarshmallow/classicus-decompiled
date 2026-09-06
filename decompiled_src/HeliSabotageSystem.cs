using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class HeliSabotageSystem : MonoBehaviour, ISystemType, ICriticalSabotage, IActivatable
{
	private struct ActiveConsoleData
	{
		public readonly byte PlayerId;

		public readonly byte ConsoleId;

		public ActiveConsoleData(byte playerId, byte consoleId)
		{
			throw null;
		}
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

		public _003C_003Ec__DisplayClass37_0()
		{
			throw null;
		}

		internal bool _003CIsConsoleActive_003Eb__0(ActiveConsoleData s)
		{
			throw null;
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool IsActive
	{
		get
		{
			throw null;
		}
	}

	public float PercentActive
	{
		get
		{
			throw null;
		}
	}

	public int TargetCode
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

	public bool IsDirty
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

	public int UserCount
	{
		get
		{
			throw null;
		}
	}

	public HeliSabotageSystem()
	{
		throw null;
	}

	public void ClearSabotage()
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	private void UpdateHeliSize()
	{
		throw null;
	}

	internal bool IsConsoleActive(int consoleId)
	{
		throw null;
	}

	internal bool IsConsoleOkay(int consoleId)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
		throw null;
	}

	public void MarkClean()
	{
		throw null;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}
}
