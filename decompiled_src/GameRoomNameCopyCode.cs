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

		public _003CShowCopied_003Ed__17(int _003C_003E1__state)
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
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private static bool IsOnlineGame()
	{
		throw null;
	}

	private void OnMouseEnter()
	{
		throw null;
	}

	private void OnMouseExit()
	{
		throw null;
	}

	private void OnMouseDown()
	{
		throw null;
	}

	private IEnumerator ShowCopied()
	{
		throw null;
	}

	private void ApplyColor(Color color)
	{
		throw null;
	}

	private void Play(AudioClip clip)
	{
		throw null;
	}

	public GameRoomNameCopyCode()
	{
		throw null;
	}
}
