using System;

namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

public class AecCore
{
	private readonly AecConfig aecConfig;

	private readonly Stats aNlp;

	private readonly FFT fft;

	private readonly float[] dBuf;

	private readonly float[] dBufH;

	private readonly float[] dInitMinPow;

	private readonly float[] dMinPow;

	private readonly float[] dPow;

	private readonly float[] eBuf;

	private readonly Stats erl;

	private readonly Stats erle;

	private readonly float errThresh;

	private readonly short[] farBuf;

	private readonly PowerLevel farlevel;

	private readonly PowerLevel linoutlevel;

	private readonly float mu;

	public readonly short mult;

	private readonly PowerLevel nearlevel;

	private readonly PowerLevel nlpoutlevel;

	private readonly float[] outBuf;

	private readonly Complex[] sde;

	private readonly Complex[] sxd;

	private readonly float[] wfBuf0;

	private readonly float[] wfBuf1;

	private readonly float[] xfBuf0;

	private readonly float[] xfBuf1;

	private readonly float[] xBuf;

	private readonly float[] xPow;

	private readonly Complex[] xfwBuf;

	private int delayEstCtr;

	private int delayIdx;

	private short divergeState;

	private short echoState;

	private int farBufReadPos;

	private int farBufWritePos;

	private readonly RingBuffer farFrBuf;

	private float hNlFbLocalMin;

	private float hNlFbMin;

	private int hNlMinCtr;

	private int hNlNewMin;

	private float hNlXdAvgMin;

	public float[] hNs;

	private int inSamples;

	private int knownDelay;

	public bool metricsMode;

	public float minOverDrive;

	private readonly RingBuffer nearFrBuf;

	private RingBuffer nearFrBufH;

	private int noiseEstCtr;

	private float[] noisePow;

	private readonly RingBuffer outFrBuf;

	private RingBuffer outFrBufH;

	private int outSamples;

	private float overDrive;

	private float overDriveSm;

	public Stats rerl;

	private readonly float[] sd;

	private readonly float[] se;

	private int seed;

	private short stNearState;

	private int stateCounter;

	private readonly float[] sx;

	public float targetSupp;

	private int xfBufBlockPos;

	private static readonly float[] sqrtHanning;

	private static readonly float[] weightCurve;

	private static readonly float[] overDriveCurve;

	private static readonly Random rnd;

	public AecCore(AecConfig aecConfig)
	{
	}

	public void InitMetrics()
	{
	}

	public void ProcessFrame(short[] nearend, short[] farend, short[] output, int knownDelay)
	{
	}

	private void ProcessBlock(short[] farend, short[] nearend, short[] output)
	{
	}

	private void ScaleErrorSignal(float[] ef0, float[] ef1)
	{
	}

	private static float MulRe(float aRe, float aIm, float bRe, float bIm)
	{
		return 0f;
	}

	private static float MulIm(float aRe, float aIm, float bRe, float bIm)
	{
		return 0f;
	}

	private void FilterFar(float[] yf0, float[] yf1)
	{
	}

	private void FilterAdaptation(float[] fftBuf, float[] ef0, float[] ef1)
	{
	}

	private void UpdateMetrics()
	{
	}

	private void NonLinearProcessing(short[] output)
	{
	}

	private static void WebRtcSpl_RandUArray(short[] vector, short vectorLength)
	{
	}

	private static void ComfortNoise(Complex[] efw, Complex[] comfortNoiseHband, float[] noisePow, float[] lambda)
	{
	}
}
