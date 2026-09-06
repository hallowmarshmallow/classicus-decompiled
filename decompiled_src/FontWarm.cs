using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class FontWarm
{
	private sealed class _003CCoWarmSpread_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IList<TextAsset> languages;

		private TMP_FontAsset[] _003Cfonts_003E5__2;

		private int _003Cadded_003E5__3;

		private int _003Ci_003E5__4;

		private string _003Cpending_003E5__5;

		private int _003Cat_003E5__6;

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

		public _003CCoWarmSpread_003Ed__5(int _003C_003E1__state)
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

	private static readonly HashSet<char> _warmed;

	private static bool _spreading;

	public static void Warm(string source)
	{
		throw null;
	}

	public static void WarmSpread(MonoBehaviour host, IList<TextAsset> languages)
	{
		throw null;
	}

	private static IEnumerator CoWarmSpread(IList<TextAsset> languages)
	{
		throw null;
	}

	private static string CollectNew(string source)
	{
		throw null;
	}

	private static void AddToFonts(TMP_FontAsset[] fonts, string batch)
	{
		throw null;
	}

	static FontWarm()
	{
		throw null;
	}
}
