using UnityEngine;

public class TriggeredSound : MonoBehaviour
{
	public AudioClip[] SoundToPlay;

	public FloatRange PitchRange;

	private AudioSource Player;

	public float MaxVolume;

	public float MaxDist;

	public float HitModifier;

	private RaycastHit2D[] volumeBuffer;

	public void Start()
	{
		throw null;
	}

	public void PlaySound()
	{
		throw null;
	}

	private void GetAmbientSoundVolume(AudioSource player)
	{
		throw null;
	}

	public TriggeredSound()
	{
		throw null;
	}
}
