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

		public _003CBash_003Ed__22(int _003C_003E1__state)
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

	private float Power
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public IEnumerator Bash(float power)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public FixShowerMinigame()
	{
		throw null;
	}

	private void _003CBash_003Eb__22_0(float t)
	{
		throw null;
	}
}
