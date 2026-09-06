namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

public class WebRtcFilter : EchoCancelFilter
{
	private readonly AecCore aec;

	private readonly NoiseSuppressor ns;

	private readonly HighPassFilter highPassFilter;

	private readonly bool enableAec;

	private readonly bool enableDenoise;

	private readonly bool enableAgc;

	private readonly Agc agc;

	private int captureLevels0;

	public WebRtcFilter(int expectedAudioLatency, int filterLength, AudioFormat recordedAudioFormat, AudioFormat playedAudioFormat, bool enableAec, bool enableDenoise, bool enableAgc, IAudioFilter playedResampler = null, IAudioFilter recordedResampler = null, AecNlpMode nlpMode = AecNlpMode.KAecNlpModerate)
		: base(0, 0, null, null)
	{
	}

	protected override void PerformEchoCancellation(short[] recorded, short[] played, short[] outFrame)
	{
	}

	private void gain_control_AnalyzeCaptureAudio(short[] data)
	{
	}

	private void gain_control_ProcessCaptureAudio(short[] data)
	{
	}
}
