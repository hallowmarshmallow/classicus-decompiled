using UnityEngine;

public class RaycastAmbientSoundPlayer : MonoBehaviour
{
	public AudioClip AmbientSound;

	public float AmbientVolume;

	public float AmbientMaxDist;

	public float HitModifier;

	private float ambientVolume;

	private float t;

	private RaycastHit2D[] volumeBuffer;

	public void Start()
	{
	}

	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}

	private void _003CStart_003Eb__7_0(AudioSource player, float dt)
	{
	}
}
