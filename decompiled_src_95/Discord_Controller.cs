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

		internal void _003CTearDownSdk_003Eb__28_0(Result _)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public Discord_Controller _003C_003E4__this;

		public string details;

		public string state;

		internal void _003CPush_003Eb__0(Result result)
		{
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
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void TryCreateSdk()
	{
	}

	private void TearDownSdk(bool clearPresence = false)
	{
	}

	private void PumpCallbacks()
	{
	}

	private void Tick(bool force)
	{
	}

	private void ResolveState(out string details, out string state)
	{
		details = null;
		state = null;
	}

	private static string CurrentGameModeName()
	{
		return null;
	}

	private static string BuildMatchDetails()
	{
		return null;
	}

	private static string BuildMatchState(AmongUsClient client)
	{
		return null;
	}

	private static string BuildLobbyState(AmongUsClient client)
	{
		return null;
	}

	private void Push(string details, string state)
	{
	}
}
