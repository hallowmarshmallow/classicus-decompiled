namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

internal class Agc
{
	public enum AgcMode
	{
		AgcModeUnchanged,
		AgcModeAdaptiveAnalog,
		AgcModeAdaptiveDigital,
		AgcModeFixedDigital
	}

	private enum AgcBoolean
	{
		AgcFalse,
		AgcTrue
	}

	private class WebRtcAgcConfig
	{
		public short targetLevelDbfs;

		public short compressionGaindB;

		public AgcBoolean limiterEnable;

		public WebRtcAgcConfig()
		{
			throw null;
		}
	}

	private class AgcVad
	{
		private readonly int[] downState;

		private short HPstate;

		public short counter;

		public short logRatio;

		private short meanLongTerm;

		private int varianceLongTerm;

		public short stdLongTerm;

		private short meanShortTerm;

		private int varianceShortTerm;

		public short stdShortTerm;

		public void WebRtcAgc_InitVad()
		{
			throw null;
		}

		public short WebRtcAgc_ProcessVad(short[] inArray, int inArrayPtr, short nrSamples)
		{
			throw null;
		}

		public AgcVad()
		{
			throw null;
		}
	}

	private class DigitalAgc
	{
		private int capacitorSlow;

		private int capacitorFast;

		private int gain;

		public readonly int[] gainTable;

		private short gatePrevious;

		private AgcMode agcMode;

		private readonly AgcVad vadNearend;

		private readonly AgcVad vadFarend;

		public int WebRtcAgc_InitDigital(AgcMode agcMode)
		{
			throw null;
		}

		public int WebRtcAgc_ProcessDigital(short[] in_near_arr, int in_near_ptr, short[] in_near_H_arr, int in_near_H_ptr, short[] out_arr, int out_ptr, short[] out_H_arr, int out_H_ptr, uint FS, short lowlevelSignal)
		{
			throw null;
		}

		public int WebRtcAgc_AddFarendToDigital(short[] in_far_arr, int in_far_ptr, short nrSamples)
		{
			throw null;
		}

		public DigitalAgc()
		{
			throw null;
		}
	}

	private readonly uint fs;

	private short compressionGaindB;

	private short targetLevelDbfs;

	private readonly AgcMode agcMode;

	private AgcBoolean limiterEnable;

	private readonly WebRtcAgcConfig defaultConfig;

	private readonly WebRtcAgcConfig usedConfig;

	private readonly short initFlag;

	private int analogTargetLevel;

	private int startUpperLimit;

	private int startLowerLimit;

	private int upperPrimaryLimit;

	private int lowerPrimaryLimit;

	private int upperSecondaryLimit;

	private int lowerSecondaryLimit;

	private ushort targetIdx;

	private short analogTarget;

	private readonly int[] filterState;

	private int upperLimit;

	private int lowerLimit;

	private int Rxx160w32;

	private int Rxx16_LPw32;

	private int Rxx160_LPw32;

	private int Rxx16_LPw32Max;

	private readonly int[] Rxx16_vectorw32;

	private readonly int[][] Rxx16w32_array;

	private readonly int[][] env;

	private short Rxx16pos;

	private short envSum;

	private short vadThreshold;

	private short inActive;

	private short msTooLow;

	private short msTooHigh;

	private short changeToSlowMode;

	private short firstCall;

	private short msZero;

	private short msecSpeechOuterChange;

	private short msecSpeechInnerChange;

	private short activeSpeech;

	private short muteGuardMs;

	private short inQueue;

	private int micRef;

	private ushort gainTableIdx;

	private int micGainIdx;

	private int micVol;

	private int maxLevel;

	private readonly int maxAnalog;

	private readonly int maxInit;

	private readonly int minLevel;

	private readonly int minOutput;

	private int zeroCtrlMax;

	private readonly short scale;

	private readonly AgcVad vadMic;

	private readonly DigitalAgc digitalAgc;

	private short lowLevelSignal;

	private readonly short[] kSlope1;

	private readonly short[] kOffset1;

	private readonly short[] kSlope2;

	private readonly short[] kOffset2;

	private static readonly ushort[] kGenFuncTable;

	private readonly ushort[] kGainTableAnalog;

	private readonly ushort[] kGainTableVirtualMic;

	private readonly short[] kSuppressionTableVirtualMic;

	private readonly int[] kTargetLevelTable;

	private static readonly ushort[] kResampleAllpass1;

	private static readonly ushort[] kResampleAllpass2;

