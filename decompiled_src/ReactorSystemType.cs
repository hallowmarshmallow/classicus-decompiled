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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CDetoriorate_003Eb__19_0(ShipRoom r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int consoleId;

		public _003C_003Ec__DisplayClass17_0()
		{
			throw null;
		}

		internal bool _003CGetConsoleComplete_003Eb__0(Tuple<byte, byte> kvp)
		{
			throw null;
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

	public int UserCount
	{
		get
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

	public ReactorSystemType(float duration)
	{
		throw null;
	}

	public bool GetConsoleComplete(int consoleId)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte opCode)
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
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
