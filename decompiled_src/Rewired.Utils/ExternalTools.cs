using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils;

public class ExternalTools : IExternalTools
{
	private Action<bool> _EditorPausedStateChangedEvent;

	private Action<uint, bool> m_XboxOneInput_OnGamepadStateChange;

	public event Action<bool> EditorPausedStateChangedEvent
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public ExternalTools()
	{
		throw null;
	}

	public void Destroy()
	{
		throw null;
	}

	public object GetPlatformInitializer()
	{
		throw null;
	}

	public string GetFocusedEditorWindowTitle()
	{
		throw null;
	}

	public bool IsEditorSceneViewFocused()
	{
		throw null;
	}

	public bool LinuxInput_IsJoystickPreconfigured(string name)
	{
		throw null;
	}

	public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
	{
		throw null;
	}

	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
	{
		throw null;
	}

	public string XboxOneInput_GetControllerType(ulong xboxControllerId)
	{
		throw null;
	}

	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
	{
		throw null;
	}

	public void XboxOne_Gamepad_UpdatePlugin()
	{
		throw null;
	}

	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
	{
		throw null;
	}

	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
	{
		throw null;
	}

	public int GetAndroidAPILevel()
	{
		throw null;
	}

	public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
	{
		throw null;
	}

	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
	{
		throw null;
	}

	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
	{
		throw null;
	}

	public Type[] GetControllerTemplateTypes()
	{
		throw null;
	}

	public Type[] GetControllerTemplateInterfaceTypes()
	{
		throw null;
	}
}
