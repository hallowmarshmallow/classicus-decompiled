namespace Comms.Modules.Voice;

public sealed class VoiceSettings
{
	public bool PushToTalk;

	public bool MicHeld;

	public bool Enabled => false;

	public VoiceMode Mode => default(VoiceMode);

	public bool ProximityEnabled => false;

	public float ProximityRange => 0f;

	public bool WallsBlockVoice => false;

	public bool AutoExportWallSvg => false;

	public bool NoiseReduction => false;

	public string NoiseReductionBackend => null;

	public float InputGain => 0f;

	public string CaptureBackend => null;

	public string MicrophoneDevice
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string SelectedMicrophoneLabel => null;

	public float OutputVolume => 0f;

	public bool WantsTransmitInput => false;
}
