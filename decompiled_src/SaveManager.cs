using System;
using System.Collections.Generic;
using System.IO;

public static class SaveManager
{
	private class SecureDataFile
	{
		private string filePath;

		private bool _003CLoaded_003Ek__BackingField;

		public bool Loaded
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

		public SecureDataFile(string filePath)
		{
			throw null;
		}

		public void LoadData(Action<BinaryReader> performRead)
		{
			throw null;
		}

		public void SaveData(object[] items)
		{
			throw null;
		}

		public void Delete()
		{
			throw null;
		}
	}

	[Serializable]
	public class PlayerPrefsData
	{
		public string lastPlayerName;

		public string touchConfig;

		public string colorConfig;

		public string showAdsScreen;

		public string showMinPlayerWarning;

		public string showOnlineHelp;

		public string lastHat;

		public string sfxVolume;

		public string musicVolume;

		public string voiceVolume;

		public string joyStickSize;

		public string lastSkin;

		public string lastPet;

		public string censorChat;

		public string lastLanguage;

		public string FPSCount;

		public string currentGraphicsPreset;

		public string ignoreScreenCutoffs;

		public string vSyncEnabled;

		public string resolutionWidth;

		public string resolutionHeight;

		public string isStaff;

		public string anonymousMode;

		public string staffMusicEnabled;

		public string hideCountryEnabled;

		public string currentMicrophoneDevice;

		public string selectedRegion;

		public string keybinds;

		public string streamerMode;

		public string customLobbyMusicEnabled;

		public string customLobbyMusicPath;

		public PlayerPrefsData()
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<BinaryReader> _003C_003E9__148_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CLoadSecureData_003Eb__148_0(BinaryReader reader)
		{
			throw null;
		}
	}

	private static bool loaded;

	private static bool loadedAnnounce;

	private static string lastPlayerName;

	private static byte sfxVolume;

	private static byte musicVolume;

	private static byte voiceVolume;

	private static bool showMinPlayerWarning;

	private static bool showOnlineHelp;

	private static byte showAdsScreen;

	private static bool censorChat;

	private static bool customLobbyMusicEnabled;

	private static string customLobbyMusicPath;

	private static int touchConfig;

	public static float joyStickSize;

	public static float FPSCount;

	public static int currentGraphicsPreset;

	public static bool ignoreScreenCutoffs;

	private static bool vSyncEnabled;

	private static int resolutionWidth;

	private static int resolutionHeight;

	private static bool isStaff;

	private static bool anonymousMode;

	private static bool staffMusicEnabled;

	private static bool hideCountryEnabled;

	private static string currentMicrophoneDevice;

	private static string selectedRegion;

	private static string keybinds;

	private static bool streamerMode;

	private static byte colorConfig;

	private static string lastPet;

	private static string lastHat;

	private static string lastSkin;

	private static uint lastLanguage;

	private static GameOptionsData hostOptionsData;

	private static GameOptionsData searchOptionsData;

	public static Announcement lastAnnounce;

	private static SecureDataFile purchaseFile;

	private static HashSet<string> purchases;

	public static FreeWeekendState IsFreeWeekend;

	private static readonly string FilePath;

	public static Announcement LastAnnouncement
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool BoughtNoAds
	{
		get
		{
			throw null;
		}
	}

	public static bool CensorChat
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool CustomLobbyMusicEnabled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string CustomLobbyMusicPath
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static ShowAdsState ShowAdsScreen
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool ShowOnlineHelp
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static float SfxVolume
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static float MusicVolume
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static float VoiceVolume
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string CurrentMicrophoneDevice
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string SelectedRegion
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string Keybinds
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool StreamerMode
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static int TouchConfig
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static float JoystickSize
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static float FPSCap
	{
		get
		{
			throw null;
		}
	}

	public static string PlayerName
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string LastPet
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string LastHat
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static string LastSkin
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static uint LastLanguage
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static int CurrentGraphicsPreset
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool IgnoreScreenCutoffs
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool VSyncEnabled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static int ResolutionWidth
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static int ResolutionHeight
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool IsStaff
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool AnonymousMode
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool StaffMusicEnabled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool HideCountryEnabled
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static byte BodyColor
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static GameOptionsData GameHostOptions
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static GameOptionsData GameSearchOptions
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static bool GetPurchase(string key)
	{
		throw null;
	}

	public static void SetPurchased(string key)
	{
		throw null;
	}

	private static void LoadSecureData()
	{
		throw null;
	}

	private static void SaveSecureData()
	{
		throw null;
	}

	private static GameOptionsData LoadGameOptions(string filename)
	{
		throw null;
	}

	private static void SaveGameOptions(GameOptionsData data, string filename)
	{
		throw null;
	}

	private static void LoadAnnouncement()
	{
		throw null;
	}

	public static void SaveAnnouncement()
	{
		throw null;
	}

	private static void MigrateLegacyCompanyData()
	{
		throw null;
	}

	private static void LoadPlayerPrefs()
	{
		throw null;
	}

	public static void SavePlayerPrefs()
	{
		throw null;
	}

	private static bool IsValidJson(string jsonString)
	{
		throw null;
	}

	private static void TryGetDateTime(string[] parts, int index, out DateTime value)
	{
		throw null;
	}

	private static void TryGetUint(string[] parts, int index, out uint value, uint @default = 0u)
	{
		throw null;
	}

	static SaveManager()
	{
		throw null;
	}
}
