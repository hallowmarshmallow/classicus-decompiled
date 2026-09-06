using System.Collections.Generic;
using Comms.Modules.Voice.Spatial;
using InnerNet;
using UnityEngine;

namespace Comms.Modules.Voice.Networking;

public sealed class VoiceNetwork
{
	private struct AudibilityCacheEntry(bool allowed, float expiresAt)
	{
		private readonly bool _003CAllowed_003Ek__BackingField = false;

		private readonly float _003CExpiresAt_003Ek__BackingField = 0f;

		public bool Allowed => _003CAllowed_003Ek__BackingField;

		public float ExpiresAt => _003CExpiresAt_003Ek__BackingField;
	}

	private readonly VoiceCapabilityRegistry _capabilities;

	private readonly Dictionary<int, float> _strictGraceTimers;

	private readonly Dictionary<ulong, AudibilityCacheEntry> _audibilityCache;

	private readonly List<ClientData> _clientSnapshot;

	private readonly List<VoiceState> _stateSnapshot;

	private readonly List<VoiceWallGeometry.ServerWallSegment> _serverWallSegments;

	private readonly List<Vector2> _serverSnapPoints;

	private bool _helloSent;

	private uint _helloNetId;

	private bool _localAccepted;

	private float _helloResendTimer;

	private bool _loggedFirstSentFrame;

	private bool _loggedFirstReceivedFrame;

	private bool _loggedFirstAcceptedFrame;

	private bool _loggedHello;

	private VoiceMode _lastBroadcastMode;

	private bool _hasBroadcastMode;

	private string _lastGeometryLayoutKey;

	private int _lastGeometrySegmentCount;

	private int _lastGeometrySnapPointCount;

	private float _lastGeometryAttemptAt;

	private int _nextGeometryUploadId;

	private int _003CFramesSent_003Ek__BackingField;

	private int _003CFramesReceived_003Ek__BackingField;

	private int _003CFramesRouted_003Ek__BackingField;

	private string _003CLastNetworkStatus_003Ek__BackingField;

	public bool LocalAccepted => false;

	public int FramesSent
	{
		get
		{
			return _003CFramesSent_003Ek__BackingField;
		}
		private set
		{
			_003CFramesSent_003Ek__BackingField = value;
		}
	}

	public int FramesReceived
	{
		get
		{
			return _003CFramesReceived_003Ek__BackingField;
		}
		private set
		{
			_003CFramesReceived_003Ek__BackingField = value;
		}
	}

	public int FramesRouted
	{
		get
		{
			return _003CFramesRouted_003Ek__BackingField;
		}
		private set
		{
			_003CFramesRouted_003Ek__BackingField = value;
		}
	}

	public string LastNetworkStatus
	{
		get
		{
			return _003CLastNetworkStatus_003Ek__BackingField;
		}
		private set
		{
			_003CLastNetworkStatus_003Ek__BackingField = value;
		}
	}

	private static bool IsHost => false;

	private static VoiceFeatureFlags LocalFeatureFlags => default(VoiceFeatureFlags);

	public VoiceNetwork(VoiceCapabilityRegistry capabilities)
	{
	}

	public void ResetSession()
	{
	}

	public void EnsureHello(float deltaTime)
	{
	}

	public void SendFrame(VoicePacket packet)
	{
	}

	public void TickHostPolicy(float deltaTime)
	{
	}

	public void ReceiveHello(PlayerControl sender, VoiceHello hello)
	{
	}

	public void ReceiveState(PlayerControl sender, VoiceState state)
	{
	}

	public void ReceiveFrame(PlayerControl rpcSender, VoicePacket packet)
	{
	}

	public bool WouldHear(uint speakerNetId)
	{
		return false;
	}

	public bool TryGetCurrentSpatialGain(uint speakerNetId, out float spatialGain)
	{
		spatialGain = default(float);
		return false;
	}

	private bool ShouldDeliver(PlayerControl speaker, PlayerControl listener)
	{
		return false;
	}

	private static bool CanLocalHearSpeaker(PlayerControl speaker, PlayerControl listener)
	{
		return false;
	}

	private bool TryGetAudibility(PlayerControl speaker, PlayerControl listener, out float spatialGain)
	{
		spatialGain = default(float);
		return false;
	}

	private static float CalculateDistanceGain(float distance, float range)
	{
		return 0f;
	}

	private bool TryGetPlayerByNetId(uint netId, out PlayerControl player)
	{
		player = null;
		return false;
	}

	private bool TryGetClientIdByNetId(uint netId, out int clientId)
	{
		clientId = default(int);
		return false;
	}

	private bool IsHostSender(PlayerControl sender)
	{
		return false;
	}

	public void BroadcastMapGeometryForCurrentGame()
	{
	}

	private void BroadcastPolicyModeIfNeeded()
	{
	}

	private void BroadcastMapGeometryIfNeeded()
	{
	}

	private void BroadcastMapGeometryIfNeeded(bool force)
	{
	}

	private void SendAllStatesTo(int clientId)
	{
	}

	private static bool SameState(VoiceState left, VoiceState right)
	{
		return false;
	}

	private bool HasRemoteClients()
	{
		return false;
	}
}
