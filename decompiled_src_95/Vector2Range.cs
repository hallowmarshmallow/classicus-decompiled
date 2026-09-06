using System;
using UnityEngine;

[Serializable]
public struct Vector2Range
{
	public Vector2 min;

	public Vector2 max;

	public void LerpUnclamped(ref Vector3 output, float t, float z)
	{
	}

	public Vector2 Next()
	{
		return default(Vector2);
	}

	public static Vector2 NextEdge()
	{
		return default(Vector2);
	}
}
