using System.Collections.Generic;
using Hazel;

public class LifeSuppSystemType : ISystemType, IActivatable
{
	private const float SyncRate = 2f;

	private float timer;

	public const byte StartCountdown = 128;

	public const byte AddUserOp = 64;

	public const byte ClearCountdown = 16;

	public const float CountdownStopped = 10000f;

	public readonly float LifeSuppDuration;

	public const byte ConsoleIdMask = 3;

	public const byte RequiredUserCount = 2;

	public float Countdown;

	private HashSet<int> completedConsoles;

	private bool taskAdded;

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

	public LifeSuppSystemType(float duration)
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
