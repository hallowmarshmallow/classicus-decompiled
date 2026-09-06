using Hazel;

public class SwitchSystem : ISystemType, IActivatable
{
	public const byte MaxValue = byte.MaxValue;

	public const int NumSwitches = 5;

	public const byte DamageSystem = 128;

	public const byte SwitchesMask = 31;

	public float DetoriorationTime;

	public byte Value;

	private float timer;

	public byte ExpectedSwitches;

	public byte ActualSwitches;

	public float Level
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

	public SwitchSystem()
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
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

	protected static bool HasTask<T>()
	{
		throw null;
	}
}
