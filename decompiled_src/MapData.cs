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

		public _003CCoWaitForPrewarm_003Ed__35(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public Sprite Logo
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

	public string Credits
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

	public AssetBundle Bundle
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

	public string LoadPath
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

	public bool NeedsPrewarm
	{
		get
		{
			throw null;
		}
	}

	public bool PrewarmStarted
	{
		get
		{
			throw null;
		}
	}

	public bool PrewarmFinished
	{
		get
		{
			throw null;
		}
	}

	public GameObject WarmupRoot
	{
		get
		{
			throw null;
		}
	}

	public float PrewarmProgress
	{
		get
		{
			throw null;
		}
	}

	public MapData(ShipStatus ship, Sprite logo)
	{
		throw null;
	}

	public void BeginPrewarm()
	{
		throw null;
	}

	public void PumpPrewarm()
	{
		throw null;
	}

	public IEnumerator CoWaitForPrewarm(float maxSeconds)
	{
		throw null;
	}

	public void DropPrewarm()
	{
		throw null;
	}

	public ShipStatus ResolveShip()
	{
		throw null;
	}
}
