using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
	private const float BorderSize = 0.7f;

	public SpriteRenderer PurchasedIcon;

	public TextRenderer NameText;

	public SpriteRenderer HatImage;

	public Sprite MannequinFrame;

	public SpriteRenderer Background;

	public IBuyable Product;

	public bool Purchased;

	public string Name;

	public string Price;

	public string ProductId;

	private StoreMenu _003CParent_003Ek__BackingField;

	public StoreMenu Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public void SetItem(IBuyable product, string productId, string name, string price, bool purchased)
	{
	}

	private void SetBig()
	{
	}

	private void SetSquare()
	{
	}

	internal void SetPurchased()
	{
	}

	public void DoPurchase()
	{
	}
}
