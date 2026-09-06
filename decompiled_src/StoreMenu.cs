using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;
using UnityEngine.Purchasing;

public class StoreMenu : MonoBehaviour, IStoreListener
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameObject, PurchaseButton> _003C_003E9__41_0;

		public static Func<PetBehaviour, bool> _003C_003E9__43_0;

		public static Func<PetBehaviour, string> _003C_003E9__43_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal PurchaseButton _003CWaitForPurchaseAds_003Eb__41_0(GameObject p)
		{
			throw null;
		}

		internal bool _003CShowAllButtons_003Eb__43_0(PetBehaviour h)
		{
			throw null;
		}

		internal string _003CShowAllButtons_003Eb__43_1(PetBehaviour p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public PurchaseButton button;

		public Func<PurchaseButton, bool> _003C_003E9__1;

		public _003C_003Ec__DisplayClass41_0()
		{
			throw null;
		}

		internal bool _003CWaitForPurchaseAds_003Eb__1(PurchaseButton h)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public IBuyable item;

		public _003C_003Ec__DisplayClass45_0()
		{
			throw null;
		}

		internal bool _003CInsertHatsFromList_003Eb__0(Product p)
		{
			throw null;
		}
	}

	private sealed class _003CWaitForPurchaseAds_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseButton button;

		public StoreMenu _003C_003E4__this;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CWaitForPurchaseAds_003Ed__41(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public SpriteRenderer HatSlot;

	public SpriteRenderer SkinSlot;

	public SpriteAnim PetSlot;

	public TextRenderer ItemName;

	public SpriteRenderer PurchaseBackground;

	public TextRenderer PriceText;

	public PurchaseButton PurchasablePrefab;

	public SpriteRenderer HortLinePrefab;

	public TextRenderer LoadingText;

	public TextRenderer RestorePurchasesButton;

	public GameObject RestorePurchasesObj;

	public SpriteRenderer BannerPrefab;

	public Sprite HatBanner;

	public Sprite SkinsBanner;

	public Sprite HolidayBanner;

	public Sprite PetsBanner;

	public SpriteRenderer TopArrow;

	public SpriteRenderer BottomArrow;

	public const string BoughtAdsProductId = "bought_ads";

	private IStoreController controller;

	private IExtensionProvider extensions;

	public Scroller Scroller;

	public Vector2 StartPositionVertical;

	public FloatRange XRange;

	public int NumPerRow;

	private PurchaseButton CurrentButton;

	private List<GameObject> AllObjects;

	private const float NormalHeight = -0.45f;

	private const float BoxHeight = -0.75f;

	private PurchaseStates _003CPurchaseState_003Ek__BackingField;

	public PurchaseStates PurchaseState
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void OnInitializeFailed(InitializationFailureReason reason, string rreaason)
	{
		throw null;
	}

	private void DestroySliderObjects()
	{
		throw null;
	}

	private void FinishRestoring()
	{
		throw null;
	}

	public void SetProduct(PurchaseButton button)
	{
		throw null;
	}

	public void BuyProduct()
	{
		throw null;
	}

	public IEnumerator WaitForPurchaseAds(PurchaseButton button)
	{
		throw null;
	}

	public void Close()
	{
		throw null;
	}

	private void ShowAllButtons()
	{
		throw null;
	}

	private Vector3 InsertHortLine(Vector3 position)
	{
		throw null;
	}

	private Vector3 InsertHatsFromList(Vector3 position, Product[] allProducts, IBuyable[] hats)
	{
		throw null;
	}

	private void InsertProduct(Vector3 position, Product product, IBuyable item)
	{
		throw null;
	}

	private Vector3 InsertBanner(Vector3 position, Sprite s)
	{
		throw null;
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		throw null;
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		throw null;
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
		throw null;
	}

	public void OnPurchaseFailed(Product i, PurchaseFailureReason error)
	{
		throw null;
	}

	public StoreMenu()
	{
		throw null;
	}
}
