using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletMinigame : Minigame
{
	private sealed class _003CFinish_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ToiletMinigame _003C_003E4__this;

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

		public _003CFinish_003Ed__19(int _003C_003E1__state)
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

	public SpriteRenderer Needle;

	public SpriteRenderer Pipes;

	public const float StickDown = -0.75f;

	public FloatRange StickRange;

	public Collider2D Stick;

	public SpriteRenderer Plunger;

	public Sprite PlungerUp;

	public Sprite PlungerDown;

	private float pressure;

	public Controller controller;

	public float lastY;

	public float plungeScale;

	public AudioClip flushSound;

	public AudioClip[] plungeSounds;

	private AudioSource plungerSource;

	private float controllerStickPos;

	private const float controllerPlungeSpeed = 30f;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator Finish()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public ToiletMinigame()
	{
		throw null;
	}
}
