using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimatorExtensions
{
	private sealed class _003CPlayAndWaitForAnimation_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animator animator;

		public string stateName;

		public int layerIndex;

		private float _003Clength_003E5__2;

		private float _003Ctimer_003E5__3;

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

		public _003CPlayAndWaitForAnimation_003Ed__0(int _003C_003E1__state)
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

	public static IEnumerator PlayAndWaitForAnimation(Animator animator, string stateName, int layerIndex = 0)
	{
		throw null;
	}
}
