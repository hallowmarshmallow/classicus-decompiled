using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsMinigame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public WeaponsMinigame _003C_003E4__this;

		public Asteroid ast;

		internal void _003CFixedUpdate_003Eb__0()
		{
		}
	}

	private sealed class _003CCoAnimateOpen_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponsMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponsMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDestroySelf_003Ed__16(int _003C_003E1__state)
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

	public FloatRange XSpan;

	public FloatRange YSpan;

	public FloatRange TimeToSpawn;

	public ObjectPoolBehavior asteroidPool;

	public TextRenderer ScoreText;

	public SpriteRenderer TargetReticle;

	public LineRenderer TargetLines;

	private Vector3 TargetCenter;

	public Collider2D BackgroundCol;

	public SpriteRenderer Background;

	public Controller myController;

	private float Timer;

	public AudioClip ShootSound;

	public AudioClip[] ExplodeSounds;

	public override void Begin(PlayerTask task)
	{
	}

	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	public void FixedUpdate()
	{
	}

	public void BreakApart(Asteroid ast)
	{
	}
}
