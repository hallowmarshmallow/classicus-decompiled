using TMPro;
using UnityEngine;

public class AbilityButtonManager : MonoBehaviour
{
	public SpriteRenderer spriteRender;

	public TextMeshPro AbilityText;

	public TextMeshPro CooldownText;

	public TextMeshPro UsesText;

	public virtual string abilityName => null;

	public virtual void Refresh()
	{
	}

	public virtual void DoClick()
	{
	}
}
