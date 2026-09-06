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

	public void SetTarget(AudioClip clip, GetDynamicsFunction volumeFunc)
	{
		throw null;
	}

	public DynamicSound()
	{
		throw null;
	}
}
