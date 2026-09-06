using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public static class StaffLobbyMusicBroadcast
{
	private sealed class _003CCoPlay_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		private UnityWebRequest _003Creq_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlay_003Ed__1(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static void PlayFromUrl(string url)
	{
	}

	private static IEnumerator CoPlay(string url)
	{
		return null;
	}
}
