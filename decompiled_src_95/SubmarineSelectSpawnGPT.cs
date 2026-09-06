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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCountdownThenRandomSpawn_003Ed__8(int _003C_003E1__state)
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

	public Transform LowerDeck;

	public Transform UpperDeck;

	private string OldRoomName;

	public TextMeshPro CountdownText;

	private const float CountdownTime = 10f;

	public SubmergedStatus Ship => null;

	public void Start()
	{
	}

	private IEnumerator CountdownThenRandomSpawn()
	{
		return null;
	}

	public void GoLowerDeck()
	{
	}

	public void GoUpperDeck()
	{
	}

	public void HoverNormal()
	{
	}

	public void UnHoverNormal()
	{
	}

	public void HoverSub()
	{
	}

	public void UnHoverSub()
	{
	}
}
