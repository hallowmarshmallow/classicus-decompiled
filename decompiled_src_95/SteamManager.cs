using System.Text;
using Steamworks;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
	private static SteamManager s_instance;

	private static bool s_EverInitialized;

	private bool m_bInitialized;

	private SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	private static SteamManager Instance => null;

	public static bool Initialized => false;

	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void DoShutdown()
	{
	}

	private void Update()
	{
	}
}
