namespace Hazel;

public class ConnectionStatistics
{
	private const int ExpectedMTU = 1200;

	private int packetsSent;

	private int reliablePacketsAcknowledged;

	private int fragmentableMessagesSent;

	private int unreliableMessagesSent;

	private int reliableMessagesSent;

	private int fragmentedMessagesSent;

	private int acknowledgementMessagesSent;

	private int helloMessagesSent;

	private long dataBytesSent;

	private long totalBytesSent;

	private int unreliableMessagesReceived;

	private int reliableMessagesReceived;

	private int fragmentedMessagesReceived;

	private int acknowledgementMessagesReceived;

	private int pingMessagesReceived;

	private int helloMessagesReceived;

	private long dataBytesReceived;

	private long totalBytesReceived;

	private int messagesResent;

	public long TotalBytesSent => 0L;

	public long TotalBytesReceived => 0L;

	internal void LogUnreliableSend(int dataLength)
	{
	}

	internal void LogPacketSend(int totalLength)
	{
	}

	internal void LogReliableSend(int dataLength)
	{
	}

	internal void LogUnreliableReceive(int dataLength, int totalLength)
	{
	}

	internal void LogReliableReceive(int dataLength, int totalLength)
	{
	}

	internal void LogAcknowledgementReceive(int totalLength)
	{
	}

	internal void LogReliablePacketAcknowledged()
	{
	}

	internal void LogHelloReceive(int totalLength)
	{
	}

	internal void LogMessageResent()
	{
	}
}
