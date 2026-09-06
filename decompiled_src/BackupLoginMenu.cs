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

		public _003C_003Ec__DisplayClass28_0()
		{
			throw null;
		}

		internal void _003CEnsureInput_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoShowSuccess_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BackupLoginMenu _003C_003E4__this;

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

		public _003CCoShowSuccess_003Ed__51(int _003C_003E1__state)
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

	private static bool IsLoggedIn
	{
		get
		{
			throw null;
		}
	}

	private static bool HasTempPass
	{
		get
		{
			throw null;
		}
	}

	private static string T(StringNames id, string fallback)
	{
		throw null;
	}

	public void RefreshTexts()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void WireOnce()
	{
		throw null;
	}

	private PassiveButton EnsureButton(string childName)
	{
		throw null;
	}

	private TextBoxTMP EnsureInput(string groupName, bool hidden)
	{
		throw null;
	}

	private static void AddBoundsCollider(GameObject target, Transform boundsSource)
	{
		throw null;
	}

	private void EnsureFill()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void ClearPasswordInput()
	{
		throw null;
	}

	private void ApplyLoggedInLayout(bool force = false)
	{
		throw null;
	}

	private void RenderLoggedInStatus()
	{
		throw null;
	}

	private void UpdateMailReveal()
	{
		throw null;
	}

	private bool HoldsKeeper(Transform child)
	{
		throw null;
	}

	private void RestoreLoggedInHidden()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static string GetPassword(TextBoxTMP box)
	{
		throw null;
	}

	private static string GetText(TextBoxTMP box)
	{
		throw null;
	}

	private static void SetButtonUsable(PassiveButton btn, bool usable)
	{
		throw null;
	}

	private void DoRegister()
	{
		throw null;
	}

	private void DoLogin()
	{
		throw null;
	}

	private void DoSetNewPass()
	{
		throw null;
	}

	private void DoLogout()
	{
		throw null;
	}

	private void DoForgotPass()
	{
		throw null;
	}

	private void OnAuthDone(bool ok, string error)
	{
		throw null;
	}

	private void SetStatus(string message)
	{
		throw null;
	}

	private IEnumerator CoShowSuccess()
	{
		throw null;
	}

	private void RestoreHidden()
	{
		throw null;
	}

	public void CloseScreen()
	{
		throw null;
	}

	public BackupLoginMenu()
	{
		throw null;
	}

	private void _003CDoSetNewPass_003Eb__46_0(bool ok, string error)
	{
		throw null;
	}

	private void _003CDoLogout_003Eb__47_0(bool ok, string error)
	{
		throw null;
	}

	private void _003CDoForgotPass_003Eb__48_0(bool ok, string error)
	{
		throw null;
	}
}
