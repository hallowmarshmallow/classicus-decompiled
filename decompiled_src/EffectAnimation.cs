using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class EffectAnimation : MonoBehaviour
{
	public enum SoundType
	{
		None,
		Local,
		Global
	}

	private sealed class _003CCoPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EffectAnimation _003C_003E4__this;

		public PlayerControl parent;

		public bool parentTransform;

		public bool flipX;

		public float flipXOffset;

		public SoundType soundType;

		public float duration;

		public Action onClipEnded;

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

		public _003CCoPlay_003Ed__10(int _003C_003E1__state)
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

	private PlayerControl parent;

	public AudioClip UseSound;

	public SpriteRenderer Renderer;

	public SpriteAnim Animator;

	public AnimationClip Clip;

	public Action MidAnimCB;

	public bool ForceMultipleSources;

	public void TestPlay()
	{
		throw null;
	}

	public void Play(PlayerControl parent, Action onClipEnded, bool flipX, SoundType soundType, float duration = 0f, bool parentTransform = true, float flipXOffset = 0f)
	{
		throw null;
	}

	private IEnumerator CoPlay(PlayerControl parent, Action onClipEnded, bool flipX, SoundType soundType, float duration = 0f, bool parentTransform = true, float flipXOffset = 0f)
	{
		throw null;
	}

	public void Play(PlayerControl parent, bool flipX, float flipXOffset = 0f)
	{
		throw null;
	}

	public void MidAnimationCallback()
	{
		throw null;
	}

	public void PlaySound()
	{
		throw null;
	}

	public void SetMaterialColor(int colorId)
	{
		throw null;
	}

	public EffectAnimation()
	{
		throw null;
	}
}
