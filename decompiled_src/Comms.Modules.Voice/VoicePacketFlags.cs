namespace Comms.Modules.Voice;

public enum VoicePacketFlags : byte
{
	None = 0,
	Muted = 1,
	RadioEffect = 2,
	ProximityMode = 4,
	GhostChannel = 8,
	TeamChannel = 0x10
}
