namespace Comms.Modules.Voice.Audio;

public sealed class WebRtcRnNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
{
	private readonly StarTrinityWebRtcApmSuppressorFactory _webRtcFactory;

	private readonly RnNoiseSuppressorFactory _rnNoiseFactory;

	public string Name => null;

	public bool IsSupported => false;

	public IVoiceNoiseSuppressor Create()
	{
		return null;
	}
}
