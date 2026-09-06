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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRescanRoutine_003Ed__3(int _003C_003E1__state)
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

	private Dictionary<AudioSource, bool> audioStates;

	private Transform ddolRoot;

	private void Start()
	{
	}

	private IEnumerator RescanRoutine()
	{
		return null;
	}

	private void ScanAllAudioSources()
	{
	}

	private void ReportAudioStart(AudioSource src)
	{
	}

	private void ReportAudioStop(AudioSource src)
	{
	}

	private Transform GetDontDestroyOnLoadRoot()
	{
		return null;
	}

	private bool IsInDontDestroyOnLoad(GameObject go)
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
