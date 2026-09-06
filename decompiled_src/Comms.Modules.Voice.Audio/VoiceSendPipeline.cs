using System;

namespace Comms.Modules.Voice.Audio;

public sealed class VoiceSendPipeline : IDisposable
{
	private IVoiceCaptureBackend _capture;

	private readonly FloatRingBuffer _captureRing;

	private IVoiceNoiseSuppressor _noiseSuppressor;

	private readonly VoiceDspProcessor _dsp;

	private readonly OpusVoiceEncoder _encoder;

	private readonly VoiceSpectrumAnalyzer _spectrum;

	private readonly float[] _pcmFrame;

	private readonly float[] _noiseBypassScratch;

	private readonly byte[] _opusScratch;

	private ushort _sequence;

	private bool _loggedFirstSend;

	private bool _lastNoiseReductionEnabled;

	private string _lastRequestedMicrophoneDevice;

	private string _activeCaptureBackendName;

	private string _activeNoiseSuppressorName;

	private string _lastNoiseReductionBackend;

	private string _blockedNoiseSuppressorName;

	private string _noiseSuppressorStatus;

	private bool _loggedRequiredSlowSuppressor;

	private int _requiredSlowFrameStreak;

	private bool _loggedRequiredFailureSuppressor;

	private bool _003CIsTransmitting_003Ek__BackingField;

	private string _003CLastBlockReason_003Ek__BackingField;

	private int _003CTotalFramesEncoded_003Ek__BackingField;

	private int _003CTotalFramesSent_003Ek__BackingField;

	public float LastRms
	{
		get
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
	}

	public float LastRawMicRms
	{
		get
		{
			throw null;
		}
	}

	public float LastRawMicPeak
	{
		get
		{
			throw null;
		}
	}

	public bool IsTransmitting
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

	public string LastBlockReason
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

	public int CaptureFramesBuffered
	{
		get
		{
			throw null;
		}
	}

	public int TotalFramesCaptured
	{
		get
		{
			throw null;
		}
	}

	public int TotalFramesEncoded
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

	public int TotalFramesSent
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

	public bool MicrophoneRunning
	{
		get
		{
			throw null;
		}
	}

	public int MicrophoneDeviceCount
	{
		get
		{
			throw null;
		}
	}

	public int LastMicPosition
	{
		get
		{
			throw null;
		}
	}

	public int LastMicAvailableSamples
	{
		get
		{
			throw null;
		}
	}

	public string MicrophoneStatus
	{
		get
		{
			throw null;
		}
	}

	public int MicrophoneClipChannels
	{
		get
		{
			throw null;
		}
	}

	public int MicrophoneClipFrequency
	{
		get
		{
			throw null;
		}
	}

	public string MicrophoneDeviceCaps
	{
		get
		{
			throw null;
		}
	}

	public string ActiveMicrophoneDevice
	{
		get
		{
			throw null;
		}
	}

	public string CaptureBackendName
	{
		get
		{
			throw null;
		}
	}

	public string CaptureBackendList
	{
		get
		{
			throw null;
		}
	}

	public string NoiseSuppressorName
	{
		get
		{
			throw null;
		}
	}

	public string NoiseSuppressorStatus
	{
		get
		{
			throw null;
		}
	}

	public string ForcedProcessingStatus
	{
		get
		{
			throw null;
		}
	}

	public bool NeedsPlaybackReference
	{
		get
		{
			throw null;
		}
	}

	public string GetCaptureDeviceLabel(int index)
	{
		throw null;
	}

	public void Tick(VoiceSettings settings, float deltaTime)
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public void ClearPendingCapture(string reason)
	{
		throw null;
	}

	private void StopCaptureUntilReady(string reason)
	{
		throw null;
	}

	public bool CopySpectrum(float[] destination)
	{
		throw null;
	}

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	private void UpdateNoiseMode(VoiceSettings settings)
	{
		throw null;
	}

	private void DisposeNoiseSuppressor(string status)
	{
		throw null;
	}

	private void ProcessNoiseFailOpen(float[] samples, int length)
	{
		throw null;
	}

	private void EnsureCaptureBackend(VoiceSettings settings)
	{
		throw null;
	}

	private void EnsureNoiseSuppressor(VoiceSettings settings)
	{
		throw null;
	}

	private void BlockAndFallbackNoiseSuppressor(string blockedName, string status)
	{
		throw null;
	}

	private static float CalculateRms(float[] samples, int length)
	{
		throw null;
	}

	private static int CalculateFrameBudget(float deltaTime)
	{
		throw null;
	}

	public VoiceSendPipeline()
	{
		throw null;
	}
}
