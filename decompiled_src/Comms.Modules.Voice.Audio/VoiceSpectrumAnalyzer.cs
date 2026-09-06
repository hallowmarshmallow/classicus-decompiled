namespace Comms.Modules.Voice.Audio;

public sealed class VoiceSpectrumAnalyzer
{
	private static readonly float[] Window;

	private static readonly float[] TwiddleReal;

	private static readonly float[] TwiddleImag;

	private static readonly int[] BandBins;

	private readonly object _sync;

	private readonly float[] _real;

	private readonly float[] _imag;

	private readonly float[] _bands;

	public void Analyze(float[] samples, int length, float gain)
	{
		throw null;
	}

	public bool CopyTo(float[] destination)
	{
		throw null;
	}

	public void Clear()
	{
		throw null;
	}

	private static float[] BuildWindow()
	{
		throw null;
	}

	private static float[] BuildTwiddles(bool real)
	{
		throw null;
	}

	private static int[] BuildBandBins()
	{
		throw null;
	}

	private static void TransformFft(float[] real, float[] imag)
	{
		throw null;
	}

	public VoiceSpectrumAnalyzer()
	{
		throw null;
	}

	static VoiceSpectrumAnalyzer()
	{
		throw null;
	}
}
