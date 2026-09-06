using UnityEngine;

namespace KlassicHideNSeek;

internal sealed class HnSPingBehaviour : MonoBehaviour
{
	public Vector3 target;

	public float perc;

	public float MaxScale;

	public bool alwaysMaxSize;

	public bool AmSeeker;

	public float spawnTime;

	public float lifeTime;

	public SpriteRenderer image;

	private float _minDistanceToShowArrow;

	private const float FadeTime = 0.18f;

	private Camera _cam;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	public void UpdatePosition()
	{
	}

	public void SetImageEnabled(bool isOn)
	{
	}

	private static bool Between(float value, float min, float max)
	{
		return false;
	}

	public static Sprite CreateRedGlowSprite()
	{
		return null;
	}
}
