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

	private static int _cachedOutputLatencyMilliseconds;

	public string Name => null;

	public string Status => null;

	public StarTrinityWebRtcApmSuppressor(bool enableDenoise)
	{
	}

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
	}

	public void Process(float[] samples, int length)
	{
	}

	public void Reset()
	{
	}

	public void Dispose()
	{
	}

	private void DrainPlaybackReference(WebRtcFilter filter)
	{
	}

	private WebRtcFilter RecreateFilter()
	{
		return null;
	}

	private void ApplySuppressionEnvelope(short[] processed, float[] wideband, int offset)
	{
	}

	private static void MonoFloatToBandLimitedPcm16(float[] source, int offset, byte[] destination)
	{
	}

	public static void CacheAudioOutputLatency()
	{
	}

	private static int CalculateExpectedAudioLatencyMilliseconds()
	{
		return 0;
	}

	private static short FloatToPcm16(float sample)
	{
		return 0;
	}

	private static float Pcm16ToFloat(short sample)
	{
		return 0f;
	}

	private static float Clamp01(float value)
	{
		return 0f;
	}
}
