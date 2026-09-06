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

	public override string abilityName
	{
		get
		{
			throw null;
		}
	}

	public override void Refresh()
	{
		throw null;
	}

	public override void DoClick()
	{
		throw null;
	}

	internal void FixedUpdate()
	{
		throw null;
	}

	public static VanillaButtonManager Create(Transform parent, RoleBehaviour role, string abilityName, Sprite abilitySprite, Action onClick)
	{
		throw null;
	}

	private static void MatchVanillaSize(VanillaButtonManager button)
	{
		throw null;
	}

	private static void KeepWorldSize(TextMeshPro text, float ratio)
	{
		throw null;
	}

	public static void PlaceAboveKillButton(VanillaButtonManager button, float slotsUp = 1f)
	{
		throw null;
	}

	public VanillaButtonManager()
	{
		throw null;
	}
}
