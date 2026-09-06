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

		public _003CRun_003Ed__3(int _003C_003E1__state)
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

	public Minigame[] Stages;

	private Minigame stage;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private IEnumerator Run()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public AutoMultistageMinigame()
	{
		throw null;
	}
}
