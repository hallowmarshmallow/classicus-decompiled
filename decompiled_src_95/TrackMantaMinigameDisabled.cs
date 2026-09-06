using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrackMantaMinigameDisabled : Minigame
{
	private const float LERP_TIME = 0.3f;

	private const float MAXIMUM_ROTATION_PER_SEC = 135f;

	private const float SWIM_SPEED = 17.76f;

	private const float TIME_TO_TRACK = 5f;

	private const string TRACKING_FORMAT = "Tracking: {0}%";

	private readonly List<Vector2> _positions;

	private bool _amTracking;

	private Vector2 _lastPosition;

	private float _lerpTimer;

	private ClickableSprite _mantaButton;

	private Transform _mantaRay;

	private Vector2 _nextPosition;

	private bool _outOfRange;

	private TextMeshPro[] _textMeshPros;

	private float _timeTracked;

	private ClickableSprite _trackingCollider;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void GetNextWaypoint()
	{
	}

	public void TurnToVector(Vector2 location)
	{
	}

	private void _003CStart_003Eb__16_0()
	{
	}

	private void _003CStart_003Eb__16_1()
	{
	}

	private void _003CStart_003Eb__16_2()
	{
	}

	private void _003CStart_003Eb__16_3()
	{
	}
}
