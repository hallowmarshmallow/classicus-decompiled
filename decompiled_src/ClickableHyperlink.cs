using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class ClickableHyperlink : MonoBehaviour
{
	private struct LinkData
	{
		public string Url;

		public BoxCollider2D Collider;

		public GameObject ColliderObject;
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string colorHex;

		public _003C_003Ec__DisplayClass20_0()
		{
			throw null;
		}

		internal string _003CParseTextWithHyperlinks_003Eb__0(Match m)
		{
			throw null;
		}

		internal string _003CParseTextWithHyperlinks_003Eb__1(Match m)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public HyperlinkTrigger trigger;

		public _003C_003Ec__DisplayClass24_0()
		{
			throw null;
		}

		internal void _003CGenerateCollidersFromLinkInfo_003Eb__0()
		{
			throw null;
		}

		internal void _003CGenerateCollidersFromLinkInfo_003Eb__1()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public int index;

		public List<(string, string, string)> linkList;

		public _003C_003Ec__DisplayClass27_0()
		{
			throw null;
		}

		internal string _003CExtractHyperlinks_003Eb__0(Match m)
		{
			throw null;
		}

		internal string _003CExtractHyperlinks_003Eb__1(Match m)
		{
			throw null;
		}
	}

	private sealed class _003CWaitAndGenerateColliders_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClickableHyperlink _003C_003E4__this;

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

		public _003CWaitAndGenerateColliders_003Ed__22(int _003C_003E1__state)
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

	public TMP_Text textMeshPro;

	public float scalingMultiplier;

	public bool autoParseOnTextChange;

	public Color normalColor;

	public Color highlightColor;

	public AudioClip hoverSound;

	private static AudioMixerGroup cachedSfxGroup;

	private static readonly string LINK_PATTERN;

	private static readonly string HYPERLINK_PATTERN;

	private static readonly string UNSTYLED_LINK_PATTERN;

	private readonly List<LinkData> activeLinks;

	private bool isParsing;

	private string lastParsedText;

	private void Start()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnTMPTextChanged(UnityEngine.Object obj)
	{
		throw null;
	}

	private bool HasUnparsedLinks(string text)
	{
		throw null;
	}

	private bool HasAnyLinks(string text)
	{
		throw null;
	}

	public void ParseTextWithHyperlinks()
	{
		throw null;
	}

	private static string BalanceColorTags(string text)
	{
		throw null;
	}

	private IEnumerator WaitAndGenerateColliders()
	{
		throw null;
	}

	private static bool IsFinitePositive(Vector2 size)
	{
		throw null;
	}

	private void GenerateCollidersFromLinkInfo()
	{
		throw null;
	}

	public void OpenLink(string url)
	{
		throw null;
	}

	public void HighlightLink(string url, bool highlight)
	{
		throw null;
	}

	public static string ExtractHyperlinks(string text, out List<(string, string, string)> links)
	{
		throw null;
	}

	public static string RestoreHyperlinks(string translatedText, List<(string, string, string)> links)
	{
		throw null;
	}

	private void CleanupColliders()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public ClickableHyperlink()
	{
		throw null;
	}

	static ClickableHyperlink()
	{
		throw null;
	}
}
