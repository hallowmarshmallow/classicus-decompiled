using System;
using System.Collections.Generic;

namespace AudioProcessingModuleCs.Media.Dsp;

public abstract class EchoCancelFilter : IAudioFilter
{
	private readonly Queue<short[]> playedQueue;

	private bool queueTargetReached;

	private readonly IAudioFilter playedResampler;

	private readonly IAudioFilter recordedResampler;

	protected EchoCancelFilterLogger logger;

	private readonly short[] recorded;

	protected readonly AudioFormat recordedAudioFormat;

	protected readonly AudioFormat playedAudioFormat;

	private int _003CSystemLatency_003Ek__BackingField;

	private int _003CFilterLength_003Ek__BackingField;

	private int _003CSamplesPerFrame_003Ek__BackingField;

	private int _003CSamplesPerSecond_003Ek__BackingField;

	private int _003CQueueSize_003Ek__BackingField;

	private readonly int maxQueueSize;

	private string _003CInstanceName_003Ek__BackingField;

	private int SystemLatency
	{
		set
		{
			throw null;
		}
	}

	public int FilterLength
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

	public int SamplesPerFrame
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

	private int SamplesPerSecond
	{
		set
		{
			throw null;
		}
	}

	public int QueueSize
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

	public string InstanceName
	{
		set
		{
			throw null;
		}
	}

	protected EchoCancelFilter(int systemLatency, int filterLength, AudioFormat recordedAudioFormat, AudioFormat playedAudioFormat, IAudioFilter playedResampler = null, IAudioFilter recordedResampler = null)
	{
		throw null;
	}

	public void RegisterFramePlayed(byte[] speakerSample)
	{
		throw null;
	}

	public virtual void Write(byte[] recordedData)
	{
		throw null;
	}

	public virtual bool Read(Array outBuffer, out bool moreFrames)
	{
		throw null;
	}

	protected abstract void PerformEchoCancellation(short[] recorded, short[] played, short[] outFrame);
}
