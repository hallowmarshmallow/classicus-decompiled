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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CPickFileDesktop_003Eb__33_0(string[] paths)
		{
			throw null;
		}

		internal void _003CPickFileMobile_003Eb__34_0(string path)
		{
			throw null;
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

		public _003CCoAttemptLoad_003Ed__49(int _003C_003E1__state)
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

	private sealed class _003CCoLoadAndPlay_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public CustomMusicPlayer _003C_003E4__this;

		private string _003Curl_003E5__2;

		private AudioType _003Ctype_003E5__3;

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

		public _003CCoLoadAndPlay_003Ed__47(int _003C_003E1__state)
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public static bool PickInFlight
	{
		get
		{
			throw null;
		}
	}

	public static string SelectedPath
	{
		get
		{
			throw null;
		}
	}

	public static string SelectedFileName
	{
		get
		{
			throw null;
		}
	}

	public static bool Enabled
	{
		get
		{
			throw null;
		}
	}

	public static bool InLobby
	{
		get
		{
			throw null;
		}
	}

	public static event Action Changed
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public static void RaiseChanged()
	{
		throw null;
	}

	private static void Bootstrap()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void TryBindMixer()
	{
		throw null;
	}

	public static void PickFile()
	{
		throw null;
	}

	private static bool PickFileDesktop()
	{
		throw null;
	}

	private static bool PickFileMobile()
	{
		throw null;
	}

	private static string[] MobileAudioTypes()
	{
		throw null;
	}

	private static string CopyForMobile(string sourcePath)
	{
		throw null;
	}

	private static void FinishPick(string path)
	{
		throw null;
	}

	private static void ApplyPick(string path)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void Apply()
	{
		throw null;
	}

	public void Stop()
	{
		throw null;
	}

	private IEnumerator CoLoadAndPlay(string path)
	{
		throw null;
	}

	private bool IsLoaded(string path)
	{
		throw null;
	}

	private IEnumerator CoAttemptLoad(string url, string path, AudioType type, bool stream)
	{
		throw null;
	}

	private void ReleaseCurrent()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private static AudioType AudioTypeFor(string path)
	{
		throw null;
	}

	public CustomMusicPlayer()
	{
		throw null;
	}

	static CustomMusicPlayer()
	{
		throw null;
	}
}
