using System;
using TMPro;
using UnityEngine;

public class RoleGameOption : MonoBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ChanceText;

	private int Chance;

	private FloatRange ChanceRange;

	public RoleBehaviour role;

	public Action OnValueChanged;

	public string ChanceString()
	{
		return null;
	}

	public void OnEnableManual()
	{
	}

	private void RefreshAll()
	{
	}

	public void ChangeRoleChance()
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
}
