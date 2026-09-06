using System;
using RNNoise.NET;

namespace Comms.Modules.Voice.Audio;

public sealed class RnNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable, IVoiceNoiseSuppressorAllowsSilence, IVoiceRequiredNoiseSuppressor
{
	private readonly Denoiser _denoiser;

	private int _processedFrames;

	private double _lastElapsedMilliseconds;

	public string Name => null;

	public string Status => null;

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
