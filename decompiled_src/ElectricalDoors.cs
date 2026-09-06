using System;
using Hazel;
using UnityEngine;

public class ElectricalDoors : MonoBehaviour, ISystemType
{
	[Serializable]
	public class DoorSet
	{
		public string Name;

		public StaticDoor[] Doors;

		public override string ToString()
		{
			throw null;
		}

		public DoorSet()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public DoorSet room;

		public _003C_003Ec__DisplayClass8_0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public StaticDoor door;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		public _003C_003Ec__DisplayClass8_1()
		{
			throw null;
		}

		internal bool _003CInitialize_003Eb__0(DoorSet r)
		{
			throw null;
		}
	}

	public StaticDoor[] Doors;

	public DoorSet[] Rooms;

	public DoorSet LeftExits;

	private bool _003CIsDirty_003Ek__BackingField;

	public bool IsDirty
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

	public void Initialize()
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

	public void MarkClean()
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

	public ElectricalDoors()
	{
		throw null;
	}
}
