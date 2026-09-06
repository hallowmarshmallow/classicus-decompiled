using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockManifoldsMinigame : Minigame
{
	private sealed class _003CResetAll_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockManifoldsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetAll_003Ed__8(int _003C_003E1__state)
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

	public SpriteRenderer[] Buttons;

	public byte SystemId;

	private int buttonCounter;

	private bool animating;

	public AudioClip PressButtonSound;

	public AudioClip FailSound;

	public override void Begin(PlayerTask task)
	{
	}

	public void HitButton(int idx)
	{
	}

	private IEnumerator ResetAll()
	{
		return null;
	}
}
