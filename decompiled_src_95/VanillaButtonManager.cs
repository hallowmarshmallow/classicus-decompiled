using System;
using TMPro;
using UnityEngine;

public class VanillaButtonManager : AbilityButtonManager
{
	public RoleBehaviour TargetRole;

	public string SpriteName;

	public Action onClick;

	public string AbilityName;

	public TextMeshPro UseText;

	public override string abilityName => null;

	public override void Refresh()
	{
	}

	public override void DoClick()
	{
	}

	internal void FixedUpdate()
	{
	}

	public static VanillaButtonManager Create(Transform parent, RoleBehaviour role, string abilityName, Sprite abilitySprite, Action onClick)
	{
		return null;
	}

	private static void MatchVanillaSize(VanillaButtonManager button)
	{
	}

	private static void KeepWorldSize(TextMeshPro text, float ratio)
	{
	}

	public static void PlaceAboveKillButton(VanillaButtonManager button, float slotsUp = 1f)
	{
	}
}
