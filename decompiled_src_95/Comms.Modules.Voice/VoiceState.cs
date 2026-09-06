namespace Comms.Modules.Voice;

public struct VoiceState(uint playerNetId, ushort protocolVersion, VoiceFeatureFlags featureFlags, bool accepted, VoiceMode mode)
{
	private readonly uint _003CPlayerNetId_003Ek__BackingField = 0u;

	private readonly ushort _003CProtocolVersion_003Ek__BackingField = 0;

	private readonly VoiceFeatureFlags _003CFeatureFlags_003Ek__BackingField = default(VoiceFeatureFlags);

	private readonly bool _003CAccepted_003Ek__BackingField = false;

	private readonly VoiceMode _003CMode_003Ek__BackingField = default(VoiceMode);

	public uint PlayerNetId => _003CPlayerNetId_003Ek__BackingField;

	public ushort ProtocolVersion => _003CProtocolVersion_003Ek__BackingField;

	public VoiceFeatureFlags FeatureFlags => _003CFeatureFlags_003Ek__BackingField;

	public bool Accepted => _003CAccepted_003Ek__BackingField;

	public VoiceMode Mode => _003CMode_003Ek__BackingField;
}
