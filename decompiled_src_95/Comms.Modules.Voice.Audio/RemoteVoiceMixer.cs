using System;
using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public sealed class RemoteVoiceMixer : IDisposable
{
	private readonly Dictionary<uint, RemoteVoiceStream> _streams;

	private readonly List<RemoteVoiceStream> _snapshot;

	private float _volume;

	public int StreamCount => 0;

	public int TotalPacketsReceived => 0;

	public int TotalFramesDecoded => 0;

	public int ConcealedFrames => 0;

	public int RecoveredFrames => 0;

	public int RebufferEvents => 0;

	public int PlaybackBufferedSamples => 0;

	public int JitterBufferedFrames => 0;

	public long TotalSamplesQueued => 0L;

	public long TotalSamplesPlayed => 0L;

	public int PlaybackUnderruns => 0;

	public int LastReadSamples => 0;

	public int LastCallbackSamples => 0;

	public float MaxLastDecodedRms => 0f;

	public float MaxLastPlayedRms => 0f;

	public void SetVolume(float volume)
	{
	}

	public void SetSpatialGain(uint speakerNetId, float spatialGain)
	{
	}

	public bool TryGetSpeakerVisualLevel(uint speakerNetId, out float level, out bool muted)
	{
		level = default(float);
		muted = default(bool);
		return false;
	}

	public bool TryCopySpeakerVisualSpectrum(uint speakerNetId, float[] destination, out bool muted)
	{
		muted = default(bool);
		return false;
	}

	public void CopySpeakerNetIds(List<uint> destination)
	{
	}

	public void Push(VoicePacket packet, float spatialGain)
	{
	}

	public void TickDecode()
	{
	}

	public void Clear()
	{
	}

	public void Dispose()
	{
	}
}
