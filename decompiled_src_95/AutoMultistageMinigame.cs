using System;
using System.Collections;
using System.Collections.Generic;

public class AutoMultistageMinigame : Minigame
{
	private sealed class _003CRun_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AutoMultistageMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRun_003Ed__3(int _003C_003E1__state)
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

	public Minigame[] Stages;

	private Minigame stage;

	public override void Begin(PlayerTask task)
	{
	}

	private IEnumerator Run()
	{
		return null;
	}

	public override void Close()
	{
	}
}
