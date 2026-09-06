using System;

namespace Comms.Modules.Voice.Audio;

public sealed class WebRtcRnNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable, IVoicePlaybackReferenceConsumer, IVoiceNoiseSuppressorAllowsSilence, IVoiceRequiredNoiseSuppressor
{
	private readonly StarTrinityWebRtcApmSuppressor _webRtc;

	private readonly RnNoiseSuppressor _rnNoise;

	public string Name
	{
		get
		{
			throw null;
		}
	}

	public string Status
	{
		get
		{
			throw null;
		}
	}

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
		throw null;
	}

	public void Process(float[] samples, int length)
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	public WebRtcRnNoiseSuppressor()
	{
		throw null;
	}
}
