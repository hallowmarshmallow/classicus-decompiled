namespace Hazel;

public enum HazelInternalErrors
{
	SocketExceptionSend,
	SocketExceptionReceive,
	ReceivedZeroBytes,
	PingsWithoutResponse,
	ReliablePacketWithoutResponse,
	ConnectionDisconnected,
	DtlsNegotiationFailed
}
