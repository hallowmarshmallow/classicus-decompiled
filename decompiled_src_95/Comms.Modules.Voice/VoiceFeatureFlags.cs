namespace Comms.Modules.Voice;

public enum VoiceFeatureFlags : uint
{
	None = 0u,
	SupportsVoice = 1u,
	SupportsPositional = 2u,
	SupportsGhostChannel = 4u,
	SupportsVAD = 8u
}
