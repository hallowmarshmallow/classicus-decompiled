using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urchin : MonoBehaviour
{
	private sealed class _003CShrink_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Urchin _003C_003E4__this;

		private SpriteRenderer _003Crend_003E5__2;

		private float _003Ct_003E5__3;

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

		public _003CShrink_003Ed__4(int _003C_003E1__state)
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

	public ClearUrchinsMinigame minigame;

	public bool hit;

	public AudioClip urchinHit;

	private void OnTriggerEnter2D(Collider2D other)
	{
		throw null;
	}

	private IEnumerator Shrink()
	{
		throw null;
	}

	public Urchin()
	{
		throw null;
	}
}
