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

		public _003C_003Ec__DisplayClass17_0()
		{
			throw null;
		}

		internal void _003CFixedUpdate_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoAnimateOpen_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponsMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

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

		public _003CCoAnimateOpen_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponsMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

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

		public _003CCoDestroySelf_003Ed__16(int _003C_003E1__state)
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
		throw null;
	}

	protected override IEnumerator CoAnimateOpen()
	{
		throw null;
	}

	protected override IEnumerator CoDestroySelf()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void BreakApart(Asteroid ast)
	{
		throw null;
	}

	public WeaponsMinigame()
	{
		throw null;
	}
}
