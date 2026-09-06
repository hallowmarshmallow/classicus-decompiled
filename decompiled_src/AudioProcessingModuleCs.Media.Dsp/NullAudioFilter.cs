using System;

namespace AudioProcessingModuleCs.Media.Dsp;

public class NullAudioFilter : IAudioFilter
{
	private readonly byte[] buffer;

	private int writePosition;

	private int readPosition;

	private readonly int outputBytesPerFrame;

	private string _003CInstanceName_003Ek__BackingField;

	public string InstanceName
	{
		set
		{
			throw null;
		}
	}

	public NullAudioFilter(int outputBytesPerFrame)
	{
		throw null;
	}

	public bool Read(Array outBuffer, out bool moreFrames)
	{
		throw null;
	}

	public void Write(byte[] sampleData)
	{
		throw null;
	}
}
