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
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public DoorSet room;
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public StaticDoor door;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		internal bool _003CInitialize_003Eb__0(DoorSet r)
		{
			return false;
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
			return _003CIsDirty_003Ek__BackingField;
		}
		private set
		{
			_003CIsDirty_003Ek__BackingField = value;
		}
	}

	public void Initialize()
	{
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
