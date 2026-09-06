using System;
using System.Collections.Generic;
using Hazel;

public class MedScanSystem : ISystemType
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<byte> _003C_003E9__10_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CPruneInvalidUsers_003Eb__10_0(byte id)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public byte playerId;

		public _003C_003Ec__DisplayClass14_0()
		{
			throw null;
		}

		internal bool _003CRepairDamage_003Eb__0(byte v)
		{
			throw null;
		}
	}

	public const byte Request = 128;

	public const byte Release = 64;

	public const byte NumMask = 31;

	public const byte NoPlayer = byte.MaxValue;

	public List<byte> UsersList;

	private byte _003CCurrentUser_003Ek__BackingField;

	public byte CurrentUser
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

	private void PruneInvalidUsers()
	{
		throw null;
	}

	public bool RefreshCurrentUser()
	{
		throw null;
	}

	public bool IsQueued(byte playerId)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte data)
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

	public MedScanSystem()
	{
		throw null;
	}
}
