using System.Net;

namespace Hazel;

public abstract class NetworkConnectionListener : ConnectionListener
{
	private IPEndPoint _003CEndPoint_003Ek__BackingField;

	private IPMode _003CIPMode_003Ek__BackingField;

	public IPEndPoint EndPoint
	{
		get
		{
			return _003CEndPoint_003Ek__BackingField;
		}
		protected set
		{
			_003CEndPoint_003Ek__BackingField = value;
		}
	}

	public IPMode IPMode
	{
		get
		{
			return _003CIPMode_003Ek__BackingField;
		}
		protected set
		{
			_003CIPMode_003Ek__BackingField = value;
		}
	}
}
