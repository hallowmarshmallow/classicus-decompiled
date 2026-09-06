using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadGame : Minigame
{
	private sealed class _003CAnimate_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeypadGame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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

		public _003CAnimate_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CBlinkAccept_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeypadGame _003C_003E4__this;

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

		public _003CBlinkAccept_003Ed__14(int _003C_003E1__state)
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

	public TextRenderer TargetText;

	public TextRenderer NumberText;

	public int number;

	public string numString;

	private bool animating;

	public SpriteRenderer AcceptButton;

	private LifeSuppSystemType system;

	private NoOxyTask oxyTask;

	private bool done;

	private string GetTodaysCodeText()
	{
		throw null;
	}

	private string GetOKText()
	{
		throw null;
	}

	private string GetBadText()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void ClickNumber(int i)
	{
		throw null;
	}

	private IEnumerator BlinkAccept()
	{
		throw null;
	}

	public void ClearEntry()
	{
		throw null;
	}

	public void Enter()
	{
		throw null;
	}

	private IEnumerator Animate()
	{
		throw null;
	}

	public KeypadGame()
	{
		throw null;
	}
}
