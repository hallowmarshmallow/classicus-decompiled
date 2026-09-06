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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartGame_003Ed__12(int _003C_003E1__state)
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

	private const float MapReadyTimeoutSeconds = 30f;

	public AudioClip IntroMusic;

	public string targetScene;

	public SpriteRenderer FillScreen;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public GameModes GameMode;

	public void Start()
	{
	}

	private static string FreeplayMapName()
	{
		return null;
	}

	public void OnClick()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}

	private IEnumerator CoStartGame()
	{
		return null;
	}
}
