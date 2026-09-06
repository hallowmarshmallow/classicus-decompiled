using System.Collections.Generic;
using Comms.Modules.Voice.Spatial;
using InnerNet;
using UnityEngine;

namespace Comms.Modules.Voice.Networking;

public sealed class VoiceNetwork
{
	private struct AudibilityCacheEntry
	{
		private readonly bool _003CAllowed_003Ek__BackingField;

		private readonly float _003CExpiresAt_003Ek__BackingField;

		public bool Allowed
		{
			get
			{
				throw null;
			}
		}

		public float ExpiresAt
		{
			get
			{
				throw null;
			}
		}

		public AudibilityCacheEntry(bool allowed, float expiresAt)
		{
			throw null;
		}
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

	public bool LocalAccepted
	{
		get
		{
			throw null;
		}
	}

	public int FramesSent
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

	public int FramesReceived
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

	public int FramesRouted
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

	public string LastNetworkStatus
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

	private static bool IsHost
	{
		get
		{
			throw null;
		}
	}

	private static VoiceFeatureFlags LocalFeatureFlags
	{
		get
		{
			throw null;
		}
	}

	public VoiceNetwork(VoiceCapabilityRegistry capabilities)
	{
		throw null;
	}

	public void ResetSession()
	{
		throw null;
	}

	public void EnsureHello(float deltaTime)
	{
		throw null;
	}

	public void SendFrame(VoicePacket packet)
	{
		throw null;
	}

	public void TickHostPolicy(float deltaTime)
	{
		throw null;
	}

	public void ReceiveHello(PlayerControl sender, VoiceHello hello)
	{
		throw null;
	}

	public void ReceiveState(PlayerControl sender, VoiceState state)
	{
		throw null;
	}

	public void ReceiveFrame(PlayerControl rpcSender, VoicePacket packet)
	{
		throw null;
	}

	public bool WouldHear(uint speakerNetId)
	{
		throw null;
	}

	public bool TryGetCurrentSpatialGain(uint speakerNetId, out float spatialGain)
	{
		throw null;
	}

	private bool ShouldDeliver(PlayerControl speaker, PlayerControl listener)
	{
		throw null;
	}

	private static bool CanLocalHearSpeaker(PlayerControl speaker, PlayerControl listener)
	{
		throw null;
	}

	private bool TryGetAudibility(PlayerControl speaker, PlayerControl listener, out float spatialGain)
	{
		throw null;
	}

	private static float CalculateDistanceGain(float distance, float range)
	{
		throw null;
	}

	private bool TryGetPlayerByNetId(uint netId, out PlayerControl player)
	{
		throw null;
	}

	private bool TryGetClientIdByNetId(uint netId, out int clientId)
	{
		throw null;
	}

	private bool IsHostSender(PlayerControl sender)
	{
		throw null;
	}

	public void BroadcastMapGeometryForCurrentGame()
	{
		throw null;
	}

	private void BroadcastPolicyModeIfNeeded()
	{
		throw null;
	}

	private void BroadcastMapGeometryIfNeeded()
	{
		throw null;
	}

	private void BroadcastMapGeometryIfNeeded(bool force)
	{
		throw null;
	}

	private void SendAllStatesTo(int clientId)
	{
		throw null;
	}

	private static bool SameState(VoiceState left, VoiceState right)
	{
		throw null;
	}

	private bool HasRemoteClients()
	{
		throw null;
	}
}
