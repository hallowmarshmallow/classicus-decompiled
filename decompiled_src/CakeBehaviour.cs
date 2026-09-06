using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeBehaviour : MonoBehaviour
{
	private sealed class _003CItemAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CakeBehaviour _003C_003E4__this;

		private float _003Cduration_003E5__2;

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

		public _003CItemAnimation_003Ed__16(int _003C_003E1__state)
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

	public PurchaseBreakFastMinigame minigame;

	public int balance;

	public int index;

	public int price;

	public int discount;

	public Sprite traySprite;

	public Sprite singleSprite;

	public SpriteRenderer cakeRenderer;

	public SpriteRenderer leftNumber;

	public SpriteRenderer rightNumber;

	public Dictionary<int, Sprite> numbers;

	private void Awake()
	{
		throw null;
	}

	private SpriteRenderer FindRenderer(string child)
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	private void OnMouseDown()
	{
		throw null;
	}

	public void Click()
	{
		throw null;
	}

	public IEnumerator ItemAnimation()
	{
		throw null;
	}

	public CakeBehaviour()
	{
		throw null;
	}
}
