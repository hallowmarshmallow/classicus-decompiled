using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageButton : MonoBehaviour
{
	private sealed class _003CRefreshAnnouncement_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshAnnouncement_003Ed__4(int _003C_003E1__state)
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

	public TextRenderer Title;

	public PassiveButton Button;

	public TextAsset Language;

	public void Awake()
	{
	}

	private IEnumerator RefreshAnnouncement()
	{
		return null;
	}

	private void _003CAwake_003Eb__3_0()
	{
	}
}
