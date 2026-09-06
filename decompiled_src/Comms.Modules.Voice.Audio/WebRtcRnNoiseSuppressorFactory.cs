namespace Comms.Modules.Voice.Audio;

public sealed class WebRtcRnNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
{
	private readonly StarTrinityWebRtcApmSuppressorFactory _webRtcFactory;

	private readonly RnNoiseSuppressorFactory _rnNoiseFactory;

	public string Name
	{
		get
		{
			throw null;
		}
	}

	public bool IsSupported
	{
		get
		{
			throw null;
		}
	}

	public IVoiceNoiseSuppressor Create()
	{
		throw null;
	}

	public WebRtcRnNoiseSuppressorFactory()
	{
		throw null;
	}
}
