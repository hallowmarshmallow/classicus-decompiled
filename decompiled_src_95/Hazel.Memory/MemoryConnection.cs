namespace Hazel.Memory;

public class MemoryConnection : NetworkConnection
{
	private MemoryConnection peer;

	private bool disposed;

	public MemoryConnection Peer => null;

	public void SetPeer(MemoryConnection other)
	{
	}

	public override SendErrors Send(MessageWriter msg)
	{
		return default(SendErrors);
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
	}

	protected override bool SendDisconnect(MessageWriter writer)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
