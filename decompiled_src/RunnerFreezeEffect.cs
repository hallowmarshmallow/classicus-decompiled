using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public sealed class RunnerFreezeEffect : MonoBehaviour
{
	private sealed class _003CCoFreeze_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerFreezeEffect _003C_003E4__this;

		public float seconds;

		private SpriteAnim _003Canim_003E5__2;

		private float _003CinLen_003E5__3;

		private float _003CoutLen_003E5__4;

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

		public _003CCoFreeze_003Ed__13(int _003C_003E1__state)
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

	private const string ChildName = "FreezeEffect";

	private static AnimationClip _clipIn;

	private static AnimationClip _clipShine;

	private static AnimationClip _clipOut;

	private static bool _clipsLoaded;

	private static bool _warnedNoChild;

	private SpriteAnim _anim;

	private Coroutine _routine;

	public static void Play(PlayerControl player, float seconds)
	{
		throw null;
	}

	public static void Stop(PlayerControl player)
	{
		throw null;
	}

	private static void LoadClips()
	{
		throw null;
	}

	private void Begin(float seconds)
	{
		throw null;
	}

	private void Finish()
	{
		throw null;
	}

	private IEnumerator CoFreeze(float seconds)
	{
		throw null;
	}

	private SpriteAnim EnsureAnim()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	public RunnerFreezeEffect()
	{
		throw null;
	}
}
