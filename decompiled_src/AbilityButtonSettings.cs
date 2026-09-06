using System.Collections.Generic;
using UnityEngine;

public class AbilityButtonSettings : ScriptableObject
{
	public Sprite Image;

	public StringNames OptionalText;

	public Material FontMaterial;

	public AudioClip UseSound;

	public List<Object> Objects;

	public List<MonoBehaviour> Behaviours;

	public AbilityButtonSettings()
	{
		throw null;
	}
}
