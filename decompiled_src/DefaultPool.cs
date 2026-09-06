public class DefaultPool : IObjectPool
{
	private static DefaultPool _instance;

	private static object _lock;

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

	public static bool InstanceExists
	{
		get
		{
			throw null;
		}
	}

	public static DefaultPool Instance
	{
		get
		{
			throw null;
		}
	}

	public void OnDestroy()
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

	public DefaultPool()
	{
		throw null;
	}

	static DefaultPool()
	{
		throw null;
	}
}
