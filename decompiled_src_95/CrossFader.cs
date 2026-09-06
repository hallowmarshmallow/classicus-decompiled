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
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public AudioSource Player
	{
		get
		{
			return _003CPlayer_003Ek__BackingField;
		}
		set
		{
			_003CPlayer_003Ek__BackingField = value;
		}
	}

	public void Update(float dt)
	{
	}

	public void SetTargetImmediate(AudioClip clip)
	{
	}

	public void SetTarget(AudioClip clip)
	{
	}
}
