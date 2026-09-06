using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssetPreloader : DestroyableSingleton<AssetPreloader>
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string name;

		public AssetPreloader _003C_003E4__this;

		public _003C_003Ec__DisplayClass10_0()
		{
			throw null;
		}

		internal bool _003CPrefabByName_003Eb__0(Transform p)
		{
			throw null;
		}

		internal bool _003CPrefabByName_003Eb__1(Transform p)
		{
			throw null;
		}

		internal void _003CPrefabByName_003Eb__2()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string name;

		public _003C_003Ec__DisplayClass11_0()
		{
			throw null;
		}

		internal bool _003CScriptByName_003Eb__0(ScriptableObject p)
		{
			throw null;
		}

		internal bool _003CScriptByName_003Eb__1(ScriptableObject p)
		{
			throw null;
		}
	}

	private sealed class _003CInitializeAsync_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetPreloader _003C_003E4__this;

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

		public _003CInitializeAsync_003Ed__13(int _003C_003E1__state)
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

	public bool LazyLoadAssets;

	public List<ScriptableMapData> PreloadedMaps;

	public List<Transform> prefabs;

	public List<ScriptableObject> scripts;

	public TextMeshPro LoadText;

	public Dictionary<string, MapData> allMaps;

	public Dictionary<string, object> assetDB;

	public bool finishedLoading;

	private Dictionary<string, Transform> loadedPrefabs;

	private Dictionary<string, ScriptableObject> loadedScripts;

	public Transform PrefabByName(string name)
	{
		throw null;
	}

	public ScriptableObject ScriptByName(string name)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public IEnumerator InitializeAsync()
	{
		throw null;
	}

	public static MapData FromScriptableMapData(ScriptableMapData data)
	{
		throw null;
	}

	public AssetPreloader()
	{
		throw null;
	}
}
