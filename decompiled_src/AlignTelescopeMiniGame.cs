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

		public _003CCoBlinky_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CRunBlipSound_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignTelescopeMiniGame _003C_003E4__this;

		private float _003Ctime_003E5__2;

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

		public _003CRunBlipSound_003Ed__4(int _003C_003E1__state)
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
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator RunBlipSound()
	{
		throw null;
	}

	private IEnumerator CoBlinky()
	{
		throw null;
	}

	public void Grab()
	{
		throw null;
	}

	public AlignTelescopeMiniGame()
	{
		throw null;
	}
}
