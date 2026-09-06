using System.Collections.Generic;
using Hazel;
using InnerNet;
using UnityEngine;

public class CustomNetworkTransform : InnerNetObject
{
	private const int MAX_QUEUE_DEPTH = 20;

	private const float SNAP_DISTANCE_THRESHOLD = 3f;

	private const float MOVE_EPSILON = 0.0001f;

	private const float MAX_INTERPOLATION_VELOCITY = 20f;

	private const int RUBBERBAND_HIGH_THRESHOLD = 5;

	private const float RUBBERBAND_LOW = 1f;

	private const float RUBBERBAND_HIGH = 1.5f;

	private const float CLOSE_ENOUGH_DISTANCE = 0.01f;

	private const float TERMINAL_PARK_DISTANCE = 0.03f;

	private const float MIN_TERMINAL_SPEED = 2f;

	private const float RUBBERBAND_LERP_SPEED = 3f;

	private const float PASS_POSITION_TOLERANCE = 0.003f;

	private const int STALE_TICK_THRESHOLD = 30;

	private PlayerControl myPlayer;

	private Rigidbody2D body;

	private Queue<Vector2> sendQueue;

	private Queue<Vector2> incomingPosQueue;

	private float rubberbandModifier;

	private float idealSpeed;

	private bool isPaused;

	public ushort lastSequenceId;

	private Vector2 lastPosition;

	private Vector2 lastPosSent;

	private Vector2? tempSnapPosition;

	private int ticksSinceLastIncoming;

	private Vector2 lastAuthorityPosition;

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void SetPaused(bool isPaused)
	{
	}

	public void Halt()
	{
	}

	public void RpcSnapTo(Vector2 position)
	{
	}

	public void SnapTo(Vector2 position)
	{
	}

	public void ClearPositionQueues()
	{
	}

	public void ResetNetworkState()
	{
	}

	public void SnapTo(Vector2 position, ushort minSid)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OwnerFixedUpdate()
	{
	}

	private void RemoteFixedUpdate()
	{
	}

	private void DrainToLatest()
	{
	}

	private bool HasMoved()
	{
		return false;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private Vector2 GetLastQueuedPosition()
	{
		return default(Vector2);
	}

	private void MoveTowardNextPoint()
	{
	}

	private void SkipExcessiveFrames()
	{
	}

	private bool ShouldExtendCurrentFrame(Vector2 nextPos, Vector2 currentPos)
	{
		return false;
	}

	private bool DidPassPosition(Vector2 nextPos, Vector2 lastPos, Vector2 currentPos)
	{
		return false;
	}

	private void SetMovementSmoothingModifier()
	{
	}

	public int GetIncomingQueueSize()
	{
		return 0;
	}
}
