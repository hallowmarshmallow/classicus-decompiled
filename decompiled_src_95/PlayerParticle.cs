using UnityEngine;

public class PlayerParticle : PoolableBehavior
{
	public SpriteRenderer myRend;

	public float maxDistance;

	public Vector2 velocity;

	public float angularVelocity;

	private Vector3 lastCamera;

	private Camera _003CFollowCamera_003Ek__BackingField;

	public Camera FollowCamera
	{
		get
		{
			return _003CFollowCamera_003Ek__BackingField;
		}
		set
		{
			_003CFollowCamera_003Ek__BackingField = value;
		}
	}

	public void Update()
	{
	}
}
