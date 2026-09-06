using System;
using UnityEngine;

public class KeyboardJoystick : MonoBehaviour, IVirtualJoystick
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__14_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003COpenSabotageMap_003Eb__14_0(MapBehaviour m)
		{
			throw null;
		}
	}

	private Vector2 del;

	private const float MicTapSeconds = 0.25f;

	private static float micHoldTime;

	public Vector2 Delta
	{
		get
		{
			throw null;
		}
	}

	private static bool RebindInProgress
	{
		get
		{
			throw null;
		}
	}

	private static bool Held(KeybindAction action)
	{
		throw null;
	}

	private static bool Pressed(KeybindAction action)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static void HandleHud()
	{
		throw null;
	}

	private static void HandleMic()
	{
		throw null;
	}

	private static void ToggleChat()
	{
		throw null;
	}

	private static bool TryUseVent()
	{
		throw null;
	}

	private static void OpenSabotageMap()
	{
		throw null;
	}

	public KeyboardJoystick()
	{
		throw null;
	}
}
