using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubmarineSelectSpawnGPT : Minigame
{
	private sealed class _003CCountdownThenRandomSpawn_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubmarineSelectSpawnGPT _003C_003E4__this;

		private ManualInspectorTMPTranslator _003Ctranslator_003E5__2;

		private float _003Cremaining_003E5__3;

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

		public _003CCountdownThenRandomSpawn_003Ed__8(int _003C_003E1__state)
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

	public Transform LowerDeck;

	public Transform UpperDeck;

	private string OldRoomName;

	public TextMeshPro CountdownText;

	private const float CountdownTime = 10f;

	public SubmergedStatus Ship
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	private IEnumerator CountdownThenRandomSpawn()
	{
		throw null;
	}

	public void GoLowerDeck()
	{
		throw null;
	}

	public void GoUpperDeck()
	{
		throw null;
	}

	public void HoverNormal()
	{
		throw null;
	}

	public void UnHoverNormal()
	{
		throw null;
	}

	public void HoverSub()
	{
		throw null;
	}

	public void UnHoverSub()
	{
		throw null;
	}

	public SubmarineSelectSpawnGPT()
	{
		throw null;
	}
}
