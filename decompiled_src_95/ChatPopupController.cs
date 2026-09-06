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

		internal void _003CCoWarningSequence_003Eb__0(string result)
		{
		}
	}

	private sealed class _003CCoEnsureAlertTitleCached_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatPopupController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoEnsureAlertTitleCached_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoWarningSequence_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatPopupController _003C_003E4__this;

		public string warningMessage;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWarningSequence_003Ed__24(int _003C_003E1__state)
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
		return null;
	}

	private void OnEnable()
	{
	}

	public void ShowReport()
	{
	}

	public void ShowWarning(string warningMessage)
	{
	}

	private void ForceActivate()
	{
	}

	private IEnumerator CoWarningSequence(string warningMessage)
	{
		return null;
	}

	private void CancelWarningRoutine()
	{
	}

	private void _003CCoEnsureAlertTitleCached_003Eb__19_0(string result)
	{
	}
}
