using UnityEngine;

public class WireNode : MonoBehaviour
{
	public Collider2D hitbox;

	public SpriteRenderer[] WireColors;

	public SpriteRenderer BaseSymbol;

	public sbyte WireId;

	private SpriteRenderer FindBaseSymbol()
	{
		return null;
	}

	internal void SetColor(Color color)
	{
	}

	internal void SetColor(Color color, Sprite symbol)
	{
	}
}
