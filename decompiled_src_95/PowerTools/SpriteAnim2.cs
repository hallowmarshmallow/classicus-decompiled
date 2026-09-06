using System.Collections.Generic;
using UnityEngine;

namespace PowerTools;

public class SpriteAnim2 : SpriteAnimEventHandler
{
	private static readonly int STATE_NAME_HASH;

	private static readonly string CONTROLLER_PATH;

	private AnimationClip m_defaultAnim;

	private static RuntimeAnimatorController m_sharedAnimatorController;

	private Animator m_animator;

	private AnimatorOverrideController m_controller;

	private SpriteAnimNodes2 m_nodes;

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

	public void Play(AnimationClip anim, float speed = 1f)
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

	public void RegisterSpriteAnimNodesComponent(SpriteAnimNodes2 nodes)
	{
	}

	private void Awake()
	{
	}

	private void Reset()
	{
	}
}
