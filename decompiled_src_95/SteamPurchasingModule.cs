using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Steamworks;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

internal class SteamPurchasingModule : IPurchasingModule, IStore
{
	private sealed class _003CWaitForDlcPurchase_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamPurchasingModule _003C_003E4__this;

		public AppId_t appId;

		public ProductDefinition product;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForDlcPurchase_003Ed__12(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Dictionary<string, ISteamBuyable> IdTranslator;

	private IStoreCallback storeCallback;

	private Callback<GameOverlayActivated_t> overlayCallback;

	private bool steamOverlayOpen;

	private StoreMenu parent;

	public SteamPurchasingModule(StoreMenu parent)
	{
	}

	public void Configure(IPurchasingBinder binder)
	{
	}

	public void FinishTransaction(ProductDefinition product, string transactionId)
	{
	}

	public void Initialize(IStoreCallback callback)
	{
	}

	private void HandleOverlayActivate(GameOverlayActivated_t param)
	{
	}

	public void Purchase(ProductDefinition product, string developerPayload)
	{
	}

	private IEnumerator WaitForDlcPurchase(ProductDefinition product, AppId_t appId)
	{
		return null;
	}

	public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
	{
	}
}
