using System;

namespace Comms.Modules.Voice.Audio;

public sealed class LightweightNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable
{
	private float _noiseRms;

	private float _envelope;

	private float _gain;

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

	public void Reset()
	{
		throw null;
	}

	public void Process(float[] samples, int length)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	private static void Measure(float[] samples, int length, out float rms, out float peak)
	{
		throw null;
	}

	private void UpdateNoiseFloor(float bufferRms, float bufferPeak)
	{
		throw null;
	}

	private static float Clamp01(float value)
	{
		throw null;
	}

	public LightweightNoiseSuppressor()
	{
		throw null;
	}
}
