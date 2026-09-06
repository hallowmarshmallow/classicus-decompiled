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

	public float Level => 0f;

	public bool IsActive => false;

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	protected static bool HasTask<T>()
	{
		return false;
	}
}
