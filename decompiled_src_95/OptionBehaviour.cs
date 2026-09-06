using System;
using UnityEngine;

public abstract class OptionBehaviour : MonoBehaviour
{
	public StringNames Title;

	public string CustomTitle;

	public Action<OptionBehaviour> OnValueChanged;

	public virtual float GetFloat()
	{
		return 0f;
	}

	public virtual int GetInt()
	{
		return 0;
	}

	public virtual bool GetBool()
	{
		return false;
	}

	public void SetAsPlayer()
	{
	}
}
