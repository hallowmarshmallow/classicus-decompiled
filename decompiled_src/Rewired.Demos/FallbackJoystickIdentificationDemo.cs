using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos;

public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	private const float windowWidth = 250f;

	private const float windowHeight = 250f;

	private const float inputDelay = 1f;

	private bool identifyRequired;

	private Queue<Joystick> joysticksToIdentify;

	private float nextInputAllowedTime;

	private GUIStyle style;

	private void Awake()
	{
		throw null;
	}

	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
		throw null;
	}

	public void IdentifyAllJoysticks()
	{
		throw null;
	}

	private void SetInputDelay()
	{
		throw null;
	}

	private void OnGUI()
	{
		throw null;
	}

	private void DrawDialogWindow(int windowId)
	{
		throw null;
	}

	private void Reset()
	{
		throw null;
	}

	public FallbackJoystickIdentificationDemo()
	{
		throw null;
	}
}
