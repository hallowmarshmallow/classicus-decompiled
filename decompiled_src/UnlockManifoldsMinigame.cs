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

		public _003CResetAll_003Ed__8(int _003C_003E1__state)
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

	public SpriteRenderer[] Buttons;

	public byte SystemId;

	private int buttonCounter;

	private bool animating;

	public AudioClip PressButtonSound;

	public AudioClip FailSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void HitButton(int idx)
	{
		throw null;
	}

	private IEnumerator ResetAll()
	{
		throw null;
	}

	public UnlockManifoldsMinigame()
	{
		throw null;
	}
}
