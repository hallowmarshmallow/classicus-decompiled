using UnityEngine;

public class OneWayShadows : MonoBehaviour
{
	public Collider2D RoomCollider;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public bool IsIgnored(LightSource lightSource)
	{
		return false;
	}
}
