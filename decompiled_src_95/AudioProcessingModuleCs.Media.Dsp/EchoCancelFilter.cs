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
			_003CSystemLatency_003Ek__BackingField = value;
		}
	}

	public int FilterLength
	{
		get
		{
			return _003CFilterLength_003Ek__BackingField;
		}
		private set
		{
			_003CFilterLength_003Ek__BackingField = value;
		}
	}

	public int SamplesPerFrame
	{
		get
		{
			return _003CSamplesPerFrame_003Ek__BackingField;
		}
		private set
		{
			_003CSamplesPerFrame_003Ek__BackingField = value;
		}
	}

	private int SamplesPerSecond
	{
		set
		{
			_003CSamplesPerSecond_003Ek__BackingField = value;
		}
	}

	public int QueueSize
	{
		get
		{
			return _003CQueueSize_003Ek__BackingField;
		}
		private set
		{
			_003CQueueSize_003Ek__BackingField = value;
		}
	}

	public string InstanceName
	{
		set
		{
			_003CInstanceName_003Ek__BackingField = value;
		}
	}

	protected EchoCancelFilter(int systemLatency, int filterLength, AudioFormat recordedAudioFormat, AudioFormat playedAudioFormat, IAudioFilter playedResampler = null, IAudioFilter recordedResampler = null)
	{
	}

	public void RegisterFramePlayed(byte[] speakerSample)
	{
	}

	public virtual void Write(byte[] recordedData)
	{
	}

	public virtual bool Read(Array outBuffer, out bool moreFrames)
	{
		moreFrames = default(bool);
		return false;
	}

	protected abstract void PerformEchoCancellation(short[] recorded, short[] played, short[] outFrame);
}
