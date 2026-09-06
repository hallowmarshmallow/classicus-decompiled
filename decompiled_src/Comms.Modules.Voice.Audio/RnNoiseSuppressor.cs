using System;
using RNNoise.NET;

namespace Comms.Modules.Voice.Audio;

public sealed class RnNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable, IVoiceNoiseSuppressorAllowsSilence, IVoiceRequiredNoiseSuppressor
{
	private readonly Denoiser _denoiser;

	private int _processedFrames;

	private double _lastElapsedMilliseconds;

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

	public RnNoiseSuppressor()
	{
		throw null;
	}
}
