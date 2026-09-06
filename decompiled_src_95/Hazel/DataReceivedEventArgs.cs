namespace Hazel;

public struct DataReceivedEventArgs(Connection sender, MessageReader msg, SendOption sendOption)
{
	public readonly Connection Sender = null;

	public readonly MessageReader Message = null;

	public readonly SendOption SendOption = default(SendOption);
}
