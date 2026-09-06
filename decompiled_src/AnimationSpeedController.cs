using System;
using PowerTools;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
	[Serializable]
	public struct SpeedKeyframe
	{
		public float Time;

		public float Speed;

		public bool Lerp;

		public float LerpDuration;
	}

	public GameObject Target;

	public float BaseSpeed;

	public SpeedKeyframe[] Keyframes;

	public bool Loop;

	public float LoopAfterSeconds;

	private SpriteAnim _spriteAnim;

	private Animator _animator;

	private float _elapsed;

	private int _nextKeyframeIndex;

	private float _lerpFromSpeed;

	private float _lerpToSpeed;

	private float _lerpTimer;

	private float _lerpDuration;

	private bool _lerping;

	private float _currentSpeed;

	private bool _warned;

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void ResetSequence()
	{
		throw null;
	}

	public void SetSpeed(float speed)
	{
		throw null;
	}

	private void Resolve()
	{
		throw null;
	}

	private void Apply(float speed)
	{
		throw null;
	}

	private float GetCycleLength()
	{
		throw null;
	}

	public AnimationSpeedController()
	{
		throw null;
	}
}
