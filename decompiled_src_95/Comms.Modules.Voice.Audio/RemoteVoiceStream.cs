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
			return _003CTotalPacketsReceived_003Ek__BackingField;
		}
		private set
		{
			_003CTotalPacketsReceived_003Ek__BackingField = value;
		}
	}

	public int TotalFramesDecoded
	{
		get
		{
			return _003CTotalFramesDecoded_003Ek__BackingField;
		}
		private set
		{
			_003CTotalFramesDecoded_003Ek__BackingField = value;
		}
	}

	public int ConcealedFrames
	{
		get
		{
			return _003CConcealedFrames_003Ek__BackingField;
		}
		private set
		{
			_003CConcealedFrames_003Ek__BackingField = value;
		}
	}

	public int RecoveredFrames
	{
		get
		{
			return _003CRecoveredFrames_003Ek__BackingField;
		}
		private set
		{
			_003CRecoveredFrames_003Ek__BackingField = value;
		}
	}

	public int RebufferEvents
	{
		get
		{
			return _003CRebufferEvents_003Ek__BackingField;
		}
		private set
		{
			_003CRebufferEvents_003Ek__BackingField = value;
		}
	}

	public int PlaybackBufferedSamples => 0;

	public int JitterBufferedFrames => 0;

	public long TotalSamplesQueued
	{
		get
		{
			return _003CTotalSamplesQueued_003Ek__BackingField;
		}
		private set
		{
			_003CTotalSamplesQueued_003Ek__BackingField = value;
		}
	}

	public long TotalSamplesPlayed
	{
		get
		{
			return _003CTotalSamplesPlayed_003Ek__BackingField;
		}
		private set
		{
			_003CTotalSamplesPlayed_003Ek__BackingField = value;
		}
	}

	public int PlaybackUnderruns
	{
		get
		{
			return _003CPlaybackUnderruns_003Ek__BackingField;
		}
		private set
		{
			_003CPlaybackUnderruns_003Ek__BackingField = value;
		}
	}

	public int LastCallbackSamples
	{
		get
		{
			return _003CLastCallbackSamples_003Ek__BackingField;
		}
		private set
		{
			_003CLastCallbackSamples_003Ek__BackingField = value;
		}
	}

	public int LastReadSamples
	{
		get
		{
			return _003CLastReadSamples_003Ek__BackingField;
		}
		private set
		{
			_003CLastReadSamples_003Ek__BackingField = value;
		}
	}

	public float LastDecodedRms
	{
		get
		{
			return _003CLastDecodedRms_003Ek__BackingField;
		}
		private set
		{
			_003CLastDecodedRms_003Ek__BackingField = value;
		}
	}

	public float LastPlayedRms
	{
		get
		{
			return _003CLastPlayedRms_003Ek__BackingField;
		}
		private set
		{
			_003CLastPlayedRms_003Ek__BackingField = value;
		}
	}

	public float LastVisualRms => 0f;

	public float VisualGain => 0f;

	public bool Muted
	{
		get
		{
			return _003CMuted_003Ek__BackingField;
		}
		private set
		{
			_003CMuted_003Ek__BackingField = value;
		}
	}

	private bool IsVisualSignalFresh => false;

	public RemoteVoiceStream(uint speakerNetId, float volume)
	{
	}

	public void SetVolume(float volume)
	{
	}

	public void SetSpatialGain(float spatialGain)
	{
	}

	public void Push(VoicePacket packet)
	{
	}

	public void Dispose()
	{
	}

	private void StartPlaybackIfReady()
	{
	}

	private void OnRead(float[] data)
	{
	}

	private int FillFromJitter(float[] data)
	{
		return 0;
	}

	private void ApplySourceVolume()
	{
	}

	private bool DecodeNextFrame()
	{
		return false;
	}

	private int DecodeLostFrame()
	{
		return 0;
	}

	public bool CopyVisualSpectrum(float[] destination)
	{
		return false;
	}

	private static float CalculateRms(float[] samples, int length)
	{
		return 0f;
	}

	private void ApplySafetyLimiter(float[] samples, int length)
	{
	}

	private static float LimitSample(float sample)
	{
		return 0f;
	}
}
