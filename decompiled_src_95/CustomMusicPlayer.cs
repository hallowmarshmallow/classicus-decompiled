using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomMusicPlayer : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string[]> _003C_003E9__33_0;

		public static NativeFilePicker.FilePickedCallback _003C_003E9__34_0;

		internal void _003CPickFileDesktop_003Eb__33_0(string[] paths)
		{
		}

		internal void _003CPickFileMobile_003Eb__34_0(string path)
		{
		}
	}

	private sealed class _003CCoAttemptLoad_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public AudioType type;

		public string path;

		public CustomMusicPlayer _003C_003E4__this;

		public bool stream;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAttemptLoad_003Ed__49(int _003C_003E1__state)
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

	private sealed class _003CCoLoadAndPlay_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public CustomMusicPlayer _003C_003E4__this;

		private string _003Curl_003E5__2;

		private AudioType _003Ctype_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoLoadAndPlay_003Ed__47(int _003C_003E1__state)
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

	private static CustomMusicPlayer _003CInstance_003Ek__BackingField;

	private static Action m_Changed;

	private const float PresenceCheckInterval = 0.5f;

	private float _presenceTimer;

	private AudioSource _source;

	private AudioClip _clip;

	private string _loadedPath;

	private Coroutine _loading;

	private UnityWebRequest _stream;

	private UnityWebRequest _inflight;

	private static bool _instanceAlive;

	private static int _pickBusy;

	private string _loadingPath;

	private static readonly string[] AudioExtensions;

	private const string MobileCopyFolder = "CustomMusic";

	private static string _pendingPickedPath;

	private static bool _pendingPickFinished;

	private static readonly object PendingPickLock;

	public static CustomMusicPlayer Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	public static bool PickInFlight => false;

	public static string SelectedPath => null;

	public static string SelectedFileName => null;

	public static bool Enabled => false;

	public static bool InLobby => false;

	public static event Action Changed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void RaiseChanged()
	{
	}

	private static void Bootstrap()
	{
	}

	private void Awake()
	{
	}

	private void TryBindMixer()
	{
	}

	public static void PickFile()
	{
	}

	private static bool PickFileDesktop()
	{
		return false;
	}

	private static bool PickFileMobile()
	{
		return false;
	}

	private static string[] MobileAudioTypes()
	{
		return null;
	}

	private static string CopyForMobile(string sourcePath)
	{
		return null;
	}

	private static void FinishPick(string path)
	{
	}

	private static void ApplyPick(string path)
	{
	}

	private void Update()
	{
	}

	public void Apply()
	{
	}

	public void Stop()
	{
	}

	private IEnumerator CoLoadAndPlay(string path)
	{
		return null;
	}

	private bool IsLoaded(string path)
	{
		return false;
	}

	private IEnumerator CoAttemptLoad(string url, string path, AudioType type, bool stream)
	{
		return null;
	}

	private void ReleaseCurrent()
	{
	}

	private void OnDestroy()
	{
	}

	private static AudioType AudioTypeFor(string path)
	{
		return default(AudioType);
	}
}
