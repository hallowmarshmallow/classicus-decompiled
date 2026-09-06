using UnityEngine;

public class DynamicSound : ISoundPlayer
{
	public delegate void GetDynamicsFunction(AudioSource source, float dt);

	public GetDynamicsFunction volumeFunc;

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

	public void SetTarget(AudioClip clip, GetDynamicsFunction volumeFunc)
	{
	}
}
