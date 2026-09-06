using System;
using UnityEngine;

public class KeyboardJoystick : MonoBehaviour, IVirtualJoystick
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__18_0;

		internal void _003COpenSabotageMap_003Eb__18_0(MapBehaviour m)
		{
		}
	}

	private Vector2 del;

	private readonly Controller myController;

	private readonly Collider2D[] hitBuffer;

	private int touchId;

	private const float MicTapSeconds = 0.25f;

	private static float micHoldTime;

	public Vector2 Delta => default(Vector2);

	private static bool RebindInProgress => false;

	private static bool Held(KeybindAction action)
	{
		return false;
	}

	private static bool Pressed(KeybindAction action)
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateMouseMovement()
	{
	}

	private static void HandleHud()
	{
	}

	private static void HandleMic()
	{
	}

	private static void ToggleChat()
	{
	}

	private static bool TryUseVent()
	{
		return false;
	}

	private static void OpenSabotageMap()
	{
	}
}
