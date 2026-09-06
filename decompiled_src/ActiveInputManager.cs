using System;

public class ActiveInputManager : DestroyableSingleton<ActiveInputManager>
{
	public enum InputType
	{
		Joystick,
		Keyboard,
		Touch
	}

	public InputType testCurrentControlType;

	public static InputType currentControlType;

	public double kChangeTime;

	public double mChangeTime;

	public double jChangeTime;

	public double tChangeTime;

	public static Action CurrentInputSourceChanged;

	private Controller lastUsedController;

	private static InputType PlatformDefault
	{
		get
		{
			throw null;
		}
	}

	public void SetTouchAsCurrentInput()
	{
		throw null;
	}

	public ActiveInputManager()
	{
		throw null;
	}

	static ActiveInputManager()
	{
		throw null;
	}
}
