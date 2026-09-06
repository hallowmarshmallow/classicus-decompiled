namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

public class NoiseSuppressor
{
	private class NsParaExtract
	{
		public float binSizeLrt;

		public float binSizeSpecDiff;

		public float binSizeSpecFlat;

		public float factor1ModelPars;

		public float factor2ModelPars;

		public float limitPeakSpacingSpecDiff;

		public float limitPeakSpacingSpecFlat;

		public float limitPeakWeightsSpecDiff;

		public float limitPeakWeightsSpecFlat;

		public float maxLrt;

		public float maxSpecDiff;

		public float maxSpecFlat;

		public float minLrt;

		public float minSpecDiff;

		public float minSpecFlat;

		public float rangeAvgHistLrt;

		public float thresFluctLrt;

		public float thresPosSpecFlat;

		public int thresWeightSpecDiff;

		public int thresWeightSpecFlat;

		public NsParaExtract()
		{
			throw null;
		}
	}

	private static readonly float[] kBlocks80w128;

	private static readonly float[] kBlocks160w256;

	private static float[] kBlocks320w512;

	private readonly FFT fft;

	private readonly int anaLen;

	private readonly int blockLen;

	private readonly int blockLen10Ms;

	private readonly int[] counter;

	private readonly float[] dataBuf;

	private readonly float[] density;

	private readonly float[] featureData;

	private readonly NsParaExtract featureExtractionParams;

	private readonly int[] histLrt;

	private readonly int[] histSpecDiff;

	private readonly int[] histSpecFlat;

	private readonly int initFlag;

	private readonly float[] initMagnEst;

	private readonly float[] logLrtTimeAvg;

	private readonly float[] lquantile;

	private readonly float[] magnAvgPause;

	private readonly int magnLen;

	private readonly float[] magnPrev;

	private readonly int[] modelUpdatePars;

	private readonly float[] noisePrev;

	private readonly float[] outBuf;

	private readonly float[] priorModelPars;

	private readonly float[] quantile;

	private readonly float[] smooth;

	private readonly float[] speechProbHb;

	private readonly float[] syntBuf;

	private readonly int windShift;

	private readonly float[] window;

	private int aggrMode;

	private int blockInd;

	private float[] dataBufHb;

	private float denoiseBound;

	private uint fs;

	private int gainmap;

	private int outLen;

	private float overdrive;

	private float pinkNoiseExp;

	private float pinkNoiseNumerator;

	private float priorSpeechProb;

	private float signalEnergy;

	private float sumMagn;

	private int updates;

	private float whiteNoiseLevel;

	public NoiseSuppressor(AudioFormat audioFormat)
	{
		throw null;
	}

	private void WebRtcNs_set_policy_core(int mode)
	{
		throw null;
	}

	private void WebRtcNs_set_feature_extraction_parameters()
	{
		throw null;
	}

	private void WebRtcNs_ComputeSpectralFlatness(float[] magnIn)
	{
		throw null;
	}

	private void WebRtcNs_NoiseEstimation(float[] magn, float[] noise)
	{
		throw null;
	}

	private void WebRtcNs_ComputeSpectralDifference(float[] magnIn)
	{
		throw null;
	}

	private void WebRtcNs_FeatureParameterExtraction(int flag)
	{
		throw null;
	}

	private void WebRtcNs_SpeechNoiseProb(float[] probSpeechFinal, float[] snrLocPrior, float[] snrLocPost)
	{
		throw null;
	}

	public void ProcessFrame(short[] inFrame, int inOffset, short[] outFrame, int outOffset)
	{
		throw null;
	}

	static NoiseSuppressor()
	{
		throw null;
	}
}
