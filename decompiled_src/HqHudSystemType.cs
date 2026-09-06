using System;
using System.Collections.Generic;
using Hazel;

internal class HqHudSystemType : ISystemType, IActivatable
{
	public enum Tags
	{
		DamageBit = 128,
		ActiveBit = 64,
		DeactiveBit = 32,
		FixBit = 16
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public int consoleId;

		public _003C_003Ec__DisplayClass16_0()
		{
			throw null;
		}

		internal bool _003CIsConsoleActive_003Eb__0(Tuple<byte, byte> s)
		{
			throw null;
		}
	}

	public const byte TagMask = 240;

	public const byte IdMask = 15;

	private HashSet<Tuple<byte, byte>> ActiveConsoles;

	private HashSet<byte> CompletedConsoles;

	private const float ActiveTime = 10f;

	private float Timer;

	public int TargetNumber;

	public bool IsActive
	{
		get
		{
			throw null;
		}
	}

	public float NumComplete
	{
		get
		{
			throw null;
		}
	}

	public float PercentActive
	{
		get
		{
			throw null;
		}
	}

	public HqHudSystemType()
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	internal bool IsConsoleActive(int consoleId)
	{
		throw null;
	}

	internal bool IsConsoleOkay(int consoleId)
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
}
