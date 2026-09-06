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

		T IEnumerator<T>.Current
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

		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CircleBuffer<T> _003C_003E4__this;

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

		public _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__5(int _003C_003E1__state)
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

	private T[] data;

	private int idx;

	private int count;

	public CircleBuffer(int size)
	{
		throw null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	public override string ToString()
	{
		throw null;
	}
}
