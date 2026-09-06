using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityStyleSplash : MonoBehaviour
{
	private enum Phase
	{
		FadeIn,
		FadeOut,
		Done
	}

	private sealed class _003CCoInstantSkip_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityStyleSplash _003C_003E4__this;

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

		public _003CCoInstantSkip_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CWaitAndActivate_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityStyleSplash _003C_003E4__this;

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

		public _003CWaitAndActivate_003Ed__35(int _003C_003E1__state)
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

	public Texture2D splashTexture;

	public string nextSceneName;

	public float fadeInDuration;

	public float fadeOutDuration;

	public float zoomStartScale;

	public float zoomTargetScale;

	public float zoomDuration;

	public float fadeOutDelayAfterFadeIn;

	public bool skipSplashEntirely;

	public bool allowSkip;

	public KeyCode skipKey;

	private float _fadeTimer;

	private float _zoomTimer;

	private float _alpha;

	private float _currentScale;

	private Phase _phase;

	private AsyncOperation _preload;

	private bool _preloadStarted;

	private bool _skippingEntirely;

	private Color _guiColor;

	private Rect _baseRect;

	private float _textureRatio;

	private int _lastScreenW;

	private int _lastScreenH;

	private const float SkipGracePeriod = 0.5f;

	private float _elapsedTime;

	private void Awake()
	{
		throw null;
	}

	private IEnumerator CoInstantSkip()
	{
		throw null;
	}

	private void BeginInstantSkip()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnGUI()
	{
		throw null;
	}

	private void RecalcBaseRect()
	{
		throw null;
	}

	private void BeginPreload()
	{
		throw null;
	}

	private void ActivateNextScene()
	{
		throw null;
	}

	private IEnumerator WaitAndActivate()
	{
		throw null;
	}

	public UnityStyleSplash()
	{
		throw null;
	}
}
