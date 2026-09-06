using System;
using System.Collections;
using System.Collections.Generic;

public class CircleBuffer<T> : IEnumerable<T>, IEnumerable where T : class
{
	private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public CircleBuffer<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		T IEnumerator<T>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CircleBuffer<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__5(int _003C_003E1__state)
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

	private T[] data;

	private int idx;

	private int count;

	public CircleBuffer(int size)
	{
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
