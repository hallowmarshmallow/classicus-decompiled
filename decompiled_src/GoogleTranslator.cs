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

		public _003CTranslateTextCoroutine_003Ed__4(int _003C_003E1__state)
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

	public static string CurrentLang
	{
		get
		{
			throw null;
		}
	}

	public static string GetLanguageCode(string language)
	{
		throw null;
	}

	public static IEnumerator TranslateTextCoroutine(string text, Action<string> onTranslated)
	{
		throw null;
	}

	private static string ReplaceGlitchedSymbols(string text)
	{
		throw null;
	}
}
