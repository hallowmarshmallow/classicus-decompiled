using System;
using System.Collections;
using System.Collections.Generic;

public class CoroutineHelper : DestroyableSingleton<CoroutineHelper>
{
	private sealed class _003CCoDelayByFrames_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public Action action;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDelayByFrames_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CCoDelayBySeconds_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDelayBySeconds_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CCoDelayUntilEndOfFrame_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDelayUntilEndOfFrame_003Ed__6(int _003C_003E1__state)
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

	public void DelayBySeconds(float seconds, Action action)
	{
	}

	public void DelayByFrame(Action action)
	{
	}

	public void DelayByFrames(int frames, Action action)
	{
	}

	public void DelayUntilEndOfFrame(Action action)
	{
	}

	private IEnumerator CoDelayBySeconds(float seconds, Action action)
	{
		return null;
	}

	private IEnumerator CoDelayByFrames(int frames, Action action)
	{
		return null;
	}

	private IEnumerator CoDelayUntilEndOfFrame(Action action)
	{
		return null;
	}
}
