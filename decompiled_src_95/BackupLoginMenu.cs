using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BackupLoginMenu : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public TextBoxTMP captured;

		internal void _003CEnsureInput_003Eb__0()
		{
		}
	}

	private sealed class _003CCoShowSuccess_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BackupLoginMenu _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowSuccess_003Ed__51(int _003C_003E1__state)
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

	public PassiveButton loginButton;

	public PassiveButton registerButton;

	public PassiveButton forgotPassButton;

	public PassiveButton closeButton;

	public TextBoxTMP emailInput;

	public TextBoxTMP passInput;

	public TextMeshPro statusText;

	public GameObject successRoot;

	private const int MinChars = 5;

	private bool _busy;

	private bool _wired;

	private readonly List<GameObject> _hiddenForSuccess;

	private readonly List<GameObject> _hiddenForLoggedIn;

	private bool _loggedInLayout;

	private TMP_Text _loginLabel;

	private bool _awaitingNewPass;

	private GameObject _emailPlaceholder;

	private GameObject _passPlaceholder;

	private TMP_Text _forgotLabel;

	private bool _mailRevealed;

	private bool _mailHovered;

	private static bool IsLoggedIn => false;

	private static bool HasTempPass => false;

	private static string T(StringNames id, string fallback)
	{
		return null;
	}

	public void RefreshTexts()
	{
	}

	private void Awake()
	{
	}

	private void WireOnce()
	{
	}

	private PassiveButton EnsureButton(string childName)
	{
		return null;
	}

	private TextBoxTMP EnsureInput(string groupName, bool hidden)
	{
		return null;
	}

	private static void AddBoundsCollider(GameObject target, Transform boundsSource)
	{
	}

	private void EnsureFill()
	{
	}

	private void OnEnable()
	{
	}

	private void ClearPasswordInput()
	{
	}

	private void ApplyLoggedInLayout(bool force = false)
	{
	}

	private void RenderLoggedInStatus()
	{
	}

	private void UpdateMailReveal()
	{
	}

	private bool HoldsKeeper(Transform child)
	{
		return false;
	}

	private void RestoreLoggedInHidden()
	{
	}

	private void Update()
	{
	}

	private static string GetPassword(TextBoxTMP box)
	{
		return null;
	}

	private static string GetText(TextBoxTMP box)
	{
		return null;
	}

	private static void SetButtonUsable(PassiveButton btn, bool usable)
	{
	}

	private void DoRegister()
	{
	}

	private void DoLogin()
	{
	}

	private void DoSetNewPass()
	{
	}

	private void DoLogout()
	{
	}

	private void DoForgotPass()
	{
	}

	private void OnAuthDone(bool ok, string error)
	{
	}

	private void SetStatus(string message)
	{
	}

	private IEnumerator CoShowSuccess()
	{
		return null;
	}

	private void RestoreHidden()
	{
	}

	public void CloseScreen()
	{
	}

	private void _003CDoSetNewPass_003Eb__46_0(bool ok, string error)
	{
	}

	private void _003CDoLogout_003Eb__47_0(bool ok, string error)
	{
	}

	private void _003CDoForgotPass_003Eb__48_0(bool ok, string error)
	{
	}
}
