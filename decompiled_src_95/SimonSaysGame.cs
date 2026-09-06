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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateNewLeftSide_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CCoAnimateOldLeftSide_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOldLeftSide_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CCoRun_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRun_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CFlashButton_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public SimonSaysGame _003C_003E4__this;

		public SpriteRenderer butt;

		public float flashTime;

		private Color _003Cc_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFlashButton_003Ed__29(int _003C_003E1__state)
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
			return 0;
		}
		set
		{
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	private byte get_Item(int idx)
	{
		return 0;
	}

	private void set_Item(int idx, byte value)
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void HitButton(int bIdx)
	{
	}

	private IEnumerator CoRun()
	{
		return null;
	}

	private void AddIndex(int idxToAdd)
	{
	}

	private IEnumerator CoAnimateNewLeftSide()
	{
		return null;
	}

	private IEnumerator CoAnimateOldLeftSide()
	{
		return null;
	}

	private IEnumerator FlashButton(int id, SpriteRenderer butt, float flashTime)
	{
		return null;
	}

	private void SetLights(SpriteRenderer[] lights, int num)
	{
	}

	private void SetAllColor(Color color)
	{
	}
}
