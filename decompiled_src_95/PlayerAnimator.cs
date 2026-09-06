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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWalkPlayerTo_003Ed__13(int _003C_003E1__state)
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
	}

	public void FixedUpdate()
	{
	}

	public void LateUpdate()
	{
	}

	public IEnumerator WalkPlayerTo(Vector2 worldPos, bool relax, float tolerance = 0.01f)
	{
		return null;
	}
}
