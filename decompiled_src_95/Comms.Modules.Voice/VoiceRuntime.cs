using System;
using System.Collections.Generic;
using Comms.Modules.Voice.Audio;
using Comms.Modules.Voice.Networking;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Comms.Modules.Voice;

public static class VoiceRuntime
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction<Scene, Scene> _003C_003E9__160_0;

		internal void _003CInitialize_003Eb__160_0(Scene oldScene, Scene scene)
		{
		}
	}

	private static readonly VoiceCapabilityRegistry CapabilityRegistry;

	private static readonly VoiceSendPipeline SendPipeline;

	private static readonly RemoteVoiceMixer RemoteMixer;

	private static readonly List<uint> RemoteSpeakerSnapshot;

	private static bool _initialized;

	private static float _decodeAccumulator;

	private static float _diagnosticLogTimer;

	private static uint _lastLocalNetId;

	private static int _lastLoggedTxFrames;

	private static int _lastLoggedRemotePackets;

	private static int _lastLoggedRemoteDecoded;

	private static long _lastLoggedRemotePlayed;

	private static bool _hasLoggedRuntimeStatus;

	private static bool _lastLoggedEnabled;

	private static bool _lastLoggedAccepted;

	private static bool _lastLoggedPushToTalk;

	private static string _lastLoggedTransmitStatus;

	private static string _lastLoggedMicrophoneStatus;

	private static string _lastLoggedNetworkStatus;

	private static string _lastLoggedSelectedMicrophone;

	private static string _activeSceneName;

	private static bool _sessionActive;

	private static readonly VoiceSettings _003CSettings_003Ek__BackingField;

	private static readonly VoicePolicy _003CPolicy_003Ek__BackingField;

	private static readonly VoiceNetwork _003CNetwork_003Ek__BackingField;

	private static bool _003CDiagnosticLoggingEnabled_003Ek__BackingField;

	public static VoiceSettings Settings => _003CSettings_003Ek__BackingField;

	public static VoicePolicy Policy => _003CPolicy_003Ek__BackingField;

	public static VoiceNetwork Network => _003CNetwork_003Ek__BackingField;

	public static uint LocalNetId => 0u;

	public static bool IsMeetingActive => false;

	public static bool IsHost => false;

	public static bool LocalAccepted => false;

	public static bool CanUseNetwork => false;

	public static bool VoiceIndicatorsEnabled => false;

	public static bool IsLocalVoiceMuted => false;

	public static float LastInputRms => 0f;

	public static float LastOutputRms => 0f;

	public static float LastRawMicRms => 0f;

	public static float LastRawMicPeak => 0f;

	public static bool IsTransmitting => false;

	public static int RemoteStreamCount => 0;

	public static int RemotePacketsReceived => 0;

	public static int RemoteFramesDecoded => 0;

	public static int RemoteConcealedFrames => 0;

	public static int RemoteRecoveredFrames => 0;

	public static int RemoteRebufferEvents => 0;

	public static int RemoteJitterBufferedFrames => 0;

	public static int RemotePlaybackBufferedSamples => 0;

	public static long RemoteSamplesQueued => 0L;

	public static long RemoteSamplesPlayed => 0L;

	public static int RemotePlaybackUnderruns => 0;

	public static int RemoteLastReadSamples => 0;

	public static int RemoteLastCallbackSamples => 0;

	public static float RemoteLastDecodedRms => 0f;

	public static float RemoteLastPlayedRms => 0f;

	public static string LastTransmitStatus => null;

	public static bool MicrophoneRunning => false;

	public static int MicrophoneDeviceCount => 0;

	public static string MicrophoneStatus => null;

	public static int MicrophoneClipChannels => 0;

	public static int MicrophoneClipFrequency => 0;

	public static string MicrophoneDeviceCaps => null;

	public static string OutputBufferStatus => null;

	public static string ActiveMicrophoneDevice => null;

	public static string CaptureBackendName => null;

	public static string CaptureBackendList => null;

	public static string NoiseSuppressorName => null;

	public static string NoiseSuppressorStatus => null;

	public static string ForcedInputProcessingStatus => null;

	public static string PlaybackReferenceStatus => null;

	public static int LastMicPosition => 0;

	public static int LastMicAvailableSamples => 0;

	public static int CaptureFramesBuffered => 0;

	public static int TotalFramesCaptured => 0;

	public static int TotalFramesEncoded => 0;

	public static int TotalFramesSent => 0;

	public static int NetworkFramesSent => 0;

	public static int NetworkFramesReceived => 0;

	public static int NetworkFramesRouted => 0;

	public static string LastNetworkStatus => null;

	public static int WallSegmentCount => 0;

	public static int WallColliderCount => 0;

	public static string WallBuildStatus => null;

	public static string LastWallSvgPath => null;

	public static bool DiagnosticLoggingEnabled
	{
		get
		{
			return _003CDiagnosticLoggingEnabled_003Ek__BackingField;
		}
		set
		{
			_003CDiagnosticLoggingEnabled_003Ek__BackingField = value;
		}
	}

	static VoiceRuntime()
	{
	}

	public static bool TryGetRemoteSpeakerLevel(uint speakerNetId, out float level, out bool muted)
	{
		level = default(float);
		muted = default(bool);
		return false;
	}

	public static bool TryGetPlayerVoiceLevel(uint playerNetId, out float level, out bool muted)
	{
		level = default(float);
		muted = default(bool);
		return false;
	}

	public static bool TryGetVoiceState(uint playerNetId, out VoiceState state)
	{
		state = default(VoiceState);
		return false;
	}

	public static bool TryCopyPlayerVoiceSpectrum(uint playerNetId, float[] destination, out bool muted)
	{
		muted = default(bool);
		return false;
	}

	public static string GetCaptureDeviceLabel(int index)
	{
		return null;
	}

	public static void BroadcastMapGeometryForCurrentGame()
	{
	}

	public static void Initialize()
	{
	}

	public static void Tick(float deltaTime)
	{
	}

	public static void ReceiveRemoteFrame(VoicePacket packet, float spatialGain = 1f)
	{
	}

	public static void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
	}

	public static void SetPushToTalk(bool pushToTalk, string reason)
	{
	}

	private static void ResetSession()
	{
	}

	public static void ResetNetworkSession(string reason)
	{
	}

	private static void TickDecode(float deltaTime)
	{
	}

	public static string ExportWallSvg()
	{
		return null;
	}

	private static void UpdateRemoteSpatialGains()
	{
	}

	private static void TickDiagnostics(float deltaTime)
	{
	}
}
