using System;
using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public sealed class RemoteVoiceMixer : IDisposable
{
	private readonly Dictionary<uint, RemoteVoiceStream> _streams;

	private readonly List<RemoteVoiceStream> _snapshot;

	private float _volume;

	public int StreamCount
	{
		get
		{
			throw null;
		}
	}

	public int TotalPacketsReceived
	{
		get
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
	}

	public int ConcealedFrames
	{
		get
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
	}

	public int RebufferEvents
	{
		get
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
	}

	public long TotalSamplesPlayed
	{
		get
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
	}

	public int LastReadSamples
	{
		get
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
	}

	public float MaxLastDecodedRms
	{
		get
		{
			throw null;
		}
	}

	public float MaxLastPlayedRms
	{
		get
		{
			throw null;
		}
	}

	public void SetVolume(float volume)
	{
		throw null;
	}

	public void SetSpatialGain(uint speakerNetId, float spatialGain)
	{
		throw null;
	}

	public bool TryGetSpeakerVisualLevel(uint speakerNetId, out float level, out bool muted)
	{
		throw null;
	}

	public bool TryCopySpeakerVisualSpectrum(uint speakerNetId, float[] destination, out bool muted)
	{
		throw null;
	}

	public void CopySpeakerNetIds(List<uint> destination)
	{
		throw null;
	}

	public void Push(VoicePacket packet, float spatialGain)
	{
		throw null;
	}

	public void TickDecode()
	{
		throw null;
	}

	public void Clear()
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	public RemoteVoiceMixer()
	{
		throw null;
	}
}
