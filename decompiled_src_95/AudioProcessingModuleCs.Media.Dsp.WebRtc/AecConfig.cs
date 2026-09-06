namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

public class AecConfig
{
	public readonly int SamplesPerFrame;

	public readonly int SamplesPerSecond;

	public readonly int BufSizeSamp;

	public bool MetricsMode;

	public AecNlpMode NlpMode;

	public bool SkewMode;

	public readonly int FilterLength;

	public readonly int NumPartitions;

	public readonly int FilterLength2;

	public readonly int FarBufferLength;

	public AecConfig(int filterLengthInSamples, int samplesPerFrame, int samplesPerSecond)
	{
	}
}
