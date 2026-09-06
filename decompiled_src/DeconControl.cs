using UnityEngine;
using UnityEngine.UI;

public class DeconControl : MonoBehaviour, IUsable
{
	public DeconSystem System;

	public float usableDistance;

	public SpriteRenderer Image;

	public AudioClip UseSound;

	public Button.ButtonClickedEvent OnUse;

	public float UsableDistance
	{
		get
		{
			throw null;
		}
	}

	public float PercentCool
	{
		get
		{
			throw null;
		}
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	public DeconControl()
	{
		throw null;
	}
}
