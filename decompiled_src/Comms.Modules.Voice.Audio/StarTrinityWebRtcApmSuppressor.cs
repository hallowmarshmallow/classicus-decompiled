using System;
using AudioProcessingModuleCs.Media;
using AudioProcessingModuleCs.Media.Dsp.WebRtc;

namespace Comms.Modules.Voice.Audio;

public sealed class StarTrinityWebRtcApmSuppressor : IVoiceNoiseSuppressor, IDisposable, IVoicePlaybackReferenceConsumer, IVoiceNoiseSuppressorAllowsSilence, IVoiceRequiredNoiseSuppressor
{
	private readonly AudioFormat _voiceFormat;

	private readonly AudioFormat _apmFormat;

	private readonly byte[] _recordedBytes;

	private readonly byte[] _playbackBytes;

	private readonly short[] _processedFrame;

	private readonly object _playbackSubmitGate;

	private readonly FloatRingBuffer _referenceRing;

	private readonly float[] _referenceFrame;

	private readonly bool _enableDenoise;

	private float[] _downmixScratch;

	private WebRtcFilter _filter;

	private float _envelopeGain;

	private int _processedFrames;

	private int _expectedAudioLatencyMilliseconds;

	private int _submittedReferenceCallbacks;

	private int _submittedReferenceFrames;

	private int _droppedReferenceCallbacks;

	private int _lastReferenceChannels;

	private float _lastReferenceRms;

	private string _lastReference;

	private string _lastReferenceSource;

	public string Name
	{
		get
		{
			throw null;
		}
	}

	public string Status
	{
		get
		{
			throw null;
		}
	}

	public StarTrinityWebRtcApmSuppressor(bool enableDenoise)
	{
		throw null;
	}

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
		throw null;
	}

	public void Process(float[] samples, int length)
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	private void DrainPlaybackReference(WebRtcFilter filter)
	{
		throw null;
	}

	private WebRtcFilter RecreateFilter()
	{
		throw null;
	}

	private void ApplySuppressionEnvelope(short[] processed, float[] wideband, int offset)
	{
		throw null;
	}

	private static void MonoFloatToBandLimitedPcm16(float[] source, int offset, byte[] destination)
	{
		throw null;
	}

	private static int CalculateExpectedAudioLatencyMilliseconds()
	{
		throw null;
	}

	private static short FloatToPcm16(float sample)
	{
		throw null;
	}

	private static float Pcm16ToFloat(short sample)
	{
		throw null;
	}

	private static float Clamp01(float value)
	{
		throw null;
	}
}
