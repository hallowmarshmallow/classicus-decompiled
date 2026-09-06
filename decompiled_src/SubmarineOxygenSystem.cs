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
			throw null;
		}
		private set
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

	public int RemainingMasks
	{
		get
		{
			throw null;
		}
	}

	public bool IsDirty
	{
		set
		{
			throw null;
		}
	}

	public bool LocalPlayerNeedsMask
	{
		get
		{
			throw null;
		}
	}

	public SubmarineOxygenSystem(float duration)
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
		throw null;
	}

	public void Die(PlayerControl target)
	{
		throw null;
	}
}
