using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataTabLobbyController : MonoBehaviour, ITranslatedText
{
	private sealed class _003CStart_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DataTabLobbyController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStart_003Ed__28(int _003C_003E1__state)
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

	public TextMeshPro labelTMP;

	public DataButtonTranslator dataTranslator;

	public GameObject moreOptionsGroup;

	public GameObject tosOpen;

	public GameObject backUp;

	public GameObject languages;

	public GameObject cantChangeInGame;

	public string English;

	public string Portuguese;

	public string SpanishSpain;

	public string SpanishMexico;

	public string SpanishArgentina;

	public string German;

	public string Dutch;

	public string Swedish;

	public string Italian;

	public string Polish;

	public string Russian;

	public string Turkish;

	public string Vietnamese;

	public string French;

	public string Korean;

	public string Japanese;

	public string Arabic;

	private const string OnlineGameScene = "OnlineGame";

	private const float CheckInterval = 1f;

	private float _checkTimer;

	private bool _inLobby;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ResetText()
	{
	}

	private void ApplyCurrentState()
	{
	}

	private void WriteMoreOptionsLabel()
	{
	}

	private string Pick(string value)
	{
		return null;
	}

	private static bool IsOnlineGameLoaded()
	{
		return false;
	}

	private static void SetActive(GameObject go, bool active)
	{
	}
}
