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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CIsNullOrWhiteSpace_003Eb__53_0(char c)
		{
			throw null;
		}

		internal string _003C_002Ecctor_003Eb__55_0(int x)
		{
			throw null;
		}
	}

	private static string[] ByteHex;

	public static void TrimEnd(StringBuilder self)
	{
		throw null;
	}

	public static void SetXScale(Transform transform, float x)
	{
		throw null;
	}

	public static void SetAllScale(Transform transform, float scale)
	{
		throw null;
	}

	public static T[] ShuffleCopy<T>(T[] list)
	{
		throw null;
	}

	public static IList<T> Shuffle<T>(IList<T> self, int startAt = 0)
	{
		throw null;
	}

	public static void DestroyAll<T>(IList<T> self) where T : MonoBehaviour
	{
		throw null;
	}

	public static void AddUnique<T>(IList<T> self, T item)
	{
		throw null;
	}

	public static void DestroyAllChildren(GameObject parentObject, string except = "")
	{
		throw null;
	}

	public static string ToTextColor(Color c)
	{
		throw null;
	}

	public static bool HasAnyBit(int self, int bit)
	{
		throw null;
	}

	public static bool HasAnyBit(byte self, byte bit)
	{
		throw null;
	}

	public static bool HasBit(byte self, byte bit)
	{
		throw null;
	}

	public static int IndexOf<T>(T[] self, T item) where T : class
	{
		throw null;
	}

	public static int IndexOfMax<T>(T[] self, Func<T, int> comparer, out bool tie)
	{
		throw null;
	}

	public static void SetAll<T>(IList<T> self, T value)
	{
		throw null;
	}

	public static void AddAll<T>(List<T> self, IList<T> other)
	{
		throw null;
	}

	public static void Shuffle<T>(IList<T> self)
	{
		throw null;
	}

	public static T[] RandomSet<T>(IList<T> self, int length)
	{
		throw null;
	}

	public static void RandomFill<T>(IList<T> self, T[] target)
	{
		throw null;
	}

	public static int RandomIdx<T>(IList<T> self)
	{
		throw null;
	}

	public static T Random<T>(IEnumerable<T> self)
	{
		throw null;
	}

	public static T Random<T>(IList<T> self)
	{
		throw null;
	}

	public static Vector2 Div(Vector2 a, Vector2 b)
	{
		throw null;
	}

	public static Vector3 Mul(Vector3 a, Vector3 b)
	{
		throw null;
	}

	public static Vector3 Inv(Vector3 a)
	{
		throw null;
	}

	public static void ForEach<T>(IList<T> self, Action<T> todo)
	{
		throw null;
	}

	public static int Wrap(int self, int max)
	{
		throw null;
	}

	public static int IndexOf<T>(T[] self, Predicate<T> pred)
	{
		throw null;
	}

	public static float AngleSignedRad(Vector2 vector1, Vector2 vector2)
	{
		throw null;
	}

	public static float AngleSigned(Vector2 vector1, Vector2 vector2)
	{
		throw null;
	}

	public static Vector2 Rotate(Vector2 self, float degrees)
	{
		throw null;
	}

	public static bool IsNullOrWhiteSpace(string s)
	{
		throw null;
	}

	public static Transform[] GetChildren(Transform transform)
	{
		throw null;
	}

	static Extensions()
	{
		throw null;
	}
}
