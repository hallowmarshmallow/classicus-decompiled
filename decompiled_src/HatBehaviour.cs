using UnityEngine;

public class HatBehaviour : ScriptableObject, IBuyable
{
	public Sprite MainImage;

	public Sprite BackImage;

	public Sprite ClimbImage;

	public Sprite FloorImage;

	public bool InFront;

	public bool Free;

	public bool Bounce;

	public bool NoBounce;

	public bool NotInStore;

	public int LimitedMonth;

	public int LimitedYear;

	public SkinData RelatedSkin;

	public Vector2 ChipOffset;

	public string StoreName;

	public string ProductId;

	public bool PlayerColored;

	public bool Legacy;

	public int Order;

	public bool IsEmpty
	{
		get
		{
			throw null;
		}
	}

	public string ProdId
	{
		get
		{
			throw null;
		}
	}

	public HatBehaviour()
	{
		throw null;
	}
}
