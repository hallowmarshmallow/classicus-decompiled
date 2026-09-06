using System;

namespace Hazel;

public abstract class NetworkConnection : Connection
{
	public Func<HazelInternalErrors, MessageWriter> OnInternalDisconnect;

	private readonly float _003CAveragePingMs_003Ek__BackingField;

	public virtual float AveragePingMs
	{
		get
		{
			throw null;
		}
	}

	protected abstract bool SendDisconnect(MessageWriter writer);

	protected void DisconnectRemote(string reason, MessageReader reader)
	{
		throw null;
	}

	internal void DisconnectInternal(HazelInternalErrors error, string reason)
	{
		throw null;
	}

	public override void Disconnect(string reason, MessageWriter writer = null)
	{
		throw null;
	}

	protected NetworkConnection()
	{
		throw null;
	}
}
