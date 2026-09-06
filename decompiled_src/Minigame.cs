using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Minigame : MonoBehaviour
{
	protected enum CloseState
	{
		None,
		Waiting,
		Closing
	}

	private sealed class _003CCoAnimateOpen_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		private float _003Cdepth_003E5__2;

		private float _003Ctimer2_003E5__3;

		private SpriteRenderer[] _003Crends_003E5__4;

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

		public _003CCoAnimateOpen_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		private float _003Cdepth_003E5__2;

		private float _003Ctimer2_003E5__3;

		private SpriteRenderer[] _003Crends_003E5__4;

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

		public _003CCoDestroySelf_003Ed__26(int _003C_003E1__state)
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

	private sealed class _003CCoStartClose_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		public float duration;

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

		public _003CCoStartClose_003Ed__19(int _003C_003E1__state)
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

	public static Minigame Instance;

	public const float Depth = -50f;

	public TransitionType TransType;

	protected PlayerTask MyTask;

	protected NormalPlayerTask MyNormTask;

	protected CloseState amClosing;

	protected bool amOpening;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	protected SpecialInputHandler inputHandler;

	private Console _003CConsole_003Ek__BackingField;

	public Console Console
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	protected int ConsoleId
	{
		get
		{
			throw null;
		}
	}

	public virtual void Begin(PlayerTask task)
	{
		throw null;
	}

	protected void SetupInput(bool disableCursor = false)
	{
		throw null;
	}

	protected IEnumerator CoStartClose(float duration = 0.75f)
	{
		throw null;
	}

	public void CloseTask()
	{
		throw null;
	}

	public void Close(bool allowMovement)
	{
		throw null;
	}

	public virtual void Close()
	{
		throw null;
	}

	public void ForceClose()
	{
		throw null;
	}

	protected virtual IEnumerator CoAnimateOpen()
	{
		throw null;
	}

	public virtual void OnDestroy()
	{
		throw null;
	}

	protected virtual IEnumerator CoDestroySelf()
	{
		throw null;
	}

	protected Minigame()
	{
		throw null;
	}
}
