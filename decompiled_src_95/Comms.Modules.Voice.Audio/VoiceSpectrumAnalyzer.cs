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
	}

	public bool CopyTo(float[] destination)
	{
		return false;
	}

	public void Clear()
	{
	}

	private static float[] BuildWindow()
	{
		return null;
	}

	private static float[] BuildTwiddles(bool real)
	{
		return null;
	}

	private static int[] BuildBandBins()
	{
		return null;
	}

	private static void TransformFft(float[] real, float[] imag)
	{
	}
}
