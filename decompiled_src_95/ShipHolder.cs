using Hazel;
using InnerNet;

public class ShipHolder : InnerNetObject
{
	private ShipStatus _003CShip_003Ek__BackingField;

	public ShipStatus Ship
	{
		get
		{
			return _003CShip_003Ek__BackingField;
		}
		private set
		{
			_003CShip_003Ek__BackingField = value;
		}
	}

	public void Update()
	{
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public override void OnDestroy()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public void RpcSetShip(string name)
	{
	}

	public void SetShip(string name)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
