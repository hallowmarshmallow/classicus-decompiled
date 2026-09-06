using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class AnnoucementPopUpGithub : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string translatedText;

		public _003C_003Ec__DisplayClass11_0()
		{
			throw null;
		}

		internal void _003CInit_003Eb__0(string result)
		{
			throw null;
		}
	}

	private sealed class _003CInit_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnnoucementPopUpGithub _003C_003E4__this;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private uint _003CcurrentHash_003E5__2;

		private bool _003CisNew_003E5__3;

		private List<(string, string, string)> _003CextractedLinks_003E5__4;

		private UnityWebRequest _003CwebRequest_003E5__5;

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

		public _003CInit_003Ed__11(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CShowWarning_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnnoucementPopUpGithub _003C_003E4__this;

		private SpriteRenderer _003CspriteRenderer_003E5__2;

		private Color _003CstartColor_003E5__3;

		private float _003CfadeDuration_003E5__4;

		private float _003CelapsedTime_003E5__5;

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

		public _003CShowWarning_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public TMP_Text textToUpdate;

	private readonly string newsLink;

	private readonly string newsLinkPTBR;

	public ClickableHyperlink link;

	public GameObject warn;

	public AudioClip WarnSound;

	private static bool AlreadyChecked;

	private static string CachedOriginalText;

	public bool ShouldNotify;

	private bool _warningShowing;

	public static void ResetCheck()
	{
		throw null;
	}

	private uint GetStableHash(string s)
	{
		throw null;
	}

	public IEnumerator Init()
	{
		throw null;
	}

	public IEnumerator ShowWarning()
	{
		throw null;
	}

	public AnnoucementPopUpGithub()
	{
		throw null;
	}
}
