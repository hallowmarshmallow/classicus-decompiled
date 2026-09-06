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
			return _003CLastRms_003Ek__BackingField;
		}
		private set
		{
			_003CLastRms_003Ek__BackingField = value;
		}
	}

	public float LastOutputRms
	{
		get
		{
			return _003CLastOutputRms_003Ek__BackingField;
		}
		private set
		{
			_003CLastOutputRms_003Ek__BackingField = value;
		}
	}

	public void Reset()
	{
	}

	public bool Process(float[] frame, float inputGain, bool vadEnabled)
	{
		return false;
	}

	private void UpdateGate(float rms)
	{
	}

	private static float Compress(float sample)
	{
		return 0f;
	}

	private static float Limit(float sample)
	{
		return 0f;
	}
}
