namespace Comms.Modules.Voice;

public struct VoiceHello(ushort protocolVersion, VoiceFeatureFlags featureFlags)
{
	private readonly ushort _003CProtocolVersion_003Ek__BackingField = 0;

	private readonly VoiceFeatureFlags _003CFeatureFlags_003Ek__BackingField = default(VoiceFeatureFlags);

	public ushort ProtocolVersion => _003CProtocolVersion_003Ek__BackingField;

	public VoiceFeatureFlags FeatureFlags => _003CFeatureFlags_003Ek__BackingField;
}
