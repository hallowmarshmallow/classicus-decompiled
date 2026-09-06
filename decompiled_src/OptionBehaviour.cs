using System;
using UnityEngine;

public abstract class OptionBehaviour : MonoBehaviour
{
	public StringNames Title;

	public string CustomTitle;

	public Action<OptionBehaviour> OnValueChanged;

	public virtual float GetFloat()
	{
		throw null;
	}

	public virtual int GetInt()
	{
		throw null;
	}

	public virtual bool GetBool()
	{
		throw null;
	}

	public void SetAsPlayer()
	{
		throw null;
	}

	protected OptionBehaviour()
	{
		throw null;
	}
}
