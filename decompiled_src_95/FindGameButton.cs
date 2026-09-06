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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CConnectForFindGame_003Ed__3(int _003C_003E1__state)
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

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public void OnClick()
	{
	}

	private IEnumerator ConnectForFindGame()
	{
		return null;
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
