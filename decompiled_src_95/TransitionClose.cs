using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionClose : MonoBehaviour
{
	private sealed class _003CCoClose_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransitionClose _003C_003E4__this;

		private Vector3 _003Cscale_003E5__2;

		private float _003CtargetScale_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoClose_003Ed__6(int _003C_003E1__state)
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

	public GameObject Content;

	public SpriteRenderer BackgroundImage;

	public Vector3 SourcePos;

	public Vector3 TargetPos;

	private bool animating;

	public void Close()
	{
	}

	private IEnumerator CoClose()
	{
		return null;
	}
}
