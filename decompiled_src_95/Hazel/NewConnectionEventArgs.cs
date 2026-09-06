namespace Hazel;

public struct NewConnectionEventArgs(MessageReader handshakeData, Connection connection)
{
	public readonly MessageReader HandshakeData = null;

	public readonly Connection Connection = null;
}
