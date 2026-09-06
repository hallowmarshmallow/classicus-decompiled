using TMPro;
using UnityEngine;

public class LobbyCloseCountdown : MonoBehaviour
{
	public GameObject warningObject;

	public TMP_Text countdownLabel;

	public float appearAfterMinutes;

	public int countdownSeconds;

	private float startTime;

	private bool shown;

	private bool finished;

	private float countdownEndTime;

	private string originalLabelText;

	private bool lobbyWasPresent;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void ForceStartCountdown(int remainingSeconds)
	{
	}

	public void StaffTriggerClose()
	{
	}

	private void SetLabel(int seconds)
	{
	}

	private void SetVisualsActive(bool state)
	{
	}
}
