using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData
{
	private sealed class _003CCoWaitForPrewarm_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapData _003C_003E4__this;

		public float maxSeconds;

		private float _003Cwaited_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWaitForPrewarm_003Ed__35(int _003C_003E1__state)
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

	private ShipStatus _003CShip_003Ek__BackingField;

	private Sprite _003CLogo_003Ek__BackingField;

	private string _003CCredits_003Ek__BackingField;

	private AssetBundle _003CBundle_003Ek__BackingField;

	private string _003CLoadPath_003Ek__BackingField;

	private ResourceRequest prewarmRequest;

	private GameObject warmedPrefab;

	public ShipStatus Ship
	{
		get
		{
			return _003CShip_003Ek__BackingField;
		}
		private set
		{
			_003CShip_003Ek__BackingField = value;
		}
	}

	public Sprite Logo
	{
		get
		{
			return _003CLogo_003Ek__BackingField;
		}
		set
		{
			_003CLogo_003Ek__BackingField = value;
		}
	}

	public string Credits
	{
		get
		{
			return _003CCredits_003Ek__BackingField;
		}
		set
		{
			_003CCredits_003Ek__BackingField = value;
		}
	}

	public AssetBundle Bundle
	{
		get
		{
			return _003CBundle_003Ek__BackingField;
		}
		set
		{
			_003CBundle_003Ek__BackingField = value;
		}
	}

	public string LoadPath
	{
		get
		{
			return _003CLoadPath_003Ek__BackingField;
		}
		set
		{
			_003CLoadPath_003Ek__BackingField = value;
		}
	}

	public bool NeedsPrewarm => false;

	public bool PrewarmStarted => false;

	public bool PrewarmFinished => false;

	public GameObject WarmupRoot => null;

	public float PrewarmProgress => 0f;

	public MapData(ShipStatus ship, Sprite logo)
	{
	}

	public void BeginPrewarm()
	{
	}

	public void PumpPrewarm()
	{
	}

	public IEnumerator CoWaitForPrewarm(float maxSeconds)
	{
		return null;
	}

	public void DropPrewarm()
	{
	}

	public ShipStatus ResolveShip()
	{
		return null;
	}
}
