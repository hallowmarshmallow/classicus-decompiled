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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAddShadowToPlayers_003Ed__8(int _003C_003E1__state)
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

	public PlayerShadow playerPrefab;

	public BodyShadow bodyPrefab;

	public static Collider2D roomCol;

	private static readonly DeadBody[] DeadBodyBuffer;

	public void Start()
	{
	}

	public void CheckBodyShadows()
	{
	}

	private int FindObjectsOfTypeIntoBuffer()
	{
		return 0;
	}

	private static bool HasChildNamed(Transform parent, string childName)
	{
		return false;
	}

	public IEnumerator CoAddShadowToPlayers()
	{
		return null;
	}

	public void AddShadowToPlayers()
	{
	}
}
