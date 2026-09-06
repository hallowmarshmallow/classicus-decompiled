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
			_003CInstanceName_003Ek__BackingField = value;
		}
	}

	public NullAudioFilter(int outputBytesPerFrame)
	{
	}

	public bool Read(Array outBuffer, out bool moreFrames)
	{
		moreFrames = default(bool);
		return false;
	}

	public void Write(byte[] sampleData)
	{
	}
}
