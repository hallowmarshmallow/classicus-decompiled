using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RecentTab : MonoBehaviour
{
	[Serializable]
	public class ModItem
	{
		private string _003CName_003Ek__BackingField;

		private string _003CVersion_003Ek__BackingField;

		private string _003CDescription_003Ek__BackingField;

		private string _003CLogo_003Ek__BackingField;

		private string _003CPath_003Ek__BackingField;

		public string Name
		{
			get
			{
				throw null;
			}
		}

		public string Version
		{
			get
			{
				throw null;
			}
		}

		public string Description
		{
			get
			{
				throw null;
			}
		}

		public string Logo
		{
			get
			{
				throw null;
			}
		}

		public string Path
		{
			get
			{
				throw null;
			}
		}

		public ModItem()
		{
			throw null;
		}
	}

	[Serializable]
	public class RootObject
	{
		private List<ModItem> _003CItems_003Ek__BackingField;

		public List<ModItem> Items
		{
			get
			{
				throw null;
			}
		}

		public RootObject()
		{
			throw null;
		}
	}

	private sealed class _003CFetchJsonData_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecentTab _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

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

		public _003CFetchJsonData_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CLoadLogoImage_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string logoPath;

		public ModButton modButton;

		private string _003CfullPath_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

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

		public _003CLoadLogoImage_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CStopSpin_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecentTab _003C_003E4__this;

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

		public _003CStopSpin_003Ed__10(int _003C_003E1__state)
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

	public ModButton prefab;

	public Transform spawnParent;

	public SpinAnimator RefreshSpinner;

	private bool fetching;

	private const string JSON_URL = "https://raw.githubusercontent.com/OvernightAU/mod-repo/main//db.json";

	public void Refresh()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private IEnumerator FetchJsonData()
	{
		throw null;
	}

	private IEnumerator StopSpin()
	{
		throw null;
	}

	private void CreateModButton(ModItem modItem)
	{
		throw null;
	}

	private IEnumerator LoadLogoImage(string logoPath, ModButton modButton)
	{
		throw null;
	}

	public RecentTab()
	{
		throw null;
	}
}
