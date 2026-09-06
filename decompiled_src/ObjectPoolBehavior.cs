using System.Collections.Generic;

public class ObjectPoolBehavior : IObjectPool
{
	public int poolSize;

	private List<PoolableBehavior> inactiveChildren;

	public List<PoolableBehavior> activeChildren;

	public PoolableBehavior Prefab;

	public bool AutoInit;

	public bool DetachOnGet;

	public override int InUse
	{
		get
		{
			throw null;
		}
	}

	public override int NotInUse
	{
		get
		{
			throw null;
		}
	}

	public virtual void Awake()
	{
		throw null;
	}

	public void InitPool(PoolableBehavior prefab)
	{
		throw null;
	}

	private void CreateOneInactive(PoolableBehavior prefab)
	{
		throw null;
	}

	public void ReclaimOldest()
	{
		throw null;
	}

	public void ReclaimAll()
	{
		throw null;
	}

	public override T Get<T>()
	{
		throw null;
	}

	public override void Reclaim(PoolableBehavior obj)
	{
		throw null;
	}

	public ObjectPoolBehavior()
	{
		throw null;
	}
}
