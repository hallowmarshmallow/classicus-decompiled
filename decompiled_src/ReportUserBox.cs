using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReportUserBox : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public bool ok;

		public string error;

		public _003C_003Ec__DisplayClass19_0()
		{
			throw null;
		}

		internal void _003CCoSubmitStaffReport_003Eb__0(bool success, string err)
		{
			throw null;
		}
	}

	private sealed class _003CCoSubmitStaffReport_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReportUserBox _003C_003E4__this;

		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		private Transform _003Csuccess1_003E5__2;

		private List<GameObject> _003Chidden_003E5__3;

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

		public _003CCoSubmitStaffReport_003Ed__19(int _003C_003E1__state)
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

	private const int MIN_CUSTOM_REASON_LENGTH = 5;

	public int targetId;

	public bool isOpen;

	public bool staffContactMode;

	private bool submitting;

	public TextMeshPro TitleText;

	public TextBoxTMP TextBox;

	public PassiveButton ConfirmButton;

	public SpriteRenderer ConfirmButtonRenderer;

	public ManualInspectorTMPTranslator HackingTranslator;

	public ManualInspectorTMPTranslator BadNameTranslator;

	public ManualInspectorTMPTranslator HarassmentTranslator;

	public ManualInspectorTMPTranslator ImpersonatingTranslator;

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	public void Show(int clientId)
	{
		throw null;
	}

	public void ShowStaffContact()
	{
		throw null;
	}

	public void Hide()
	{
		throw null;
	}

	public void Select()
	{
		throw null;
	}

	private IEnumerator CoSubmitStaffReport()
	{
		throw null;
	}

	private static Transform FindDeepChild(Transform root, string name)
	{
		throw null;
	}

	public void OnCustomReasonChanged()
	{
		throw null;
	}

	public void SetPreset(string preset)
	{
		throw null;
	}

	private bool IsReasonValid()
	{
		throw null;
	}

	private void UpdateConfirmButtonState()
	{
		throw null;
	}

	private static void SetPlayerButtonMasksActive(bool active)
	{
		throw null;
	}

	public ReportUserBox()
	{
		throw null;
	}
}
