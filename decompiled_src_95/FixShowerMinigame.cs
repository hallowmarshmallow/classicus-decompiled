using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixShowerMinigame : Minigame
{
	private sealed class _003CBash_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FixShowerMinigame _003C_003E4__this;

		public float power;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBash_003Ed__22(int _003C_003E1__state)
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

	private const float PowerRatio = 0.32f;

	private const float BasePower = 0.04f;

	private const float CompleteTolerance = 0.07f;

	private FloatRange hammerAngles;

	private FloatRange showerAngles;

	private float showerPos;

	public SpriteRenderer mallet;

	public Collider2D showerHead;

	public AnimationCurve hammerAnim;

	private Controller controller;

	private float powerTime;

	public PowerBar powerBar;

	public AudioClip[] bashSounds;

	public AudioClip swingSound;

	public GameObject leftGlyph;

	public GameObject rightGlyph;

	private bool prevButtonHeld;

	private bool animating;

	private float Power => 0f;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public IEnumerator Bash(float power)
	{
		return null;
	}

	public override void Close()
	{
	}

	private void _003CBash_003Eb__22_0(float t)
	{
	}
}
