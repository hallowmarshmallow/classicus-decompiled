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

		internal bool _003CIsConsoleActive_003Eb__0(Tuple<byte, byte> s)
		{
			return false;
		}
	}

	public const byte TagMask = 240;

	public const byte IdMask = 15;

	private HashSet<Tuple<byte, byte>> ActiveConsoles;

	private HashSet<byte> CompletedConsoles;

	private const float ActiveTime = 10f;

	private float Timer;

	public int TargetNumber;

	public bool IsActive => false;

	public float NumComplete => 0f;

	public float PercentActive => 0f;

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	internal bool IsConsoleActive(int consoleId)
	{
		return false;
	}

	internal bool IsConsoleOkay(int consoleId)
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
