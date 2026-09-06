using System;

namespace AudioProcessingModuleCs.Media.Dsp;

public class ResampleFilter : IAudioFilter
{
	protected readonly ResampleFilterLogger logger;

	private readonly byte[] scaledBuffer;

	private readonly double scalingFactor;

	private string instanceName;

	private int sampleBufferReadPosition;

	private int sampleBufferWritePosition;

	private int _003CInputBytesPerSample_003Ek__BackingField;

	private int _003CInputSamplesPerSecond_003Ek__BackingField;

	private int _003CInputChannels_003Ek__BackingField;

	private int _003COutputBytesPerSample_003Ek__BackingField;

	private int _003COutputSamplesPerSecond_003Ek__BackingField;

	private int _003COutputChannels_003Ek__BackingField;

	private int _003COutputBytesPerFrame_003Ek__BackingField;

	private int _003COutputMillisecondsPerFrame_003Ek__BackingField;

	private double _003CCorrectionFactor_003Ek__BackingField;

	private int InputBytesPerSample
	{
		set
		{
			throw null;
		}
	}

	private int InputSamplesPerSecond
	{
		set
		{
			throw null;
		}
	}

	private int InputChannels
	{
		set
		{
			throw null;
		}
	}

	public int OutputBytesPerSample
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private int OutputSamplesPerSecond
	{
		set
		{
			throw null;
		}
	}

	private int OutputChannels
	{
		set
		{
			throw null;
		}
	}

	public int OutputBytesPerFrame
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private int OutputMillisecondsPerFrame
	{
		set
		{
			throw null;
		}
	}

	public int UnreadBytes
	{
		get
		{
			throw null;
		}
	}

	protected double CorrectionFactor
	{
		set
		{
			throw null;
		}
	}

	public string InstanceName
	{
		set
		{
			throw null;
		}
	}

	public ResampleFilter(AudioFormat input, AudioFormat output)
	{
		throw null;
	}

	public virtual void Write(byte[] sampleData)
	{
		throw null;
	}

	public virtual bool Read(Array outBuffer, out bool moreFrames)
	{
		throw null;
	}

	private int GetScaledLength(int sampleLength)
	{
		throw null;
	}

	protected virtual int GetCorrectedLength(int scaledLength)
	{
		throw null;
	}

	protected void ScaleSampleOntoBuffer(byte[] originalData, int scaledLength)
	{
		throw null;
	}
}
