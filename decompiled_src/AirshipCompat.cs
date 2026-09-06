using System;
using UnityEngine;

public static class AirshipCompat
{
	public static void SetLocalZ(Transform t, float z)
	{
		throw null;
	}

	public static void SetAllGameObjectsActive(Component[] arr, bool isActive)
	{
		throw null;
	}

	public static float NextMinDistance(FloatRange range, float prev, float minDistance)
	{
		throw null;
	}

	public static float WheelAngle(Vector2 from, Vector2 to)
	{
		throw null;
	}

	public static int LastIndexOf<T>(T[] arr, Predicate<T> match)
	{
		throw null;
	}

	public static void ResetMoveState(PlayerPhysics physics)
	{
		throw null;
	}

	public static void OpenOverlayMenu(ControllerManager cm, string name, object closeButton = null, object defaultSelection = null, object selectableButtons = null)
	{
		throw null;
	}

	public static void CloseOverlayMenu(ControllerManager cm, string name)
	{
		throw null;
	}
}
