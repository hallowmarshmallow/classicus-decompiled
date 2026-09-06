using UnityEngine;

public class DestroyableSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	public bool DontDestroy;

	public static bool InstanceExists
	{
		get
		{
			throw null;
		}
	}

	public static T Instance
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

	public virtual void OnDestroy()
	{
		throw null;
	}

	public DestroyableSingleton()
	{
		throw null;
	}
}
