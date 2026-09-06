using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysGame : Minigame
{
	private sealed class _003CCoAnimateNewLeftSide_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

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

		public _003CCoAnimateNewLeftSide_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CCoAnimateOldLeftSide_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

		private int _003Ci_003E5__2;

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

		public _003CCoAnimateOldLeftSide_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CCoRun_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

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

		public _003CCoRun_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CFlashButton_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public SimonSaysGame _003C_003E4__this;

		public SpriteRenderer butt;

		public float flashTime;

		private Color _003Cc_003E5__2;

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

		public _003CFlashButton_003Ed__29(int _003C_003E1__state)
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

	private Queue<int> operations;

	private const int FlashOp = 256;

	private const int AnimateOp = 128;

	private const int ReAnimateOp = 32;

	private const int FailOp = 64;

	private Color gray;

	private Color blue;

	private Color red;

	private Color green;

	public SpriteRenderer[] LeftSide;

	public SpriteRenderer[] Buttons;

	public SpriteRenderer[] LeftLights;

	public SpriteRenderer[] RightLights;

	private float flashTime;

	private float userButtonFlashTime;

	public AudioClip ButtonPressSound;

	public AudioClip FailSound;

	private int IndexCount
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

	// C# has no syntax for parameterized property 'Item'.
	private byte get_Item(int idx)
	{
		throw null;
	}

	private void set_Item(int idx, byte value)
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void HitButton(int bIdx)
	{
		throw null;
	}

	private IEnumerator CoRun()
	{
		throw null;
	}

	private void AddIndex(int idxToAdd)
	{
		throw null;
	}

	private IEnumerator CoAnimateNewLeftSide()
	{
		throw null;
	}

	private IEnumerator CoAnimateOldLeftSide()
	{
		throw null;
	}

	private IEnumerator FlashButton(int id, SpriteRenderer butt, float flashTime)
	{
		throw null;
	}

	private void SetLights(SpriteRenderer[] lights, int num)
	{
		throw null;
	}

	private void SetAllColor(Color color)
	{
		throw null;
	}

	public SimonSaysGame()
	{
		throw null;
	}
}
