using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Coroutines : DestroyableSingleton<Coroutines>
{
	private sealed class _003CStartEnumerator_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IEnumerator coroutine;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartEnumerator_003Ed__1(int _003C_003E1__state)
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

	private sealed class _003CWaitForTask_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Task task;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForTask_003Ed__3(int _003C_003E1__state)
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

	public static void Start(IEnumerator coroutine)
	{
	}

	public static IEnumerator StartEnumerator(IEnumerator coroutine)
	{
		return null;
	}

	public static void Stop(IEnumerator coroutine)
	{
	}

	public static IEnumerator WaitForTask(Task task)
	{
		return null;
	}
}
