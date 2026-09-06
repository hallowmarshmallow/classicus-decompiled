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

		public _003CJoinGame_003Ed__11(int _003C_003E1__state)
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
		throw null;
	}

	private IEnumerator JoinGame()
	{
		throw null;
	}

	public void SetGameName(string[] gameNameParts)
	{
		throw null;
	}

	public void StartIcon()
	{
		throw null;
	}

	public void StopIcon()
	{
		throw null;
	}

	public JoinGameButton()
	{
		throw null;
	}
}
