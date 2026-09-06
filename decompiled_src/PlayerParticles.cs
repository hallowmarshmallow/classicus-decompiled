using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
	public PlayerParticleInfo[] Sprites;

	public FloatRange velocity;

	public FloatRange scale;

	public ObjectPoolBehavior pool;

	public float StartRadius;

	public Camera FollowCamera;

	private RandomFill<PlayerParticleInfo> fill;

	private const int MaxSpawnsPerFrame = 3;

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void PlacePlayer(PlayerParticle part, bool initial)
	{
		throw null;
	}

	public PlayerParticles()
	{
		throw null;
	}
}
