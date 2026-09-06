using System;

namespace Hazel;

public class DisconnectedEventArgs : EventArgs
{
	public readonly string Reason;

	public readonly MessageReader Message;

	public DisconnectedEventArgs(string reason, MessageReader message)
	{
		throw null;
	}
}
