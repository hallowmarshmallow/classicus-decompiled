using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoleSettingGameOption : MonoBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ValueText;

	private object Value;

	public FloatRange ChanceRange;

	public RoleBehaviour role;

	public RoleOption option;

	public byte roleOptionId;

	private bool buttonsDisabled;

	public float DecrIncr;

	public bool ZeroMeansInfinity;

	private Action _003COnValueChanged_003Ek__BackingField;

	public Action OnValueChanged
	{
		get
		{
			return _003COnValueChanged_003Ek__BackingField;
		}
		set
		{
			_003COnValueChanged_003Ek__BackingField = value;
		}
	}

	public string ValueString()
	{
		return null;
	}

	public void OnEnableManual()
	{
	}

	private void RefreshAll()
	{
	}

	public static float ParseOption(object opt)
	{
		return 0f;
	}

	public void ChangeRoleOption()
	{
	}

	public void ChangeRoleCount()
	{
	}

	public void IncreaseChance()
	{
	}

	public void DecreaseChance()
	{
	}

	private bool _003CChangeRoleOption_003Eb__18_0(KeyValuePair<string, RoleOption> pair)
	{
		return false;
	}
}
