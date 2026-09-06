using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowManager : MonoBehaviour
{
	private sealed class _003CCoAddShadowToPlayers_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShadowManager _003C_003E4__this;

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

		public _003CCoAddShadowToPlayers_003Ed__8(int _003C_003E1__state)
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

	public PlayerShadow playerPrefab;

	public BodyShadow bodyPrefab;

	public static Collider2D roomCol;

	private static readonly DeadBody[] DeadBodyBuffer;

	public void Start()
	{
		throw null;
	}

	public void CheckBodyShadows()
	{
		throw null;
	}

	private int FindObjectsOfTypeIntoBuffer()
	{
		throw null;
	}

	private static bool HasChildNamed(Transform parent, string childName)
	{
		throw null;
	}

	public IEnumerator CoAddShadowToPlayers()
	{
		throw null;
	}

	public void AddShadowToPlayers()
	{
		throw null;
	}

	public ShadowManager()
	{
		throw null;
	}

	static ShadowManager()
	{
		throw null;
	}
}
