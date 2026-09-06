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

		public _003CWaitForDlcPurchase_003Ed__12(int _003C_003E1__state)
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

	public Dictionary<string, ISteamBuyable> IdTranslator;

	private IStoreCallback storeCallback;

	private Callback<GameOverlayActivated_t> overlayCallback;

	private bool steamOverlayOpen;

	private StoreMenu parent;

	public SteamPurchasingModule(StoreMenu parent)
	{
		throw null;
	}

	public void Configure(IPurchasingBinder binder)
	{
		throw null;
	}

	public void FinishTransaction(ProductDefinition product, string transactionId)
	{
		throw null;
	}

	public void Initialize(IStoreCallback callback)
	{
		throw null;
	}

	private void HandleOverlayActivate(GameOverlayActivated_t param)
	{
		throw null;
	}

	public void Purchase(ProductDefinition product, string developerPayload)
	{
		throw null;
	}

	private IEnumerator WaitForDlcPurchase(ProductDefinition product, AppId_t appId)
	{
		throw null;
	}

	public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
	{
		throw null;
	}
}
