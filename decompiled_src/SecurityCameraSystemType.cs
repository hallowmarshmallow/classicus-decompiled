using System.Collections.Generic;
using Hazel;

public class SecurityCameraSystemType : ISystemType
{
	private HashSet<byte> PlayersUsing;

	public bool InUse
	{
		get
		{
			throw null;
		}
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
		throw null;
	}

	private void UpdateCameras()
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

	public SecurityCameraSystemType()
	{
		throw null;
	}
}
