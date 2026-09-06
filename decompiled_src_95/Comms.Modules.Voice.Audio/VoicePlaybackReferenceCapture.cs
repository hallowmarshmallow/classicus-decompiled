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

	public static string Status => null;

	public static bool HasRecentReference => false;

	public static void EnsureInstalled()
	{
	}

	public static void Uninstall(string status)
	{
	}

	public static void EnsureUninstalled(string status)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}
}
