using System;

namespace AudioProcessingModuleCs.Media;

public class AudioFormat : IEquatable<AudioFormat>
{
	public readonly int SamplesPerSecond;

	public readonly int MillisecondsPerFrame;

	public readonly int SamplesPerFrame;

	public readonly int SamplesPer10Ms;

	public readonly int BytesPerFrame;

	public readonly int FramesPerSecond;

	public readonly int MaxQueuedAudioFrames;

	public readonly int BitsPerSample;

	public readonly int Channels;

	public readonly int BytesPerSample;

	public AudioFormat(int samplesPerSecond = 16000, int millisecondsPerFrame = 20, int channels = 1, int bitsPerSample = 16)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(AudioFormat other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
