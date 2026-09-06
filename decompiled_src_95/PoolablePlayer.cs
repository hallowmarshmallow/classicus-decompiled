using UnityEngine;

public class PoolablePlayer : MonoBehaviour
{
	public SpriteRenderer Body;

	public SpriteRenderer[] Hands;

	public HatParent HatSlot;

	public SpriteRenderer SkinSlot;

	public SpriteRenderer PetSlot;

	public TextRenderer NameText;

	public void SetFlipX(bool flipped)
	{
	}

	public void ApplyHatConfig(HatBehaviour hat, int colorId)
	{
	}

	public void SetMaskInteraction(SpriteMaskInteraction interactionType)
	{
	}

	public void SetDeadFlipX(bool flipped)
	{
	}
}
