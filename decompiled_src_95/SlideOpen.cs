using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideOpen : MonoBehaviour
{
	private sealed class _003CAnimate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideOpen _003C_003E4__this;

		public Vector3 target;

		private Vector3 _003Cfrom_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__13(int _003C_003E1__state)
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

	public float duration;

	public Vector3 closedPosition;

	public Vector3 openPosition;

	public Button.ButtonClickedEvent OnClose;

	public Camera parentCam;

	public bool isOpen;

	private Coroutine anim;

	public void Awake()
	{
	}

	public void Toggle()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void SnapClosed()
	{
	}

	private void StartSlide(Vector3 target)
	{
	}

	private IEnumerator Animate(Vector3 target)
	{
		return null;
	}
}
