using System;
using System.Collections.Generic;
using Hazel;

public class ReactorSystemType : ISystemType, IActivatable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ShipRoom, bool> _003C_003E9__19_0;

		internal bool _003CDetoriorate_003Eb__19_0(ShipRoom r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int consoleId;

		internal bool _003CGetConsoleComplete_003Eb__0(Tuple<byte, byte> kvp)
		{
			return false;
		}
	}

	private const float SyncRate = 2f;

	private float timer;

	public const byte StartCountdown = 128;

	public const byte AddUserOp = 64;

	public const byte RemoveUserOp = 32;

	public const byte ClearCountdown = 16;

	public const float CountdownStopped = 10000f;

	public readonly float ReactorDuration;

	public const byte ConsoleIdMask = 3;

	public const byte RequiredUserCount = 2;

	public float Countdown;

	private HashSet<Tuple<byte, byte>> UserConsolePairs;

	public int UserCount => 0;

	public bool IsActive => false;

	public ReactorSystemType(float duration)
	{
	}

	public bool GetConsoleComplete(int consoleId)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte opCode)
	{
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
