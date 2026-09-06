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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CInitialize_003Eb__160_0(Scene oldScene, Scene scene)
		{
			throw null;
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

	public static VoiceSettings Settings
	{
		get
		{
			throw null;
		}
	}

	public static VoicePolicy Policy
	{
		get
		{
			throw null;
		}
	}

	public static VoiceNetwork Network
	{
		get
		{
			throw null;
		}
	}

	public static uint LocalNetId
	{
		get
		{
			throw null;
		}
	}

	public static bool IsMeetingActive
	{
		get
		{
			throw null;
		}
	}

	public static bool IsHost
	{
		get
		{
			throw null;
		}
	}

	public static bool LocalAccepted
	{
		get
		{
			throw null;
		}
	}

	public static bool CanUseNetwork
	{
		get
		{
			throw null;
		}
	}

	public static bool VoiceIndicatorsEnabled
	{
		get
		{
			throw null;
		}
	}

	public static bool IsLocalVoiceMuted
	{
		get
		{
			throw null;
		}
	}

	public static float LastInputRms
	{
		get
		{
			throw null;
		}
	}

	public static float LastOutputRms
	{
		get
		{
			throw null;
		}
	}

	public static float LastRawMicRms
	{
		get
		{
			throw null;
		}
	}

	public static float LastRawMicPeak
	{
		get
		{
			throw null;
		}
	}

	public static bool IsTransmitting
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteStreamCount
	{
		get
		{
			throw null;
		}
	}

	public static int RemotePacketsReceived
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteFramesDecoded
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteConcealedFrames
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteRecoveredFrames
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteRebufferEvents
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteJitterBufferedFrames
	{
		get
		{
			throw null;
		}
	}

	public static int RemotePlaybackBufferedSamples
	{
		get
		{
			throw null;
		}
	}

	public static long RemoteSamplesQueued
	{
		get
		{
			throw null;
		}
	}

	public static long RemoteSamplesPlayed
	{
		get
		{
			throw null;
		}
	}

	public static int RemotePlaybackUnderruns
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteLastReadSamples
	{
		get
		{
			throw null;
		}
	}

	public static int RemoteLastCallbackSamples
	{
		get
		{
			throw null;
		}
	}

	public static float RemoteLastDecodedRms
	{
		get
		{
			throw null;
		}
	}

	public static float RemoteLastPlayedRms
	{
		get
		{
			throw null;
		}
	}

	public static string LastTransmitStatus
	{
		get
		{
			throw null;
		}
	}

	public static bool MicrophoneRunning
	{
		get
		{
			throw null;
		}
	}

	public static int MicrophoneDeviceCount
	{
		get
		{
			throw null;
		}
	}

	public static string MicrophoneStatus
	{
		get
		{
			throw null;
		}
	}

	public static int MicrophoneClipChannels
	{
		get
		{
			throw null;
		}
	}

	public static int MicrophoneClipFrequency
	{
		get
		{
			throw null;
		}
	}

	public static string MicrophoneDeviceCaps
	{
		get
		{
			throw null;
		}
	}

	public static string OutputBufferStatus
	{
		get
		{
			throw null;
		}
	}

	public static string ActiveMicrophoneDevice
	{
		get
		{
			throw null;
		}
	}

	public static string CaptureBackendName
	{
		get
		{
			throw null;
		}
	}

	public static string CaptureBackendList
	{
		get
		{
			throw null;
		}
	}

	public static string NoiseSuppressorName
	{
		get
		{
			throw null;
		}
	}

	public static string NoiseSuppressorStatus
	{
		get
		{
			throw null;
		}
	}

	public static string ForcedInputProcessingStatus
	{
		get
		{
			throw null;
		}
	}

	public static string PlaybackReferenceStatus
	{
		get
		{
			throw null;
		}
	}

	public static int LastMicPosition
	{
		get
		{
			throw null;
		}
	}

	public static int LastMicAvailableSamples
	{
		get
		{
			throw null;
		}
	}

	public static int CaptureFramesBuffered
	{
		get
		{
			throw null;
		}
	}

	public static int TotalFramesCaptured
	{
		get
		{
			throw null;
		}
	}

	public static int TotalFramesEncoded
	{
		get
		{
			throw null;
		}
	}

	public static int TotalFramesSent
	{
		get
		{
			throw null;
		}
	}

	public static int NetworkFramesSent
	{
		get
		{
			throw null;
		}
	}

	public static int NetworkFramesReceived
	{
		get
		{
			throw null;
		}
	}

	public static int NetworkFramesRouted
	{
		get
		{
			throw null;
		}
	}

	public static string LastNetworkStatus
	{
		get
		{
			throw null;
		}
	}

	public static int WallSegmentCount
	{
		get
		{
			throw null;
		}
	}

	public static int WallColliderCount
	{
		get
		{
			throw null;
		}
	}

	public static string WallBuildStatus
	{
		get
		{
			throw null;
		}
	}

	public static string LastWallSvgPath
	{
		get
		{
			throw null;
		}
	}

	public static bool DiagnosticLoggingEnabled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	static VoiceRuntime()
	{
		throw null;
	}

	public static bool TryGetRemoteSpeakerLevel(uint speakerNetId, out float level, out bool muted)
	{
		throw null;
	}

	public static bool TryGetPlayerVoiceLevel(uint playerNetId, out float level, out bool muted)
	{
		throw null;
	}

	public static bool TryGetVoiceState(uint playerNetId, out VoiceState state)
	{
		throw null;
	}

	public static bool TryCopyPlayerVoiceSpectrum(uint playerNetId, float[] destination, out bool muted)
	{
		throw null;
	}

	public static string GetCaptureDeviceLabel(int index)
	{
		throw null;
	}

	public static void BroadcastMapGeometryForCurrentGame()
	{
		throw null;
	}

	public static void Initialize()
	{
		throw null;
	}

	public static void Tick(float deltaTime)
	{
		throw null;
	}

	public static void ReceiveRemoteFrame(VoicePacket packet, float spatialGain = 1f)
	{
		throw null;
	}

	public static void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source)
	{
		throw null;
	}

	public static void SetPushToTalk(bool pushToTalk, string reason)
	{
		throw null;
	}

	private static void ResetSession()
	{
		throw null;
	}

	public static void ResetNetworkSession(string reason)
	{
		throw null;
	}

	private static void TickDecode(float deltaTime)
	{
		throw null;
	}

	public static string ExportWallSvg()
	{
		throw null;
	}

	private static void UpdateRemoteSpatialGains()
	{
		throw null;
	}

	private static void TickDiagnostics(float deltaTime)
	{
		throw null;
	}
}
