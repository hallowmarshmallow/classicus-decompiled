using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class FindGameButton : MonoBehaviour, IConnectButton
{
	private sealed class _003CConnectForFindGame_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Celapsed_003E5__2;

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

		public _003CConnectForFindGame_003Ed__3(int _003C_003E1__state)
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

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public void OnClick()
	{
		throw null;
	}

	private IEnumerator ConnectForFindGame()
	{
		throw null;
	}

	public void StartIcon()
	{
		throw null;
	}

	public void StopIcon()
	{
		throw null;
	}

	public FindGameButton()
	{
		throw null;
	}
}
