using UnityEngine;

public class OptionsMenuBehaviour : MonoBehaviour, ITranslatedText
{
	public SpriteRenderer Background;

	public SlideBar JoystickSizeSlider;

	public SlideBar MusicSlider;

	public SlideBar SfxSlider;

	public SlideBar VoiceSlider;

	public SlideBar PetSlider;

	public FloatRange JoystickSizes;

	public ToggleButtonBehaviour CensorChatButton;

	public ToggleButtonBehaviour CurrentMicButton;

	public bool Toggle;

	public TabGroup[] Tabs;

	public GameObject CantChangeInGame;

	public static OptionsMenuBehaviour Instance;

	private string[] microphoneDevices;

	private bool requestedOptionsMicrophonePermission;

	private bool waitingForOptionsMicrophonePermission;

	private const int MenuSortingOrder = 500;

	public bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	public static OptionsMenuBehaviour Get(Transform parent)
	{
		throw null;
	}

	public void OpenTabGroup(TabGroup selected)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void ApplyTopmostSorting()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	public void ResetText()
	{
		throw null;
	}

	public void Open()
	{
		throw null;
	}

	public void SetControlType(int i)
	{
		throw null;
	}

	public void UpdateJoystickSize(SlideBar slider)
	{
		throw null;
	}

	public void UpdateSfxVolume(SlideBar button)
	{
		throw null;
	}

	public void UpdateMusicVolume(SlideBar button)
	{
		throw null;
	}

	public void UpdateVoiceVolume(SlideBar button)
	{
		throw null;
	}

	public void UpdatePetVolume(SlideBar button)
	{
		throw null;
	}

	public void TogglePersonalizedAd()
	{
		throw null;
	}

	public void ToggleCensorChat()
	{
		throw null;
	}

	public void ToggleCurrentMic()
	{
		throw null;
	}

	public void UpdateButtons()
	{
		throw null;
	}

	private void RefreshMicrophoneDevices(bool requestPermission)
	{
		throw null;
	}

	private bool EnsureMicrophonePermissionForOptions(bool requestPermission)
	{
		throw null;
	}

	private bool CanReadMicrophoneDevices()
	{
		throw null;
	}

	private static bool HasAndroidMicrophonePermission()
	{
		throw null;
	}

	private static string[] ReadMicrophoneDevices()
	{
		throw null;
	}

	private int FindMicrophoneIndex(string deviceName)
	{
		throw null;
	}

	private void UpdateCurrentMicButtonText()
	{
		throw null;
	}

	private static string GetMicDeviceLabel()
	{
		throw null;
	}

	private string GetCurrentMicrophoneButtonValue()
	{
		throw null;
	}

	private static string MicString(StringNames id, string fallback)
	{
		throw null;
	}

	private static string GetMicrophoneDisplayName(string deviceName)
	{
		throw null;
	}

	private static string CompactMicrophoneName(string value)
	{
		throw null;
	}

	public void Close()
	{
		throw null;
	}

	public OptionsMenuBehaviour()
	{
		throw null;
	}
}
