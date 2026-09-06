using System.Collections.Generic;
using Hazel;

public class SubmarineOxygenSystem : ISystemType, IActivatable
{
	public readonly float duration;

	public float countdown;

	public float dirtyTimer;

	public bool doKillCheck;

	public bool doKillCheckSerialized;

	public HashSet<byte> playersWithMask;

	public float recentlyActive;

	private float killCheckGrace;

	private static SubmarineOxygenSystem _003CInstance_003Ek__BackingField;

	private bool _003CIsDirty_003Ek__BackingField;

	public static SubmarineOxygenSystem Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	public bool IsActive => false;

	public int RemainingMasks => 0;

	public bool IsDirty
	{
		set
		{
			_003CIsDirty_003Ek__BackingField = value;
		}
	}

	public bool LocalPlayerNeedsMask => false;

	public SubmarineOxygenSystem(float duration)
	{
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void Die(PlayerControl target)
	{
	}
}
