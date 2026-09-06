using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachedLobbyMusicFader : MonoBehaviour
{
	private sealed class _003CFadeRoutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DetachedLobbyMusicFader _003C_003E4__this;

		private AudioSource _003ClobbyAudio_003E5__2;

		private float _003CstartVolume_003E5__3;

		private float _003Celapsed_003E5__4;

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

		public _003CFadeRoutine_003Ed__3(int _003C_003E1__state)
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

	private float fadeDuration;

	public static void Spawn(float duration)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private IEnumerator FadeRoutine()
	{
		throw null;
	}

	private static AudioSource FindLobbyAudio()
	{
		throw null;
	}

	public DetachedLobbyMusicFader()
	{
		throw null;
	}
}
