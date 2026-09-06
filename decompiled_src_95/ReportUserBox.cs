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

		internal void _003CCoSubmitStaffReport_003Eb__0(bool success, string err)
		{
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSubmitStaffReport_003Ed__19(int _003C_003E1__state)
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
	}

	private void OnDisable()
	{
	}

	public void Show(int clientId)
	{
	}

	public void ShowStaffContact()
	{
	}

	public void Hide()
	{
	}

	public void Select()
	{
	}

	private IEnumerator CoSubmitStaffReport()
	{
		return null;
	}

	private static Transform FindDeepChild(Transform root, string name)
	{
		return null;
	}

	public void OnCustomReasonChanged()
	{
	}

	public void SetPreset(string preset)
	{
	}

	private bool IsReasonValid()
	{
		return false;
	}

	private void UpdateConfirmButtonState()
	{
	}

	private static void SetPlayerButtonMasksActive(bool active)
	{
	}
}
