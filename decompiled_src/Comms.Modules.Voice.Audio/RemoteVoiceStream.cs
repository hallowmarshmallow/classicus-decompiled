using System;
using UnityEngine;

namespace Comms.Modules.Voice.Audio;

public sealed class RemoteVoiceStream : IDisposable
{
	private readonly uint _speakerNetId;

	private readonly VoiceJitterBuffer _jitter;

	private readonly OpusVoiceDecoder _decoder;

	private readonly VoiceSpectrumAnalyzer _visualSpectrum;

	private readonly float[] _decodeFrame;

	private int _decodeFrameOffset;

	private int _decodeFrameLength;

	private readonly GameObject _gameObject;

	private readonly AudioSource _source;

	private readonly AudioClip _clip;

	private readonly AudioClip.PCMReaderCallback _pcmReader;

	private float _volume;

	private float _spatialGain;

	private float _playbackReferenceGain;

	private float _limiterGain;

	private bool _disposed;

	private bool _startedPlayback;

	private bool _loggedFirstDecode;

	private float _lastVisualRms;

	private float _lastVisualSignalTime;

	private int _003CTotalPacketsReceived_003Ek__BackingField;

	private int _003CTotalFramesDecoded_003Ek__BackingField;

	private int _003CConcealedFrames_003Ek__BackingField;

	private int _003CRecoveredFrames_003Ek__BackingField;

	private int _003CRebufferEvents_003Ek__BackingField;

	private long _003CTotalSamplesQueued_003Ek__BackingField;

	private long _003CTotalSamplesPlayed_003Ek__BackingField;

	private int _003CPlaybackUnderruns_003Ek__BackingField;

	private int _003CLastCallbackSamples_003Ek__BackingField;

	private int _003CLastReadSamples_003Ek__BackingField;

	private float _003CLastDecodedRms_003Ek__BackingField;

	private float _003CLastPlayedRms_003Ek__BackingField;

	private bool _003CMuted_003Ek__BackingField;

	public int TotalPacketsReceived
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

	public int TotalFramesDecoded
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

	public int ConcealedFrames
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

	public int RecoveredFrames
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

	public int RebufferEvents
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

	public int PlaybackBufferedSamples
	{
		get
		{
			throw null;
		}
	}

	public int JitterBufferedFrames
	{
		get
		{
			throw null;
		}
	}

	public long TotalSamplesQueued
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

	public long TotalSamplesPlayed
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

	public int PlaybackUnderruns
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

	public int LastCallbackSamples
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

	public int LastReadSamples
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

	public float LastDecodedRms
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

	public float LastPlayedRms
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

	public float LastVisualRms
	{
		get
		{
			throw null;
		}
	}

	public float VisualGain
	{
		get
		{
			throw null;
		}
	}

	public bool Muted
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

	private bool IsVisualSignalFresh
	{
		get
		{
			throw null;
		}
	}

	public RemoteVoiceStream(uint speakerNetId, float volume)
	{
		throw null;
	}

	public void SetVolume(float volume)
	{
		throw null;
	}

	public void SetSpatialGain(float spatialGain)
	{
		throw null;
	}

	public void Push(VoicePacket packet)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	private void StartPlaybackIfReady()
	{
		throw null;
	}

	private void OnRead(float[] data)
	{
		throw null;
	}

	private int FillFromJitter(float[] data)
	{
		throw null;
	}

	private void ApplySourceVolume()
	{
		throw null;
	}

	private bool DecodeNextFrame()
	{
		throw null;
	}

	private int DecodeLostFrame()
	{
		throw null;
	}

	public bool CopyVisualSpectrum(float[] destination)
	{
		throw null;
	}

	private static float CalculateRms(float[] samples, int length)
	{
		throw null;
	}

	private void ApplySafetyLimiter(float[] samples, int length)
	{
		throw null;
	}

	private static float LimitSample(float sample)
	{
		throw null;
	}
}
