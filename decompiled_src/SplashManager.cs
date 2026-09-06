using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SplashManager : MonoBehaviour
{
	private sealed class _003CInitializeRefdata_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SplashManager _003C_003E4__this;

		private AsyncOperation _003Cpreload_003E5__2;

		private float _003Celapsed_003E5__3;

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

		public _003CInitializeRefdata_003Ed__6(int _003C_003E1__state)
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

	public TextMeshPro loadingText;

	public GithubReleaseChecker ReleaseChecker;

	private SceneChanger sceneChanger;

	private const float MaxWaitTime = 12f;

	private const float PollInterval = 0.15f;

	private void Start()
	{
		throw null;
	}

	private IEnumerator InitializeRefdata()
	{
		throw null;
	}

	public SplashManager()
	{
		throw null;
	}
}
