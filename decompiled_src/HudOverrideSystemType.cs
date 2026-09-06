using Hazel;

internal class HudOverrideSystemType : ISystemType, IActivatable
{
	public const byte DamageBit = 128;

	public const byte TaskMask = 127;

	private bool _003CIsActive_003Ek__BackingField;

	public bool IsActive
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

	public HudOverrideSystemType()
	{
		throw null;
	}
}
