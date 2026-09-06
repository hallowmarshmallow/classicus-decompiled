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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003Cget_IsActive_003Eb__5_0(OpenableDoor b)
		{
			throw null;
		}
	}

	private OpenableDoor[] doors;

	private uint dirtyBits;

	private readonly Dictionary<SystemTypes, float> timers;

	private static readonly List<SystemTypes> timerKeysScratch;

	public bool IsActive
	{
		get
		{
			throw null;
		}
	}

	public bool AnySabotagedDoorsClosed
	{
		get
		{
			throw null;
		}
	}

	public void SetDoors(OpenableDoor[] doors)
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

	public void CloseDoorsOfType(SystemTypes room)
	{
		throw null;
	}

	public float GetTimer(SystemTypes room)
	{
		throw null;
	}

	public DoorsSystemType()
	{
		throw null;
	}

	static DoorsSystemType()
	{
		throw null;
	}
}
