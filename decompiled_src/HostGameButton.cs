using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class HostGameButton : MonoBehaviour, IConnectButton
{
	private sealed class _003CCoStartGame_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HostGameButton _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private string _003CfreeplayMap_003E5__3;

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

		public _003CCoStartGame_003Ed__12(int _003C_003E1__state)
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

	private const float MapReadyTimeoutSeconds = 30f;

	public AudioClip IntroMusic;

	public string targetScene;

	public SpriteRenderer FillScreen;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public GameModes GameMode;

	public void Start()
	{
		throw null;
	}

	private static string FreeplayMapName()
	{
		throw null;
	}

	public void OnClick()
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

	private IEnumerator CoStartGame()
	{
		throw null;
	}

	public HostGameButton()
	{
		throw null;
	}
}
