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
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	public void ResetSequence()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	private void Resolve()
	{
	}

	private void Apply(float speed)
	{
	}

	private float GetCycleLength()
	{
		return 0f;
	}
}
