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

		internal bool _003CPrefabByName_003Eb__0(Transform p)
		{
			return false;
		}

		internal bool _003CPrefabByName_003Eb__1(Transform p)
		{
			return false;
		}

		internal void _003CPrefabByName_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string name;

		internal bool _003CScriptByName_003Eb__0(ScriptableObject p)
		{
			return false;
		}

		internal bool _003CScriptByName_003Eb__1(ScriptableObject p)
		{
			return false;
		}
	}

	private sealed class _003CInitializeAsync_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetPreloader _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitializeAsync_003Ed__13(int _003C_003E1__state)
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
		return null;
	}

	public ScriptableObject ScriptByName(string name)
	{
		return null;
	}

	private void Start()
	{
	}

	public IEnumerator InitializeAsync()
	{
		return null;
	}

	public static MapData FromScriptableMapData(ScriptableMapData data)
	{
		return null;
	}
}
