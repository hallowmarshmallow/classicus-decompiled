using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTracker : MonoBehaviour
{
	private sealed class _003CRescanRoutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioTracker _003C_003E4__this;

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

		public _003CRescanRoutine_003Ed__3(int _003C_003E1__state)
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

	private Dictionary<AudioSource, bool> audioStates;

	private Transform ddolRoot;

	private void Start()
	{
		throw null;
	}

	private IEnumerator RescanRoutine()
	{
		throw null;
	}

	private void ScanAllAudioSources()
	{
		throw null;
	}

	private void ReportAudioStart(AudioSource src)
	{
		throw null;
	}

	private void ReportAudioStop(AudioSource src)
	{
		throw null;
	}

	private Transform GetDontDestroyOnLoadRoot()
	{
		throw null;
	}

	private bool IsInDontDestroyOnLoad(GameObject go)
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public AudioTracker()
	{
		throw null;
	}
}
