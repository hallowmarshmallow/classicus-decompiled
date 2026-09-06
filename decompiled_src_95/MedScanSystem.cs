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

		internal bool _003CPruneInvalidUsers_003Eb__10_0(byte id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public byte playerId;

		internal bool _003CRepairDamage_003Eb__0(byte v)
		{
			return false;
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
			return _003CCurrentUser_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentUser_003Ek__BackingField = value;
		}
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	private void PruneInvalidUsers()
	{
	}

	public bool RefreshCurrentUser()
	{
		return false;
	}

	public bool IsQueued(byte playerId)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte data)
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
