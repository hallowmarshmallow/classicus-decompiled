public class DefaultPool : IObjectPool
{
	private static DefaultPool _instance;

	private static object _lock;

	public override int InUse => 0;

	public override int NotInUse => 0;

	public static bool InstanceExists => false;

	public static DefaultPool Instance => null;

	public void OnDestroy()
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
