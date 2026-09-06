using UnityEngine;
using UnityEngine.UI;

public class EastDeconControl : MonoBehaviour, IUsable
{
	public EastDeconSystem System;

	public float usableDistance;

	public SpriteRenderer Image;

	public AudioClip UseSound;

	public Button.ButtonClickedEvent OnUse;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void Use()
	{
	}
}
