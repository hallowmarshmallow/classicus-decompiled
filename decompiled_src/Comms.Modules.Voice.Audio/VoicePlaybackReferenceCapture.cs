using UnityEngine;

namespace Comms.Modules.Voice.Audio;

public sealed class VoicePlaybackReferenceCapture : MonoBehaviour
{
	private const double RecentReferenceSeconds = 1.0;

	private const float InstallRetrySeconds = 0.5f;

	private static VoicePlaybackReferenceCapture _instance;

	private static long _lastCallbackTimestamp;

	private static int _callbacks;

	private static int _channels;

	private static int _samples;

	private static float _nextInstallAttemptAt;

	private static string _installStatus;

	private static bool _loggedInstall;

	public static string Status
	{
		get
		{
			throw null;
		}
	}

	public static bool HasRecentReference
	{
		get
		{
			throw null;
		}
	}

	public static void EnsureInstalled()
	{
		throw null;
	}

	public static void Uninstall(string status)
	{
		throw null;
	}

	public static void EnsureUninstalled(string status)
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
		throw null;
	}

	public VoicePlaybackReferenceCapture()
	{
		throw null;
	}

	static VoicePlaybackReferenceCapture()
	{
		throw null;
	}
}
