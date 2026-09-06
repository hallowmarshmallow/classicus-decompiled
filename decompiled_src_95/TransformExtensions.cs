using UnityEngine;

public static class TransformExtensions
{
	public static Transform FindDeepChild(Transform parent, string childName)
	{
		return null;
	}

	public static bool FindOut<T>(Transform parent, string name, out T component) where T : Component
	{
		component = null;
		return false;
	}
}
