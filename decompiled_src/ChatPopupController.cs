using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatPopupController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ChatPopupController _003C_003E4__this;

		public string warningMessage;

		public _003C_003Ec__DisplayClass24_0()
		{
			throw null;
		}

		internal void _003CCoWarningSequence_003Eb__0(string result)
		{
			throw null;
		}
	}

	private sealed class _003CCoEnsureAlertTitleCached_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatPopupController _003C_003E4__this;

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

		public _003CCoEnsureAlertTitleCached_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoWarningSequence_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatPopupController _003C_003E4__this;

		public string warningMessage;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

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

		public _003CCoWarningSequence_003Ed__24(int _003C_003E1__state)
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

	public TextMeshPro titleTMP;

	public TextMeshPro messageTMP;

	public ManualInspectorTMPTranslator titleTranslator;

	public ManualInspectorTMPTranslator messageTranslator;

	public AudioSource popupAudio;

	public AudioClip reportSound;

	public AudioClip warningSound;

	public SpriteRenderer iconRenderer;

	public Sprite reportSprite;

	public Sprite warningSprite;

	public DisableSelf disableSelf;

	private const float REPORT_DURATION = 8f;

	private const float WARNING_DURATION = 15f;

	private const float REPORT_PITCH = 0.9f;

	private const float DEFAULT_PITCH = 1f;

	private const string SYSTEM_ALERT_TITLE = "SYSTEM ALERT";

	private Coroutine warningRoutine;

	private string cachedAlertTitle;

	private bool titleTranslated;

	private IEnumerator CoEnsureAlertTitleCached()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	public void ShowReport()
	{
		throw null;
	}

	public void ShowWarning(string warningMessage)
	{
		throw null;
	}

	private void ForceActivate()
	{
		throw null;
	}

	private IEnumerator CoWarningSequence(string warningMessage)
	{
		throw null;
	}

	private void CancelWarningRoutine()
	{
		throw null;
	}

	public ChatPopupController()
	{
		throw null;
	}

	private void _003CCoEnsureAlertTitleCached_003Eb__19_0(string result)
	{
		throw null;
	}
}
