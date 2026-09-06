using TMPro;
using UnityEngine;

public class ClockPitchToggle : MonoBehaviour
{
	public TMP_Text buttonText;

	public string English_On;

	public string Portuguese_On;

	public string SpanishSpain_On;

	public string SpanishMexico_On;

	public string SpanishArgentina_On;

	public string German_On;

	public string Dutch_On;

	public string Swedish_On;

	public string Italian_On;

	public string Polish_On;

	public string Russian_On;

	public string Turkish_On;

	public string Vietnamese_On;

	public string French_On;

	public string Korean_On;

	public string Japanese_On;

	public string Arabic_On;

	public string English_Off;

	public string Portuguese_Off;

	public string SpanishSpain_Off;

	public string SpanishMexico_Off;

	public string SpanishArgentina_Off;

	public string German_Off;

	public string Dutch_Off;

	public string Swedish_Off;

	public string Italian_Off;

	public string Polish_Off;

	public string Russian_Off;

	public string Turkish_Off;

	public string Vietnamese_Off;

	public string French_Off;

	public string Korean_Off;

	public string Japanese_Off;

	public string Arabic_Off;

	public const string PREF_KEY = "MyMod_ClockPitchEnabled";

	public const int PREF_DEFAULT = 0;

	private const string LobbyNameFragment = "Lobby";

	private const string LobbyThemeChild = "LobbyTheme";

	private const float LobbyCheckInterval = 1f;

	private PassiveButton _passiveButton;

	private float _lobbyCheckTimer;

	private TimeClockController _clockController;

	private LobbyMusicPlayer _lobbyAudio;

	private bool _stateAppliedThisSession;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CheckLobbyPresenceAndUpdate()
	{
	}

	private static GameObject FindLobbyRoot()
	{
		return null;
	}

	private static TimeClockController FindTimeClockController()
	{
		return null;
	}

	private void TryBindAudio(GameObject lobbyRoot)
	{
	}

	private void Toggle()
	{
	}

	private void ApplySavedState()
	{
	}

	private void ApplyState(bool enabled)
	{
	}

	private void UpdateButtonText()
	{
	}

	private string GetOnText(int index)
	{
		return null;
	}

	private string GetOffText(int index)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
