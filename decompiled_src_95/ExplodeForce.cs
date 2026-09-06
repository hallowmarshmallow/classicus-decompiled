using UnityEngine;

public class ExplodeForce : DestroyableSingleton<ExplodeForce>
{
	public float explosionForce;

	public float explosionRadius;

	public AudioClip Explosion;

	public ParticleSystem Exploded;

	public void Explode()
	{
	}
}
