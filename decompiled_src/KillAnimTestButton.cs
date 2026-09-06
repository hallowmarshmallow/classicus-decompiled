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

		public _003CCoRestoreSkin_003Ed__3(int _003C_003E1__state)
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

	private int currentIndex;

	public void PlayNextKillAnimation()
	{
		throw null;
	}

	private void PlayRhmKill(KillOverlay killOverlay, GameData.PlayerInfo localInfo)
	{
		throw null;
	}

	private IEnumerator CoRestoreSkin(GameData.PlayerInfo info, string prevSkin)
	{
		throw null;
	}

	private KillOverlay FindKillOverlay()
	{
		throw null;
	}

	public KillAnimTestButton()
	{
		throw null;
	}
}
