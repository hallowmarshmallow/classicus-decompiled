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
			return _003CIsActive_003Ek__BackingField;
		}
		private set
		{
			_003CIsActive_003Ek__BackingField = value;
		}
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
