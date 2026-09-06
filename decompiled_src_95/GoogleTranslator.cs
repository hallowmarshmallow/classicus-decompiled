using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public static class GoogleTranslator
{
	private sealed class _003CTranslateTextCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<string> onTranslated;

		public string text;

		private UnityWebRequest _003CwebRequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTranslateTextCoroutine_003Ed__4(int _003C_003E1__state)
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

	public static string CurrentLang => null;

	public static string GetLanguageCode(string language)
	{
		return null;
	}

	public static IEnumerator TranslateTextCoroutine(string text, Action<string> onTranslated)
	{
		return null;
	}

	private static string ReplaceGlitchedSymbols(string text)
	{
		return null;
	}
}
