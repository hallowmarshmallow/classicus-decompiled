using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CycleReactorMinigame : Minigame
{
	private Transform _barMask;

	private List<float> _deltas;

	public AudioClip CycleAudio;

	private bool _dragging;

	private Transform _handle;

	private Transform _handleArm;

	private PolygonCollider2D _handleCollider;

	private float _lastTotalAngle;

	private Camera _mainCam;

	private Transform _needle;

	private Vector2 _offset;

	private Vector3 _originalMaskPos;

	private float _prevAngle;

	private float _rpm;

	private TextMeshPro _text;

	private float _timer;

	private float _totalAngle;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private float ConstantVolumeDynamics(AudioSource audioSource, float time)
	{
		return 0f;
	}

	private void CycleSound(AudioSource source, float t)
	{
	}
}
