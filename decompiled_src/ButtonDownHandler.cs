using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDownHandler : MonoBehaviour
{
	private sealed class _003CCoRunDown_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButtonDownHandler _003C_003E4__this;

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

		public _003CCoRunDown_003Ed__7(int _003C_003E1__state)
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

	private Coroutine downState;

	public SpriteRenderer Target;

	public Sprite UpSprite;

	public Sprite DownSprite;

	public void Start()
	{
		throw null;
	}

	public void OnDisable()
	{
		throw null;
	}

	private void StartDown()
	{
		throw null;
	}

	private IEnumerator CoRunDown()
	{
		throw null;
	}

	public ButtonDownHandler()
	{
		throw null;
	}
}
