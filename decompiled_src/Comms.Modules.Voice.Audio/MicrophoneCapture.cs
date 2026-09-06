using System;
using UnityEngine;

namespace Comms.Modules.Voice.Audio;

public sealed class MicrophoneCapture : IVoiceCaptureBackend, IDisposable
{
	private float[] _scratch;

	private readonly float[] _monoFrame;

	private AudioClip _clip;

	private int _lastMicPosition;

	private int _clipChannels;

	private int _clipFrequency;

	private bool _running;

	private bool _loggedDevices;

	private bool _loggedNoDevices;

	private bool _loggedStartFailure;

	private bool _loggedStartSuccess;

	private bool _loggedFirstSamples;

	private bool _requestedAndroidMicrophonePermission;

	private string _activeDeviceName;

	private string _requestedDeviceName;

	private string _lastStartFailureMessage;

	private int _lastLoggedDeviceCount;

	private int _003CLastMicPosition_003Ek__BackingField;

	private int _003CLastAvailableSamples_003Ek__BackingField;

	private int _003CTotalFramesCaptured_003Ek__BackingField;

	private string _003CLastStatus_003Ek__BackingField;

	private float _003CLastRawRms_003Ek__BackingField;

	private float _003CLastRawPeak_003Ek__BackingField;

	private string _003CLastDeviceCaps_003Ek__BackingField;

	public string BackendName
	{
		get
		{
			throw null;
		}
	}

	public bool IsRunning
	{
		get
		{
			throw null;
		}
	}

	public int DeviceCount
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
		private set
		{
			throw null;
		}
	}

	public int LastAvailableSamples
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

	public int TotalFramesCaptured
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

	public string LastStatus
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

	public float LastRawRms
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

	public float LastRawPeak
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

	public int ClipChannels
	{
		get
		{
			throw null;
		}
	}

	public int ClipFrequency
	{
		get
		{
			throw null;
		}
	}

	public string LastDeviceCaps
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

	public string ActiveDeviceLabel
	{
		get
		{
			throw null;
		}
	}

	public bool EnsureStarted(string requestedDeviceName)
	{
		throw null;
	}

	public void Stop()
	{
		throw null;
	}

	public void Poll(FloatRingBuffer destination, VoiceSettings settings, int maxFrames)
	{
		throw null;
	}

	public string GetDeviceLabel(int index)
	{
		throw null;
	}

	private void Poll(FloatRingBuffer destination, string requestedDeviceName, int maxFrames)
	{
		throw null;
	}

	private float[] MixToMonoAndMeasure(int floatsToRead)
	{
		throw null;
	}

	private void EnsureScratchCapacity(int length)
	{
		throw null;
	}

	private void ReadDeviceCaps(string deviceName)
	{
		throw null;
	}

	private AudioClip StartMicrophone(string deviceName)
	{
		throw null;
	}

	private static int[] GetStartFrequencies()
	{
		throw null;
	}

	private static bool HasTriedFrequency(int[] frequencies, int currentIndex, int frequency)
	{
		throw null;
	}

	private void LogDevices()
	{
		throw null;
	}

	private bool EnsureAndroidMicrophonePermission()
	{
		throw null;
	}

	private static bool CanReadMicrophoneDevices()
	{
		throw null;
	}

	private static string[] GetMicrophoneDevices()
	{
		throw null;
	}

	private static string NormalizeDeviceName(string deviceName)
	{
		throw null;
	}

	private static bool DeviceEquals(string left, string right)
	{
		throw null;
	}

	private static bool ContainsDevice(string[] devices, string deviceName)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	public MicrophoneCapture()
	{
		throw null;
	}
}
