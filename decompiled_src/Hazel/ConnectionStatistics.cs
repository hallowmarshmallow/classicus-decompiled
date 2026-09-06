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

	public long TotalBytesSent
	{
		get
		{
			throw null;
		}
	}

	public long TotalBytesReceived
	{
		get
		{
			throw null;
		}
	}

	internal void LogUnreliableSend(int dataLength)
	{
		throw null;
	}

	internal void LogPacketSend(int totalLength)
	{
		throw null;
	}

	internal void LogReliableSend(int dataLength)
	{
		throw null;
	}

	internal void LogUnreliableReceive(int dataLength, int totalLength)
	{
		throw null;
	}

	internal void LogReliableReceive(int dataLength, int totalLength)
	{
		throw null;
	}

	internal void LogAcknowledgementReceive(int totalLength)
	{
		throw null;
	}

	internal void LogReliablePacketAcknowledged()
	{
		throw null;
	}

	internal void LogHelloReceive(int totalLength)
	{
		throw null;
	}

	internal void LogMessageResent()
	{
		throw null;
	}

	public ConnectionStatistics()
	{
		throw null;
	}
}
