namespace Hazel.Memory;

public class MemoryConnection : NetworkConnection
{
	private MemoryConnection peer;

	private bool disposed;

	public MemoryConnection Peer
	{
		get
		{
			throw null;
		}
	}

	public MemoryConnection()
	{
		throw null;
	}

	public void SetPeer(MemoryConnection other)
	{
		throw null;
	}

	public override SendErrors Send(MessageWriter msg)
	{
		throw null;
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
		throw null;
	}

	protected override bool SendDisconnect(MessageWriter writer)
	{
		throw null;
	}

	protected override void Dispose(bool disposing)
	{
		throw null;
	}
}
