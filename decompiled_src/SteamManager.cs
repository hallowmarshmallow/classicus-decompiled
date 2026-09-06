using System.Text;
using Steamworks;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
	private static SteamManager s_instance;

	private static bool s_EverInitialized;

	private bool m_bInitialized;

	private SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	private static SteamManager Instance
	{
		get
		{
			throw null;
		}
	}

	public static bool Initialized
	{
		get
		{
			throw null;
		}
	}

	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void DoShutdown()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public SteamManager()
	{
		throw null;
	}
}
