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

	public string BackendName => null;

	public bool IsRunning => false;

	public int DeviceCount => 0;

	public int LastMicPosition
	{
		get
		{
			return _003CLastMicPosition_003Ek__BackingField;
		}
		private set
		{
			_003CLastMicPosition_003Ek__BackingField = value;
		}
	}

	public int LastAvailableSamples
	{
		get
		{
			return _003CLastAvailableSamples_003Ek__BackingField;
		}
		private set
		{
			_003CLastAvailableSamples_003Ek__BackingField = value;
		}
	}

	public int TotalFramesCaptured
	{
		get
		{
			return _003CTotalFramesCaptured_003Ek__BackingField;
		}
		private set
		{
			_003CTotalFramesCaptured_003Ek__BackingField = value;
		}
	}

	public string LastStatus
	{
		get
		{
			return _003CLastStatus_003Ek__BackingField;
		}
		private set
		{
			_003CLastStatus_003Ek__BackingField = value;
		}
	}

	public float LastRawRms
	{
		get
		{
			return _003CLastRawRms_003Ek__BackingField;
		}
		private set
		{
			_003CLastRawRms_003Ek__BackingField = value;
		}
	}

	public float LastRawPeak
	{
		get
		{
			return _003CLastRawPeak_003Ek__BackingField;
		}
		private set
		{
			_003CLastRawPeak_003Ek__BackingField = value;
		}
	}

	public int ClipChannels => 0;

	public int ClipFrequency => 0;

	public string LastDeviceCaps
	{
		get
		{
			return _003CLastDeviceCaps_003Ek__BackingField;
		}
		private set
		{
			_003CLastDeviceCaps_003Ek__BackingField = value;
		}
	}

	public string ActiveDeviceLabel => null;

	public bool EnsureStarted(string requestedDeviceName)
	{
		return false;
	}

	public void Stop()
	{
	}

	public void Poll(FloatRingBuffer destination, VoiceSettings settings, int maxFrames)
	{
	}

	public string GetDeviceLabel(int index)
	{
		return null;
	}

	private void Poll(FloatRingBuffer destination, string requestedDeviceName, int maxFrames)
	{
	}

	private float[] MixToMonoAndMeasure(int floatsToRead)
	{
		return null;
	}

	private void EnsureScratchCapacity(int length)
	{
	}

	private void ReadDeviceCaps(string deviceName)
	{
	}

	private AudioClip StartMicrophone(string deviceName)
	{
		return null;
	}

	private static int[] GetStartFrequencies()
	{
		return null;
	}

	private static bool HasTriedFrequency(int[] frequencies, int currentIndex, int frequency)
	{
		return false;
	}

	private void LogDevices()
	{
	}

	private bool EnsureAndroidMicrophonePermission()
	{
		return false;
	}

	private static bool CanReadMicrophoneDevices()
	{
		return false;
	}

	private static string[] GetMicrophoneDevices()
	{
		return null;
	}

	private static string NormalizeDeviceName(string deviceName)
	{
		return null;
	}

	private static bool DeviceEquals(string left, string right)
	{
		return false;
	}

	private static bool ContainsDevice(string[] devices, string deviceName)
	{
		return false;
	}

	public void Dispose()
	{
	}
}
