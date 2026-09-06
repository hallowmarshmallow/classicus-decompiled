using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagnosticGame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<SpriteRenderer> _003C_003E9__15_2;

		public static Action<SpriteRenderer> _003C_003E9__15_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CUpdate_003Eb__15_2(SpriteRenderer f)
		{
			throw null;
		}

		internal void _003CUpdate_003Eb__15_0(SpriteRenderer f)
		{
			throw null;
		}
	}

	private sealed class _003CBlinkButton_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnosticGame _003C_003E4__this;

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

		public _003CBlinkButton_003Ed__12(int _003C_003E1__state)
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

	public VerticalGauge Gauge;

	public SpriteRenderer StartButton;

	public float TimePerStep;

	public TextRenderer Text;

	private int TargetNum;

	public SpriteRenderer[] Targets;

	private Color goodBarColor;

	public AudioClip StartSound;

	public AudioClip CorrectSound;

	public AudioClip TickSound;

	private int lastPercent;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private IEnumerator BlinkButton()
	{
		throw null;
	}

	public void PickAnomaly(int num)
	{
		throw null;
	}

	public void StartDiagnostic()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public DiagnosticGame()
	{
		throw null;
	}

	private void _003CUpdate_003Eb__15_1(SpriteRenderer f)
	{
		throw null;
	}
}
