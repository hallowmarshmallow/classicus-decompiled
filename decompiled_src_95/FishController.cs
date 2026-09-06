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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLerpSpeed_003Ed__5(int _003C_003E1__state)
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
	}

	private void Update()
	{
	}

	public void PlaySwim()
	{
	}

	public void PlayBite()
	{
	}

	public void Closed()
	{
	}

	public IEnumerator LerpSpeed(float duration, float start, float end)
	{
		return null;
	}
}
