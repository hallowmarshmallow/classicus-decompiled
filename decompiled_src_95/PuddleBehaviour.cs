using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleBehaviour : MonoBehaviour
{
	private sealed class _003CFinishAnimation_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PuddleBehaviour _003C_003E4__this;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFinishAnimation_003Ed__2(int _003C_003E1__state)
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

	public MopPuddlesMinigame minigame;

	public Draggable draggable;

	public float health;

	public bool wiping;

	private Collider2D _collider2D;

	private bool _finished;

	private Vector2 _previousPosition;

	public SpriteRenderer _spriteRenderer;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private IEnumerator FinishAnimation()
	{
		return null;
	}
}
