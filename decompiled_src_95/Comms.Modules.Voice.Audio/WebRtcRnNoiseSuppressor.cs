using System;

namespace Comms.Modules.Voice.Audio;

public sealed class WebRtcRnNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable, IVoicePlaybackReferenceConsumer, IVoiceNoiseSuppressorAllowsSilence, IVoiceRequiredNoiseSuppressor
{
	private readonly StarTrinityWebRtcApmSuppressor _webRtc;

	private readonly RnNoiseSuppressor _rnNoise;

	public string Name => null;

	public string Status => null;

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
	}

	public void Process(float[] samples, int length)
	{
	}

	public void Reset()
	{
	}

	public void Dispose()
	{
	}
}
