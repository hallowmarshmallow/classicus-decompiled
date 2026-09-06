using System;
using UnityEngine;

public static class AirshipCompat
{
	public static void SetLocalZ(Transform t, float z)
	{
	}

	public static void SetAllGameObjectsActive(Component[] arr, bool isActive)
	{
	}

	public static float NextMinDistance(FloatRange range, float prev, float minDistance)
	{
		return 0f;
	}

	public static float WheelAngle(Vector2 from, Vector2 to)
	{
		return 0f;
	}

	public static int LastIndexOf<T>(T[] arr, Predicate<T> match)
	{
		return 0;
	}

	public static void ResetMoveState(PlayerPhysics physics)
	{
	}

	public static void OpenOverlayMenu(ControllerManager cm, string name, object closeButton = null, object defaultSelection = null, object selectableButtons = null)
	{
	}

	public static void CloseOverlayMenu(ControllerManager cm, string name)
	{
	}
}
