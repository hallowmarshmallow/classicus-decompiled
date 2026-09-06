using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class Extensions
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<char, bool> _003C_003E9__53_0;

		internal bool _003CIsNullOrWhiteSpace_003Eb__53_0(char c)
		{
			return false;
		}

		internal string _003C_002Ecctor_003Eb__55_0(int x)
		{
			return null;
		}
	}

	private static string[] ByteHex;

	public static void TrimEnd(StringBuilder self)
	{
	}

	public static void SetXScale(Transform transform, float x)
	{
	}

	public static void SetAllScale(Transform transform, float scale)
	{
	}

	public static T[] ShuffleCopy<T>(T[] list)
	{
		return null;
	}

	public static IList<T> Shuffle<T>(IList<T> self, int startAt = 0)
	{
		return null;
	}

	public static void DestroyAll<T>(IList<T> self) where T : MonoBehaviour
	{
	}

	public static void AddUnique<T>(IList<T> self, T item)
	{
	}

	public static void DestroyAllChildren(GameObject parentObject, string except = "")
	{
	}

	public static string ToTextColor(Color c)
	{
		return null;
	}

	public static bool HasAnyBit(int self, int bit)
	{
		return false;
	}

	public static bool HasAnyBit(byte self, byte bit)
	{
		return false;
	}

	public static bool HasBit(byte self, byte bit)
	{
		return false;
	}

	public static int IndexOf<T>(T[] self, T item) where T : class
	{
		return 0;
	}

	public static int IndexOfMax<T>(T[] self, Func<T, int> comparer, out bool tie)
	{
		tie = default(bool);
		return 0;
	}

	public static void SetAll<T>(IList<T> self, T value)
	{
	}

	public static void AddAll<T>(List<T> self, IList<T> other)
	{
	}

	public static void Shuffle<T>(IList<T> self)
	{
	}

	public static T[] RandomSet<T>(IList<T> self, int length)
	{
		return null;
	}

	public static void RandomFill<T>(IList<T> self, T[] target)
	{
	}

	public static int RandomIdx<T>(IList<T> self)
	{
		return 0;
	}

	public static T Random<T>(IEnumerable<T> self)
	{
		return default(T);
	}

	public static T Random<T>(IList<T> self)
	{
		return default(T);
	}

	public static Vector2 Div(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	public static Vector3 Mul(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	public static Vector3 Inv(Vector3 a)
	{
		return default(Vector3);
	}

	public static void ForEach<T>(IList<T> self, Action<T> todo)
	{
	}

	public static int Wrap(int self, int max)
	{
		return 0;
	}

	public static int IndexOf<T>(T[] self, Predicate<T> pred)
	{
		return 0;
	}

	public static float AngleSignedRad(Vector2 vector1, Vector2 vector2)
	{
		return 0f;
	}

	public static float AngleSigned(Vector2 vector1, Vector2 vector2)
	{
		return 0f;
	}

	public static Vector2 Rotate(Vector2 self, float degrees)
	{
		return default(Vector2);
	}

	public static bool IsNullOrWhiteSpace(string s)
	{
		return false;
	}

	public static Transform[] GetChildren(Transform transform)
	{
		return null;
	}
}
