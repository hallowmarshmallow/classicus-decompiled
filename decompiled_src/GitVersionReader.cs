using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitVersionReader : MonoBehaviour
{
	private sealed class _003CReadGitVersion_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GitVersionReader _003C_003E4__this;

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

		public _003CReadGitVersion_003Ed__1(int _003C_003E1__state)
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

	private void Start()
	{
		throw null;
	}

	private IEnumerator ReadGitVersion()
	{
		throw null;
	}

	private string GetJsonValue(string json, string key)
	{
		throw null;
	}

	public GitVersionReader()
	{
		throw null;
	}
}
