namespace Comms.Modules.Voice.Audio;

public sealed class StarTrinityWebRtcApmSuppressorFactory : IVoiceNoiseSuppressorFactory
{
	public string Name => null;

	public bool IsSupported => false;

	public IVoiceNoiseSuppressor Create()
	{
		return null;
	}
}
