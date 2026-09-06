namespace Comms.Modules.Voice;

public sealed class VoicePolicy
{
	private readonly VoiceSettings _settings;

	private readonly VoiceCapabilityRegistry _capabilities;

	private static bool IsMeetingActive => false;

	private VoiceMode EffectiveMode => default(VoiceMode);

	public VoicePolicy(VoiceSettings settings, VoiceCapabilityRegistry capabilities)
	{
	}

	public bool CanTransmitNow()
	{
		return false;
	}

	public string GetTransmitBlockReason()
	{
		return null;
	}

	public bool CanReceiveFrame(uint senderNetId)
	{
		return false;
	}

	public string GetReceiveBlockReason(uint senderNetId)
	{
		return null;
	}
}
