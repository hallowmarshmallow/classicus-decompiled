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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CBlinkAccept_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeypadGame _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBlinkAccept_003Ed__14(int _003C_003E1__state)
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
		return null;
	}

	private string GetOKText()
	{
		return null;
	}

	private string GetBadText()
	{
		return null;
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void ClickNumber(int i)
	{
	}

	private IEnumerator BlinkAccept()
	{
		return null;
	}

	public void ClearEntry()
	{
	}

	public void Enter()
	{
	}

	private IEnumerator Animate()
	{
		return null;
	}
}
