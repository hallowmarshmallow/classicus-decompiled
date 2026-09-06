using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class JoinGameButton : MonoBehaviour, IConnectButton
{
	private sealed class _003CJoinGame_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JoinGameButton _003C_003E4__this;

		private float _003Ctime2_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CJoinGame_003Ed__11(int _003C_003E1__state)
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

	public AudioClip IntroMusic;

	public AudioClip LobbyFormSound;

	public TextBox GameIdText;

	public TextRenderer gameNameText;

	public float timeRecieved;

	public SpriteRenderer FillScreen;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public GameModes GameMode;

	public string netAddress;

	public void OnClick()
	{
	}

	private IEnumerator JoinGame()
	{
		return null;
	}

	public void SetGameName(string[] gameNameParts)
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
