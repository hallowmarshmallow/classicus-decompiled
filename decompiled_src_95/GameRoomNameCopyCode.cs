using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class GameRoomNameCopyCode : MonoBehaviour
{
	private sealed class _003CShowCopied_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRoomNameCopyCode _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCopied_003Ed__17(int _003C_003E1__state)
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

	public TextMeshPro targetText;

	public GameObject copyCodeObject;

	public GameObject copiedTextObject;

	public Color normalColor;

	public Color hoverColor;

	public AudioClip hoverSound;

	public AudioClip clickSound;

	public AudioMixerGroup sfxMixerGroup;

	public float copiedDisplayDuration;

	private AudioSource m_audio;

	private Coroutine m_hideCoroutine;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private static bool IsOnlineGame()
	{
		return false;
	}

	private void OnMouseEnter()
	{
	}

	private void OnMouseExit()
	{
	}

	private void OnMouseDown()
	{
	}

	private IEnumerator ShowCopied()
	{
		return null;
	}

	private void ApplyColor(Color color)
	{
	}

	private void Play(AudioClip clip)
	{
	}
}
