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

		public _003CCoAnimate_003Ed__23(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private long _animatorID
	{
		get
		{
			throw null;
		}
	}

	public void Awake()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	public void Init(LIElement element, GIFFile gifData, LIShipStatus ship, string elementType)
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void Play()
	{
		throw null;
	}

	public void Play(bool repeat, bool reverse)
	{
		throw null;
	}

	public void Stop(bool reversed = false)
	{
		throw null;
	}

	private IEnumerator CoAnimate(bool repeat, bool reverse)
	{
		throw null;
	}

	private void OnClone(GIFAnimator originalAnim)
	{
		throw null;
	}

	public GIFAnimator()
	{
		throw null;
	}

	static GIFAnimator()
	{
		throw null;
	}
}
