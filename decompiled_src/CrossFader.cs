using UnityEngine;

public class CrossFader : ISoundPlayer
{
	public float MaxVolume;

	public AudioClip target;

	public float Duration;

	private float timer;

	private bool didSwitch;

	private string _003CName_003Ek__BackingField;

	private AudioSource _003CPlayer_003Ek__BackingField;

	public string Name
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

	public AudioSource Player
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

	public void Update(float dt)
	{
		throw null;
	}

	public void SetTargetImmediate(AudioClip clip)
	{
		throw null;
	}

	public void SetTarget(AudioClip clip)
	{
		throw null;
	}

	public CrossFader()
	{
		throw null;
	}
}
