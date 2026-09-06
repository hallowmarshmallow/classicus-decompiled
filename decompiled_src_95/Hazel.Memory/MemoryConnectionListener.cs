namespace Hazel.Memory;

public class MemoryConnectionListener : NetworkConnectionListener
{
	private int connectionCount;

	public override void Start()
	{
	}

	public MemoryConnection PrepareConnection()
	{
		return null;
	}

	public void CompleteConnection(MemoryConnection clientSide, byte[] handshakeData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
