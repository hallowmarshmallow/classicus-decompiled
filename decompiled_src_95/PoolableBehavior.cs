using UnityEngine;

public class PoolableBehavior : MonoBehaviour
{
	public IObjectPool OwnerPool;

	public virtual void Reset()
	{
	}

	public void Awake()
	{
	}
}
