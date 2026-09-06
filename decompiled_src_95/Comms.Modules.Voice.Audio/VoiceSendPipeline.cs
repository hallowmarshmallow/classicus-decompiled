using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Comms.Modules.Voice.Audio;

public sealed class VoiceSendPipeline : IDisposable
{
	private sealed class Snapshot
	{
		public bool Transmit;

		public string BlockReason;

		public float InputGain;

		public VoicePacketFlags Flags;

		public uint LocalNetId;

		public bool NoiseEnabled;

		public string NoiseBackend;
	}

	private readonly object _stateLock;

	private readonly FloatRingBuffer _captureRing;

	private readonly ConcurrentQueue<VoicePacket> _outbound;

	private readonly AutoResetEvent _wake;

	private readonly VoiceDspProcessor _dsp;

	private readonly OpusVoiceEncoder _encoder;

	private readonly VoiceSpectrumAnalyzer _spectrum;

	private readonly float[] _pcmFrame;

	private readonly float[] _noiseBypassScratch;

	private readonly byte[] _opusScratch;

	private readonly HashSet<string> _blockedNoiseSuppressors;

	private IVoiceCaptureBackend _capture;

	private IVoiceNoiseSuppressor _noiseSuppressor;

	private Thread _worker;

	private bool _workerStop;

	private Snapshot _snapshot;

	private long _lastSentTimestamp;

	private ushort _sequence;

	private bool _loggedFirstSend;

	private bool _lastNoiseReductionEnabled;

	private string _lastRequestedMicrophoneDevice;

	private string _activeCaptureBackendName;

	private string _activeNoiseSuppressorName;

	private string _lastNoiseReductionBackend;

	private string _noiseSuppressorStatus;

	private bool _loggedRequiredSlowSuppressor;

	private int _requiredSlowFrameStreak;

	private bool _loggedRequiredFailureSuppressor;

	private string _003CLastBlockReason_003Ek__BackingField;

	private int _003CTotalFramesEncoded_003Ek__BackingField;

	private int _003CTotalFramesSent_003Ek__BackingField;

	public float LastRms => 0f;

	public float LastOutputRms => 0f;

	public float LastRawMicRms => 0f;

	public float LastRawMicPeak => 0f;

	public bool IsTransmitting => false;

	public string LastBlockReason
	{
		get
		{
			return _003CLastBlockReason_003Ek__BackingField;
		}
		private set
		{
			_003CLastBlockReason_003Ek__BackingField = value;
		}
	}

	public int CaptureFramesBuffered => 0;

	public int TotalFramesCaptured => 0;

	public int TotalFramesEncoded
	{
		get
		{
			return _003CTotalFramesEncoded_003Ek__BackingField;
		}
		private set
		{
			_003CTotalFramesEncoded_003Ek__BackingField = value;
		}
	}

	public int TotalFramesSent
	{
		get
		{
			return _003CTotalFramesSent_003Ek__BackingField;
		}
		private set
		{
			_003CTotalFramesSent_003Ek__BackingField = value;
		}
	}

	public bool MicrophoneRunning => false;

	public int MicrophoneDeviceCount => 0;

	public int LastMicPosition => 0;

	public int LastMicAvailableSamples => 0;

	public string MicrophoneStatus => null;

	public int MicrophoneClipChannels => 0;

	public int MicrophoneClipFrequency => 0;

	public string MicrophoneDeviceCaps => null;

	public string ActiveMicrophoneDevice => null;

	public string CaptureBackendName => null;

	public string CaptureBackendList => null;

	public string NoiseSuppressorName => null;

	public string NoiseSuppressorStatus => null;

	public string ForcedProcessingStatus => null;

	public bool NeedsPlaybackReference => false;

	public string GetCaptureDeviceLabel(int index)
	{
		return null;
	}

	public void Tick(VoiceSettings settings, float deltaTime)
	{
	}

	public void Reset()
	{
	}

	public void ClearPendingCapture(string reason)
	{
	}

	private void StopCaptureUntilReady(string reason)
	{
	}

	public bool CopySpectrum(float[] destination)
	{
		return false;
	}

	public void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
	}

	public void Dispose()
	{
	}

	private void PublishSnapshot(VoiceSettings settings)
	{
	}

	private void EnsureWorker()
	{
	}

	private void WorkerLoop()
	{
	}

	private void ProcessPending()
	{
	}

	private void DrainOutbound()
	{
	}

	private void ClearOutbound()
	{
	}

	private void UpdateNoiseMode(Snapshot snapshot)
	{
	}

	private void DisposeNoiseSuppressor(string status)
	{
	}

	private void ProcessNoiseFailOpen(float[] samples, int length)
	{
	}

	private void EnsureCaptureBackend(VoiceSettings settings)
	{
	}

	private IVoiceNoiseSuppressorFactory ResolveUnblocked(string requestedName)
	{
		return null;
	}

	private void EnsureNoiseSuppressor(Snapshot snapshot)
	{
	}

	private void BlockAndFallbackNoiseSuppressor(string blockedName, string status)
	{
	}

	private static float CalculateRms(float[] samples, int length)
	{
		return 0f;
	}

	private static int CalculateFrameBudget(float deltaTime)
	{
		return 0;
	}
}
