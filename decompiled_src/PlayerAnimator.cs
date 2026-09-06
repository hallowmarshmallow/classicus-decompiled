using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
	private sealed class _003CWalkPlayerTo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector2 worldPos;

		public PlayerAnimator _003C_003E4__this;

		public float tolerance;

		public bool relax;

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

		public _003CWalkPlayerTo_003Ed__13(int _003C_003E1__state)
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

	public float Speed;

	public VirtualJoystick joystick;

	public SpriteRenderer UseButton;

	public FingerBehaviour finger;

	public AnimationClip RunAnim;

	public AnimationClip IdleAnim;

	private Vector2 velocity;

	private SpriteAnim Animator;

	private SpriteRenderer rend;

	public int NearbyConsoles;

	private void Start()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void LateUpdate()
	{
		throw null;
	}

	public IEnumerator WalkPlayerTo(Vector2 worldPos, bool relax, float tolerance = 0.01f)
	{
		throw null;
	}

	public PlayerAnimator()
	{
		throw null;
	}
}
