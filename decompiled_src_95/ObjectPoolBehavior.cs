using System.Collections.Generic;

public class ObjectPoolBehavior : IObjectPool
{
	public int poolSize;

	private List<PoolableBehavior> inactiveChildren;

	public List<PoolableBehavior> activeChildren;

	public PoolableBehavior Prefab;

	public bool AutoInit;

	public bool DetachOnGet;

	public override int InUse => 0;

	public override int NotInUse => 0;

	public virtual void Awake()
	{
	}

	public void InitPool(PoolableBehavior prefab)
	{
	}

	private void CreateOneInactive(PoolableBehavior prefab)
	{
	}

	public void ReclaimOldest()
	{
	}

	public void ReclaimAll()
	{
	}

	public override T Get<T>()
	{
		return null;
	}

	public override void Reclaim(PoolableBehavior obj)
	{
	}
}
