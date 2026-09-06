using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Hazel.UPnP;

internal class NetUtility
{
	private static IList<NetworkInterface> GetValidNetworkInterfaces()
	{
		throw null;
	}

	public static ICollection<UnicastIPAddressInformation> GetAddressesFromNetworkInterfaces(AddressFamily addressFamily)
	{
		throw null;
	}

	public static IPAddress GetBroadcastAddress(UnicastIPAddressInformation unicastAddress)
	{
		throw null;
	}
}
