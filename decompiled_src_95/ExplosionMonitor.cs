using UnityEngine;

public class ExplosionMonitor : MonoBehaviour
{
	private Rigidbody2D _003CParentRigidbody_003Ek__BackingField;

	public float explosionThreshold;

	public Rigidbody2D ParentRigidbody
	{
		get
		{
			return _003CParentRigidbody_003Ek__BackingField;
		}
		set
		{
			_003CParentRigidbody_003Ek__BackingField = value;
		}
	}

	private void Update()
	{
	}
}
