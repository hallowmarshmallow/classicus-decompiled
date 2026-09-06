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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public void SetItem(IBuyable product, string productId, string name, string price, bool purchased)
	{
		throw null;
	}

	private void SetBig()
	{
		throw null;
	}

	private void SetSquare()
	{
		throw null;
	}

	internal void SetPurchased()
	{
		throw null;
	}

	public void DoPurchase()
	{
		throw null;
	}

	public PurchaseButton()
	{
		throw null;
	}
}
