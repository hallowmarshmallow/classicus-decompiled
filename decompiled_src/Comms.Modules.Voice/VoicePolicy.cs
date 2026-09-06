namespace Comms.Modules.Voice;

public sealed class VoicePolicy
{
	private readonly VoiceSettings _settings;

	private readonly VoiceCapabilityRegistry _capabilities;

	private static bool IsMeetingActive
	{
		get
		{
			throw null;
		}
	}

	private VoiceMode EffectiveMode
	{
		get
		{
			throw null;
		}
	}

	public VoicePolicy(VoiceSettings settings, VoiceCapabilityRegistry capabilities)
	{
		throw null;
	}

	public bool CanTransmitNow()
	{
		throw null;
	}

	public string GetTransmitBlockReason()
	{
		throw null;
	}

	public bool CanReceiveFrame(uint senderNetId)
	{
		throw null;
	}

	public string GetReceiveBlockReason(uint senderNetId)
	{
		throw null;
	}
}
