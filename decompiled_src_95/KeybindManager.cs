using System.Collections.Generic;
using UnityEngine;

public static class KeybindManager
{
	private static readonly KeyCode[] Defaults;

	private static KeyCode[] _binds;

	private static readonly HashSet<KeyCode> Reserved;

	private static void EnsureLoaded()
	{
	}

	public static KeyCode Get(KeybindAction action)
	{
		return default(KeyCode);
	}

	public static KeyCode GetDefault(KeybindAction action)
	{
		return default(KeyCode);
	}

	public static bool IsReserved(KeyCode key)
	{
		return false;
	}

	public static bool Set(KeybindAction action, KeyCode key)
	{
		return false;
	}

	private static bool IsUseGroup(int index)
	{
		return false;
	}

	private static bool IsSameMovementPair(int a, int b)
	{
		return false;
	}

	public static bool ResetToDefault(KeybindAction action)
	{
		return false;
	}

	private static void Save()
	{
	}

	public static string DisplayName(KeyCode key)
	{
		return null;
	}
}
