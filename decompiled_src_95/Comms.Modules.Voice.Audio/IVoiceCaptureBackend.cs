using System;

namespace Comms.Modules.Voice.Audio;

public interface IVoiceCaptureBackend : IDisposable
{
	string BackendName { get; }

	bool IsRunning { get; }

	int DeviceCount { get; }

	int LastMicPosition { get; }

	int LastAvailableSamples { get; }

	int TotalFramesCaptured { get; }

	string LastStatus { get; }

	float LastRawRms { get; }

	float LastRawPeak { get; }

	int ClipChannels { get; }

	int ClipFrequency { get; }

	string LastDeviceCaps { get; }

	string ActiveDeviceLabel { get; }

	string GetDeviceLabel(int index);

	void Poll(FloatRingBuffer destination, VoiceSettings settings, int maxFrames);

	void Stop();
}
