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

		public string Name => _003CName_003Ek__BackingField;

		public string Version => _003CVersion_003Ek__BackingField;

		public string Description => _003CDescription_003Ek__BackingField;

		public string Logo => _003CLogo_003Ek__BackingField;

		public string Path => _003CPath_003Ek__BackingField;
	}

	[Serializable]
	public class RootObject
	{
		private List<ModItem> _003CItems_003Ek__BackingField;

		public List<ModItem> Items => _003CItems_003Ek__BackingField;
	}

	private sealed class _003CFetchJsonData_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecentTab _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFetchJsonData_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CStopSpin_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecentTab _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStopSpin_003Ed__10(int _003C_003E1__state)
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

	public ModButton prefab;

	public Transform spawnParent;

	public SpinAnimator RefreshSpinner;

	private bool fetching;

	private const string JSON_URL = "https://raw.githubusercontent.com/OvernightAU/mod-repo/main//db.json";

	public void Refresh()
	{
	}

	private void Start()
	{
	}

	private IEnumerator FetchJsonData()
	{
		return null;
	}

	private IEnumerator StopSpin()
	{
		return null;
	}

	private void CreateModButton(ModItem modItem)
	{
	}
}
