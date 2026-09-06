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
	}

	public bool IsImpostorInsideVent(int ventId)
	{
		return false;
	}

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
}
