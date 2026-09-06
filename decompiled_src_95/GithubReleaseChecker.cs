using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class GithubReleaseChecker : MonoBehaviour
{
	private sealed class _003CFetchLatestRelease_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GithubReleaseChecker _003C_003E4__this;

		private string _003Curl_003E5__2;

		private UnityWebRequest _003CwebRequest_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFetchLatestRelease_003Ed__18(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public GameObject UpdateRequired;

	public TMP_Text FetchingUpdate;

	public bool WillDo;

	public static GithubReleaseChecker Instance;

	public ClickableHyperlink linkHandler;

	public TextMeshPro popupText;

	public GameObject upgradeButton;

	public GameObject ignoreButton;

	public InAppUpdater inAppUpdater;

	public float delayTime;

	public bool forceUpdateTest;

	private const bool AlwaysSkip = false;

	private const string apiUrl = "https://api.github.com/repos/{0}/{1}/releases/latest";

	private const int RequestTimeoutSeconds = 8;

	private GitHubRelease latestRelease;

	public void Awake()
	{
	}

	public void Skip()
	{
	}

	public void Upgrade()
	{
	}

	public IEnumerator FetchLatestRelease()
	{
		return null;
	}
}
