using TMPro;
using UnityEngine;

public class AbilityButtonManager : MonoBehaviour
{
	public SpriteRenderer spriteRender;

	public TextMeshPro AbilityText;

	public TextMeshPro CooldownText;

	public TextMeshPro UsesText;

	public virtual string abilityName
	{
		get
		{
			throw null;
		}
	}

	public virtual void Refresh()
	{
		throw null;
	}

	public virtual void DoClick()
	{
		throw null;
	}

	public AbilityButtonManager()
	{
		throw null;
	}
}
