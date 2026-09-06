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

	public bool Playing
	{
		get
		{
			throw null;
		}
	}

	public bool Paused
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

	public float Speed
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

	public float Time
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

	public float NormalizedTime
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

	public AnimationClip Clip
	{
		get
		{
			throw null;
		}
	}

	public string ClipName
	{
		get
		{
			throw null;
		}
	}

	public void Play(AnimationClip anim, float speed = 1f)
	{
		throw null;
	}

	public void Stop()
	{
		throw null;
	}

	public void Pause()
	{
		throw null;
	}

	public void Resume()
	{
		throw null;
	}

	public AnimationClip GetCurrentAnimation()
	{
		throw null;
	}

	public bool IsPlaying(AnimationClip clip = null)
	{
		throw null;
	}

	public bool IsPlaying(string animName)
	{
		throw null;
	}

	public bool IsPaused()
	{
		throw null;
	}

	public void SetSpeed(float speed)
	{
		throw null;
	}

	public float GetSpeed()
	{
		throw null;
	}

	public float GetTime()
	{
		throw null;
	}

	public void SetTime(float time)
	{
		throw null;
	}

	public float GetNormalisedTime()
	{
		throw null;
	}

	public void SetNormalizedTime(float ratio)
	{
		throw null;
	}

	public void RegisterSpriteAnimNodesComponent(SpriteAnimNodes2 nodes)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void Reset()
	{
		throw null;
	}

	public SpriteAnim2()
	{
		throw null;
	}

	static SpriteAnim2()
	{
		throw null;
	}
}
