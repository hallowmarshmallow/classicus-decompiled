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

		internal string _003CParseTextWithHyperlinks_003Eb__0(Match m)
		{
			return null;
		}

		internal string _003CParseTextWithHyperlinks_003Eb__1(Match m)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public HyperlinkTrigger trigger;

		internal void _003CGenerateCollidersFromLinkInfo_003Eb__0()
		{
		}

		internal void _003CGenerateCollidersFromLinkInfo_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public int index;

		public List<(string, string, string)> linkList;

		internal string _003CExtractHyperlinks_003Eb__0(Match m)
		{
			return null;
		}

		internal string _003CExtractHyperlinks_003Eb__1(Match m)
		{
			return null;
		}
	}

	private sealed class _003CWaitAndGenerateColliders_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClickableHyperlink _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitAndGenerateColliders_003Ed__22(int _003C_003E1__state)
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
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTMPTextChanged(UnityEngine.Object obj)
	{
	}

	private bool HasUnparsedLinks(string text)
	{
		return false;
	}

	private bool HasAnyLinks(string text)
	{
		return false;
	}

	public void ParseTextWithHyperlinks()
	{
	}

	private static string BalanceColorTags(string text)
	{
		return null;
	}

	private IEnumerator WaitAndGenerateColliders()
	{
		return null;
	}

	private static bool IsFinitePositive(Vector2 size)
	{
		return false;
	}

	private void GenerateCollidersFromLinkInfo()
	{
	}

	public void OpenLink(string url)
	{
	}

	public void HighlightLink(string url, bool highlight)
	{
	}

	public static string ExtractHyperlinks(string text, out List<(string, string, string)> links)
	{
		links = null;
		return null;
	}

	public static string RestoreHyperlinks(string translatedText, List<(string, string, string)> links)
	{
		return null;
	}

	private void CleanupColliders()
	{
	}

	private void OnDestroy()
	{
	}
}
