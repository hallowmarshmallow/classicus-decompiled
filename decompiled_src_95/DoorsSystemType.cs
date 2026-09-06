using System;
using System.Collections.Generic;
using Hazel;

public class DoorsSystemType : ISystemType, IActivatable, IDoorSystem
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<OpenableDoor, bool> _003C_003E9__5_0;

		internal bool _003Cget_IsActive_003Eb__5_0(OpenableDoor b)
		{
			return false;
		}
	}

	private OpenableDoor[] doors;

	private uint dirtyBits;

	private readonly Dictionary<SystemTypes, float> timers;

	private static readonly List<SystemTypes> timerKeysScratch;

	public bool IsActive => false;

	public bool AnySabotagedDoorsClosed => false;

	public void SetDoors(OpenableDoor[] doors)
	{
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

	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	public float GetTimer(SystemTypes room)
	{
		return 0f;
	}
}
