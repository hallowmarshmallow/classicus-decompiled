using System.Collections.Generic;
using UnityEngine;

namespace PowerTools;

public class SpriteAnim : SpriteAnimEventHandler
{
	private static readonly string STATE_NAME;

	private static readonly string CONTROLLER_PATH;

	public AnimationClip m_defaultAnim;

	private static RuntimeAnimatorController m_sharedAnimatorController;

	private Animator m_animator;

	private AnimatorOverrideController m_controller;

	private SpriteAnimNodes m_nodes;

	private List<KeyValuePair<AnimationClip, AnimationClip>> m_clipPairList;

	private AnimationClip m_currAnim;

	private float m_speed;

	public bool Playing => false;

	public bool Paused
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int FrameTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NormalizedTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AnimationClip Clip => null;

	public string ClipName => null;

	public void Play(AnimationClip anim = null, float speed = 1f)
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public AnimationClip GetCurrentAnimation()
	{
		return null;
	}

	public bool IsPlaying(AnimationClip clip = null)
	{
		return false;
	}

	public bool IsPlaying(string animName)
	{
		return false;
	}

	public bool IsPaused()
	{
		return false;
	}

	public void SetSpeed(float speed)
	{
	}

	public float GetSpeed()
	{
		return 0f;
	}

	public float GetTime()
	{
		return 0f;
	}

	public void SetTime(float time)
	{
	}

	public float GetNormalisedTime()
	{
		return 0f;
	}

	public void SetNormalizedTime(float ratio)
	{
	}

	private void Awake()
	{
	}

	private void Reset()
	{
	}
}