	private static int WebRtcSpl_NormU32(uint value)
	{
		throw null;
	}

	private static void WebRtcSpl_MemSetW32(int[] ptr, int set_value, int length)
	{
		throw null;
	}

	private static short WebRtcSpl_DivW32W16ResW16(int num, short den)
	{
		throw null;
	}

	private static short WEBRTC_SPL_RSHIFT_U16(int x, int c)
	{
		throw null;
	}

	private static int WEBRTC_SPL_MUL_16_U16(int a, int b)
	{
		throw null;
	}

	private static int WEBRTC_SPL_ABS_W32(int a)
	{
		throw null;
	}

	private static uint WEBRTC_SPL_RSHIFT_U32(uint x, int c)
	{
		throw null;
	}

	private static uint WEBRTC_SPL_UMUL_16_16(ushort a, ushort b)
	{
		throw null;
	}

	private static uint WEBRTC_SPL_LSHIFT_U32(uint x, int c)
	{
		throw null;
	}

	private static uint WEBRTC_SPL_UMUL_32_16(uint a, ushort b)
	{
		throw null;
	}

	private static int WEBRTC_SPL_MUL_32_16(int a, int b)
	{
		throw null;
	}

	private static int WebRtcSpl_NormW32(int value)
	{
		throw null;
	}

	private static int WEBRTC_SPL_DIV(int a, int b)
	{
		throw null;
	}

	private static int WEBRTC_SPL_MUL(int a, int b)
	{
		throw null;
	}

	private static ushort WEBRTC_SPL_LSHIFT_U16(int x, int c)
	{
		throw null;
	}

	private static int WEBRTC_SPL_SCALEDIFF32(int A, int B, int C)
	{
		throw null;
	}

	private static int AGC_MUL32(int A, int B)
	{
		throw null;
	}

	private static uint WEBRTC_SPL_UMUL(uint a, uint b)
	{
		throw null;
	}

	private static int WebRtcSpl_DotProductWithScale(short[] vector1, short[] vector2, int length, int scaling)
	{
		throw null;
	}

	private static short WEBRTC_SPL_ADD_SAT_W16(short var1, short var2)
	{
		throw null;
	}

	private static int AGC_SCALEDIFF32(int A, int B, int C)
	{
		throw null;
	}

	private static int WebRtcSpl_SqrtLocal(int in_)
	{
		throw null;
	}

	private static int WebRtcSpl_Sqrt(int value)
	{
		throw null;
	}

	public Agc(int minLevel, int maxLevel, AgcMode agcMode, uint fs)
	{
		throw null;
	}

	private int WebRtcAgc_set_config(WebRtcAgcConfig agcConfig)
	{
		throw null;
	}

	private void WebRtcAgc_UpdateAgcThresholds()
	{
		throw null;
	}

	private static int WebRtcAgc_CalculateGainTable(int[] gainTable, short digCompGaindB, short targetLevelDbfs, AgcBoolean limiterEnable, short analogTarget)
	{
		throw null;
	}

	public int WebRtcAgc_VirtualMic(short[] in_near, short[] in_near_H, short samples, int micLevelIn, out int micLevelOut)
	{
		throw null;
	}

	private int WebRtcAgc_AddMic(short[] in_mic, short[] in_mic_H, short samples)
	{
		throw null;
	}

	private static void WebRtcSpl_DownsampleBy2(short[] inArray, int inArrayPtr, short len, short[] outArray, int[] filtState)
	{
		throw null;
	}

	public int WebRtcAgc_Process(short[] in_near, short[] in_near_H, short samples, short[] outArray, short[] out_H, int inMicLevel, out int outMicLevel, short echo, out bool saturationWarning)
	{
		throw null;
	}

	private int WebRtcAgc_ProcessAnalog(int inMicLevel, ref int outMicLevel, short vadLogRatio, short echo, ref bool saturationWarning)
	{
		throw null;
	}

	private void WebRtcAgc_SaturationCtrl(ref bool saturated, int[][] env)
	{
		throw null;
	}

	private void WebRtcAgc_ZeroCtrl(ref int inMicLevel, int[][] env)
	{
		throw null;
	}

	private void WebRtcAgc_SpeakerInactiveCtrl()
	{
		throw null;
	}

	private void WebRtcAgc_ExpCurve(short volume, out short index)
	{
		throw null;
	}

	public int WebRtcAgc_AddFarend(short[] in_far, short samples)
	{
		throw null;
	}

	static Agc()
	{
		throw null;
	}
}
