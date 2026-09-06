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
				return _003CLoaded_003Ek__BackingField;
			}
			private set
			{
				_003CLoaded_003Ek__BackingField = value;
			}
		}

		public SecureDataFile(string filePath)
		{
		}

		public void LoadData(Action<BinaryReader> performRead)
		{
		}

		public void SaveData(object[] items)
		{
		}

		public void Delete()
		{
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

		public string mouseMovement;

		public string customLobbyMusicEnabled;

		public string customLobbyMusicPath;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<BinaryReader> _003C_003E9__152_0;

		internal void _003CLoadSecureData_003Eb__152_0(BinaryReader reader)
		{
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

	private static bool mouseMovement;

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
			return default(Announcement);
		}
		set
		{
		}
	}

	public static bool BoughtNoAds => false;

	public static bool CensorChat
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CustomLobbyMusicEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string CustomLobbyMusicPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ShowAdsState ShowAdsScreen
	{
		get
		{
			return default(ShowAdsState);
		}
		set
		{
		}
	}

	public static bool ShowOnlineHelp
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static float SfxVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float MusicVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float VoiceVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static string CurrentMicrophoneDevice
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string SelectedRegion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string Keybinds
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool StreamerMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool MouseMovement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int TouchConfig
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static float JoystickSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float FPSCap => 0f;

	public static string PlayerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LastPet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LastHat
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LastSkin
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static uint LastLanguage
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static int CurrentGraphicsPreset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool IgnoreScreenCutoffs
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool VSyncEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int ResolutionWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int ResolutionHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool IsStaff
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool AnonymousMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool StaffMusicEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HideCountryEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static byte BodyColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static GameOptionsData GameHostOptions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GameOptionsData GameSearchOptions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool GetPurchase(string key)
	{
		return false;
	}

	public static void SetPurchased(string key)
	{
	}

	private static void LoadSecureData()
	{
	}

	private static void SaveSecureData()
	{
	}

	private static GameOptionsData LoadGameOptions(string filename)
	{
		return null;
	}

	private static void SaveGameOptions(GameOptionsData data, string filename)
	{
	}

	private static void LoadAnnouncement()
	{
	}

	public static void SaveAnnouncement()
	{
	}

	private static void MigrateLegacyCompanyData()
	{
	}

	private static void LoadPlayerPrefs()
	{
	}

	public static void SavePlayerPrefs()
	{
	}

	private static bool IsValidJson(string jsonString)
	{
		return false;
	}

	private static void TryGetDateTime(string[] parts, int index, out DateTime value)
	{
		value = default(DateTime);
	}

	private static void TryGetUint(string[] parts, int index, out uint value, uint @default = 0u)
	{
		value = default(uint);
	}
}
