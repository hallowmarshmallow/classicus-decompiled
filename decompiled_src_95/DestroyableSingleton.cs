using UnityEngine;

public class DestroyableSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	public bool DontDestroy;

	public static bool InstanceExists => false;

	public static T Instance => null;

	public virtual void Awake()
	{
	}

	public virtual void OnDestroy()
	{
	}
}
