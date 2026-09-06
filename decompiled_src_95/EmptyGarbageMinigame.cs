using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyGarbageMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SpriteRenderer, bool> _003C_003E9__20_0;

		internal bool _003CUpdate_003Eb__20_0(SpriteRenderer o)
		{
			return false;
		}
	}

	private sealed class _003CAnimateObjects_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmptyGarbageMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimateObjects_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CPopObjects_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmptyGarbageMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPopObjects_003Ed__21(int _003C_003E1__state)
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

	private const float GrinderVolume = 0.8f;

	public FloatRange HandleRange;

	public Vector2Range SpawnRange;

	public Collider2D Blocker;

	public AreaEffector2D Popper;

	public Collider2D Handle;

	public SpriteRenderer Bars;

	private Controller controller;

	private bool finished;

	public int NumObjects;

	private SpriteRenderer[] Objects;

	public SpriteRenderer[] GarbagePrefabs;

	public SpriteRenderer[] LeafPrefabs;

	public SpriteRenderer[] SpecialObjectPrefabs;

	public AudioClip LeverDown;

	public AudioClip LeverUp;

	public AudioClip GrinderStart;

	public AudioClip GrinderLoop;

	public AudioClip GrinderEnd;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private IEnumerator PopObjects()
	{
		return null;
	}

	private IEnumerator AnimateObjects()
	{
		return null;
	}

	public override void Close()
	{
	}
}
