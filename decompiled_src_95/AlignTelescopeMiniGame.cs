using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignTelescopeMiniGame : Minigame
{
	private sealed class _003CCoBlinky_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignTelescopeMiniGame _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBlinky_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CRunBlipSound_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignTelescopeMiniGame _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRunBlipSound_003Ed__4(int _003C_003E1__state)
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

	public Minigame DistributePrefab;

	public Minigame ReceivePrefab;

	private readonly FloatRange _blipDelay;

	private readonly Controller _controller;

	public Transform _background;

	public Coroutine _blinky;

	public AudioClip _blipSound;

	private bool _grabbed;

	private SpriteRenderer _itemDisplay;

	public Collider2D[] _items;

	public Collider2D _reticle;

	private SpriteRenderer _reticleImage;

	public Collider2D _targetItem;

	private BoxCollider2D _cachedBackgroundCollider;

	private float _scrollSpeed;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private IEnumerator RunBlipSound()
	{
		return null;
	}

	private IEnumerator CoBlinky()
	{
		return null;
	}

	public void Grab()
	{
	}
}
