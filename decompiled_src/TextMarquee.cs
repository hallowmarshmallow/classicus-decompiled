using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMarquee : MonoBehaviour
{
	private sealed class _003CRun_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextMarquee _003C_003E4__this;

		private Vector3 _003CoriginalPosition_003E5__2;

		private int _003Ci_003E5__3;

		private Vector3 _003CtempPosition_003E5__4;

		private float _003Ctimer3_003E5__5;

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

		public _003CRun_003Ed__6(int _003C_003E1__state)
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

	public TextMeshPro Target;

	private string targetText;

	public float ScrollSpeed;

	public float PauseTime;

	public float AreaWidth;

	public void Start()
	{
		throw null;
	}

	private IEnumerator Run()
	{
		throw null;
	}

	public TextMarquee()
	{
		throw null;
	}
}
