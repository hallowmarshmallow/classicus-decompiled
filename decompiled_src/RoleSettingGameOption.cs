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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public string ValueString()
	{
		throw null;
	}

	public void OnEnableManual()
	{
		throw null;
	}

	private void RefreshAll()
	{
		throw null;
	}

	public static float ParseOption(object opt)
	{
		throw null;
	}

	public void ChangeRoleOption()
	{
		throw null;
	}

	public void ChangeRoleCount()
	{
		throw null;
	}

	public void IncreaseChance()
	{
		throw null;
	}

	public void DecreaseChance()
	{
		throw null;
	}

	public RoleSettingGameOption()
	{
		throw null;
	}

	private bool _003CChangeRoleOption_003Eb__18_0(KeyValuePair<string, RoleOption> pair)
	{
		throw null;
	}
}
