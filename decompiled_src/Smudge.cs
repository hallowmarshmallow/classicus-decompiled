using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smudge : MonoBehaviour
{
	private sealed class _003CFinishAnimation_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Smudge _003C_003E4__this;

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

		public _003CFinishAnimation_003Ed__2(int _003C_003E1__state)
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

	public Draggable draggable;

	public float health;

	public bool wiping;

	public AudioClip[] squeakSounds;

	private Collider2D _collider2D;

	private bool _finished;

	private Vector2 _previousPosition;

	private SpriteRenderer _spriteRenderer;

	private float _squeakThreshold;

	private void Start()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private IEnumerator FinishAnimation()
	{
		throw null;
	}

	public Smudge()
	{
		throw null;
	}

	private void _003CFinishAnimation_003Eb__2_0(float f)
	{
		throw null;
	}
}
