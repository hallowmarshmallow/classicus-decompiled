using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecLeverGame : Minigame
{
	private sealed class _003CFinishUp_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ElecLeverGame _003C_003E4__this;

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

		public _003CFinishUp_003Ed__16(int _003C_003E1__state)
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

	public Sprite[] NumberIcons;

	public SpriteRenderer NumberImage;

	public SpriteRenderer[] Lights;

	public Sprite LightOn;

	public Sprite LightOff;

	public Collider2D Handle;

	public SpriteRenderer Bars;

	private FloatRange HandleRange;

	private bool finished;

	private Controller controller;

	public AudioClip correctSound;

	public AudioClip incorrectSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void ResetLights()
	{
		throw null;
	}

	private void SetLights(bool on)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private IEnumerator FinishUp()
	{
		throw null;
	}

	public ElecLeverGame()
	{
		throw null;
	}

	private bool _003CBegin_003Eb__12_0(byte b)
	{
		throw null;
	}
}
