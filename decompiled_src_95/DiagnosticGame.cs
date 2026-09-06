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

		internal void _003CUpdate_003Eb__15_2(SpriteRenderer f)
		{
		}

		internal void _003CUpdate_003Eb__15_0(SpriteRenderer f)
		{
		}
	}

	private sealed class _003CBlinkButton_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnosticGame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBlinkButton_003Ed__12(int _003C_003E1__state)
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
	}

	private IEnumerator BlinkButton()
	{
		return null;
	}

	public void PickAnomaly(int num)
	{
	}

	public void StartDiagnostic()
	{
	}

	public void Update()
	{
	}

	private void _003CUpdate_003Eb__15_1(SpriteRenderer f)
	{
	}
}
