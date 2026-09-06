using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAnimTestButton : MonoBehaviour
{
	private sealed class _003CCoRestoreSkin_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameData.PlayerInfo info;

		public string prevSkin;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRestoreSkin_003Ed__3(int _003C_003E1__state)
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

	private int currentIndex;

	public void PlayNextKillAnimation()
	{
	}

	private void PlayRhmKill(KillOverlay killOverlay, GameData.PlayerInfo localInfo)
	{
	}

	private IEnumerator CoRestoreSkin(GameData.PlayerInfo info, string prevSkin)
	{
		return null;
	}

	private KillOverlay FindKillOverlay()
	{
		return null;
	}
}
