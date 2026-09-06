using System;
using System.Diagnostics;
using Discord;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Discord_Controller : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ActivityManager.ClearActivityHandler _003C_003E9__28_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CTearDownSdk_003Eb__28_0(Result _)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public Discord_Controller _003C_003E4__this;

		public string details;

		public string state;

		public _003C_003Ec__DisplayClass36_0()
		{
			throw null;
		}

		internal void _003CPush_003Eb__0(Result result)
		{
			throw null;
		}
	}

	public long applicationID;

	public string largeImageKey;

	public string largeImageText;

	private const float TICK_INTERVAL = 2f;

	private const float FORCE_PUSH_INTERVAL = 30f;

	private const float CALLBACK_INTERVAL = 1f / 30f;

	private const float CALLBACK_WARN_MS = 2f;

	private const int MAX_CALLBACK_FAILURES = 5;

	private const float RECONNECT_INTERVAL = 15f;

	private float _tickTimer;

	private float _forcePushTimer;

	private float _callbackTimer;

	private float _reconnectTimer;

	private global::Discord.Discord _discord;

	private long _sessionStart;

	private int _callbackFailures;

	private bool _loggedInitFail;

	private string _lastDetails;

	private string _lastState;

	private readonly Stopwatch _sw;

	private static Discord_Controller _instance;

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void OnApplicationQuit()
	{
		throw null;
	}

	private void TryCreateSdk()
	{
		throw null;
	}

	private void TearDownSdk(bool clearPresence = false)
	{
		throw null;
	}

	private void PumpCallbacks()
	{
		throw null;
	}

	private void Tick(bool force)
	{
		throw null;
	}

	private void ResolveState(out string details, out string state)
	{
		throw null;
	}

	private static string CurrentGameModeName()
	{
		throw null;
	}

	private static string BuildMatchDetails()
	{
		throw null;
	}

	private static string BuildMatchState(AmongUsClient client)
	{
		throw null;
	}

	private static string BuildLobbyState(AmongUsClient client)
	{
		throw null;
	}

	private void Push(string details, string state)
	{
		throw null;
	}

	public Discord_Controller()
	{
		throw null;
	}
}
