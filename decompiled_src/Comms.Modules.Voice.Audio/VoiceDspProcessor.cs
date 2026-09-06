namespace Comms.Modules.Voice.Audio;

public sealed class VoiceDspProcessor
{
	private readonly float _highPassAlpha;

	private bool _gateOpen;

	private float _dcEstimate;

	private float _highPassLastInput;

	private float _highPassLastOutput;

	private float _gateGain;

	private int _hangFrames;

	private float _003CLastRms_003Ek__BackingField;

	private float _003CLastOutputRms_003Ek__BackingField;

	public float LastRms
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public float LastOutputRms
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public VoiceDspProcessor()
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public bool Process(float[] frame, float inputGain, bool vadEnabled)
	{
		throw null;
	}

	private void UpdateGate(float rms)
	{
		throw null;
	}

	private static float Compress(float sample)
	{
		throw null;
	}

	private static float Limit(float sample)
	{
		throw null;
	}
}
