namespace Hazel;

public struct DataReceivedEventArgs
{
	public readonly Connection Sender;

	public readonly MessageReader Message;

	public readonly SendOption SendOption;

	public DataReceivedEventArgs(Connection sender, MessageReader msg, SendOption sendOption)
	{
		throw null;
	}
}
