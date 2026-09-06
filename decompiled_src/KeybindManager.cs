using System.Collections.Generic;
using UnityEngine;

public static class KeybindManager
{
	private static readonly KeyCode[] Defaults;

	private static KeyCode[] _binds;

	private static readonly HashSet<KeyCode> Reserved;

	private static void EnsureLoaded()
	{
		throw null;
	}

	public static KeyCode Get(KeybindAction action)
	{
		throw null;
	}

	public static KeyCode GetDefault(KeybindAction action)
	{
		throw null;
	}

	public static bool IsReserved(KeyCode key)
	{
		throw null;
	}

	public static bool Set(KeybindAction action, KeyCode key)
	{
		throw null;
	}

	private static bool IsUseGroup(int index)
	{
		throw null;
	}

	private static bool IsSameMovementPair(int a, int b)
	{
		throw null;
	}

	public static bool ResetToDefault(KeybindAction action)
	{
		throw null;
	}

	private static void Save()
	{
		throw null;
	}

	public static string DisplayName(KeyCode key)
	{
		throw null;
	}

	static KeybindManager()
	{
		throw null;
	}
}
