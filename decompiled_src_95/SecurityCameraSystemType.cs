using System.Collections.Generic;
using Hazel;

public class SecurityCameraSystemType : ISystemType
{
	private HashSet<byte> PlayersUsing;

	public bool InUse => false;

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	private void UpdateCameras()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
