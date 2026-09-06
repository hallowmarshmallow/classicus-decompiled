using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WifiGame : Minigame
{
	private sealed class _003CCoBlinkLight_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer light;

		public WifiGame _003C_003E4__this;

		public float delay;

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

		public _003CCoBlinkLight_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CRunLights_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool finishing;

		public WifiGame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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

		public _003CRunLights_003Ed__15(int _003C_003E1__state)
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

	private const int WaitDuration = 60;

	public SlideBar Slider;

	public TextMeshPro StatusText;

	public SpriteRenderer[] Lights;

	public Sprite LightOn;

	public Sprite LightOff;

	public AudioClip SliderClick;

	private bool WifiOff;

	private TouchpadBehavior touchpad;

	private float initialSlider;

	private Controller controller;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void TurnOn(bool first = false)
	{
		throw null;
	}

	private void TurnOff(bool first = false)
	{
		throw null;
	}

	private IEnumerator RunLights(bool finishing)
	{
		throw null;
	}

	private IEnumerator CoBlinkLight(SpriteRenderer light, float delay)
	{
		throw null;
	}

	public WifiGame()
	{
		throw null;
	}

	private void _003CTurnOff_003Eb__14_0(SpriteRenderer s)
	{
		throw null;
	}

	private void _003CRunLights_003Eb__15_0(SpriteRenderer s)
	{
		throw null;
	}

	private void _003CRunLights_003Eb__15_1(SpriteRenderer s)
	{
		throw null;
	}
}
