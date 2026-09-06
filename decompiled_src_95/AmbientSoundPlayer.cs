using UnityEngine;

public class AmbientSoundPlayer : MonoBehaviour
{
	public AudioClip AmbientSound;

	public Collider2D[] HitAreas;

	public float MaxVolume;

	public void Start()
	{
	}

	private void Dynamics(AudioSource source, float dt)
	{
	}

	public void OnDestroy()
	{
	}
}
