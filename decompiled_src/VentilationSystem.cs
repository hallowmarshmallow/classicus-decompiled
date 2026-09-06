using Hazel;

public class VentilationSystem : ISystemType
{
	public enum Operation
	{
		StartCleaning,
		StopCleaning,
		Enter,
		Exit,
		Move,
		BootImpostors
	}

	public static void Update(Operation op, int ventId)
	{
		throw null;
	}

	public bool IsImpostorInsideVent(int ventId)
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

	public VentilationSystem()
	{
		throw null;
	}
}
