using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public sealed class FishController : MonoBehaviour
{
	private sealed class _003CLerpSpeed_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishController _003C_003E4__this;

		public float start;

		public float end;

		public float duration;

		private float _003Ci_003E5__2;

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

		public _003CLerpSpeed_003Ed__5(int _003C_003E1__state)
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

	public AnimationClip swim;

	public AnimationClip bite;

	public SpriteAnim anim;

	public Transform targetObj;

	public ParticleSystem bubbles;

	public bool started;

	private bool _bit;

	private float _speed;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void PlaySwim()
	{
		throw null;
	}

	public void PlayBite()
	{
		throw null;
	}

	public void Closed()
	{
		throw null;
	}

	public IEnumerator LerpSpeed(float duration, float start, float end)
	{
		throw null;
	}

	public FishController()
	{
		throw null;
	}
}
