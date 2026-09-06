using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelImposter.Api;

public class GIFAnimator : MonoBehaviour
{
	private sealed class _003CCoAnimate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GIFAnimator _003C_003E4__this;

		public bool reverse;

		public bool repeat;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimate_003Ed__23(int _003C_003E1__state)
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

	private static readonly Dictionary<long, GIFAnimator> _allAnimators;

	private static long _nextAnimatorID;

	private static readonly List<string> AUTOPLAY_BLACKLIST;

	private Coroutine _animationCoroutine;

	private bool _defaultLoopGIF;

	private int _frame;

	private GIFFile _gifData;

	private SpriteRenderer _spriteRenderer;

	public string elemType;

	public long AnimatorID;

	private bool _003CIsAnimating_003Ek__BackingField;

	public bool IsAnimating
	{
		get
		{
			return _003CIsAnimating_003Ek__BackingField;
		}
		private set
		{
			_003CIsAnimating_003Ek__BackingField = value;
		}
	}

	private long _animatorID => 0L;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Init(LIElement element, GIFFile gifData, LIShipStatus ship, string elementType)
	{
	}

	public void Start()
	{
	}

	public void Play()
	{
	}

	public void Play(bool repeat, bool reverse)
	{
	}

	public void Stop(bool reversed = false)
	{
	}

	private IEnumerator CoAnimate(bool repeat, bool reverse)
	{
		return null;
	}

	private void OnClone(GIFAnimator originalAnim)
	{
	}
}
