using System;

namespace Hazel;

public abstract class NetworkConnection : Connection
{
	public Func<HazelInternalErrors, MessageWriter> OnInternalDisconnect;

	private readonly float _003CAveragePingMs_003Ek__BackingField;

	public virtual float AveragePingMs => _003CAveragePingMs_003Ek__BackingField;

	public virtual long OldestUnackedMs => 0L;

	protected abstract bool SendDisconnect(MessageWriter writer);

	protected void DisconnectRemote(string reason, MessageReader reader)
	{
	}

	internal void DisconnectInternal(HazelInternalErrors error, string reason)
	{
	}

	public override void Disconnect(string reason, MessageWriter writer = null)
	{
	}
}
