using System;

namespace Comms.Modules.Voice.Audio;

public sealed class LightweightNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable
{
	private float _noiseRms;

	private float _envelope;

	private float _gain;

	public string Name => null;

	public string Status => null;

	public void Reset()
	{
	}

	public void Process(float[] samples, int length)
	{
	}

	public void Dispose()
	{
	}

	private static void Measure(float[] samples, int length, out float rms, out float peak)
	{
		rms = default(float);
		peak = default(float);
	}

	private void UpdateNoiseFloor(float bufferRms, float bufferPeak)
	{
	}

	private static float Clamp01(float value)
	{
		return 0f;
	}
}
