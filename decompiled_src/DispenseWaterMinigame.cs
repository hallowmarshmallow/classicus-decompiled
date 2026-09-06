using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenseWaterMinigame : Minigame
{
	private sealed class _003CFill_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DispenseWaterMinigame _003C_003E4__this;

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

		public _003CFill_003Ed__3(int _003C_003E1__state)
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

	public Animator waterAnimation;

	public ClickableSprite button;

	public GameObject onButton;

	public AudioClip dispense;

	public GameObject offButton;

	public Transform cap;

	public AudioClip FillAudio;

	public Transform capTarget;

	public Draggable capDraggable;

	private AudioSource _audioSource;

	private bool _filling;

	private Coroutine _fillRoutine;

	private SpriteRenderer _renderer;

	private float _timer;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void CustomClose()
	{
		throw null;
	}

	private IEnumerator Fill()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public DispenseWaterMinigame()
	{
		throw null;
	}

	private void _003CStart_003Eb__0_0()
	{
		throw null;
	}

	private void _003CStart_003Eb__0_1()
	{
		throw null;
	}
}
