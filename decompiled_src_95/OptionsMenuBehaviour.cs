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

	public bool IsOpen => false;

	public static OptionsMenuBehaviour Get(Transform parent)
	{
		return null;
	}

	public void OpenTabGroup(TabGroup selected)
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}

	private void ApplyTopmostSorting()
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void ResetText()
	{
	}

	public void Open()
	{
	}

	public void SetControlType(int i)
	{
	}

	public void UpdateJoystickSize(SlideBar slider)
	{
	}

	public void UpdateSfxVolume(SlideBar button)
	{
	}

	public void UpdateMusicVolume(SlideBar button)
	{
	}

	public void UpdateVoiceVolume(SlideBar button)
	{
	}

	public void UpdatePetVolume(SlideBar button)
	{
	}

	public void TogglePersonalizedAd()
	{
	}

	public void ToggleCensorChat()
	{
	}

	public void ToggleCurrentMic()
	{
	}

	public void UpdateButtons()
	{
	}

	private void RefreshMicrophoneDevices(bool requestPermission)
	{
	}

	private bool EnsureMicrophonePermissionForOptions(bool requestPermission)
	{
		return false;
	}

	private bool CanReadMicrophoneDevices()
	{
		return false;
	}

	private static bool HasAndroidMicrophonePermission()
	{
		return false;
	}

	private static string[] ReadMicrophoneDevices()
	{
		return null;
	}

	private int FindMicrophoneIndex(string deviceName)
	{
		return 0;
	}

	private void UpdateCurrentMicButtonText()
	{
	}

	private static string GetMicDeviceLabel()
	{
		return null;
	}

	private string GetCurrentMicrophoneButtonValue()
	{
		return null;
	}

	private static string MicString(StringNames id, string fallback)
	{
		return null;
	}

	private static string GetMicrophoneDisplayName(string deviceName)
	{
		return null;
	}

	private static string CompactMicrophoneName(string value)
	{
		return null;
	}

	private Transform FindDeep(string name)
	{
		return null;
	}

	private void SetupControls()
	{
	}

	private void RefreshControls()
	{
	}

	public void Close()
	{
	}
}
