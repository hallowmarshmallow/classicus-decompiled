using UnityEngine;

public class DestroyableSkeldMeetingButton : MonoBehaviour
{
	private const string DESTROYABLE_SKELD_NAME = "DestroyableSkeldStatus";

	private const float CHECK_INTERVAL = 0.25f;

	public GameObject meetingButtonObject;

	public Minigame emergencyMinigamePrefab;

	private float checkTimer;

	private bool lastVisibleState;

	private bool hudActive;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void EvaluateVisibility()
	{
	}

	private bool ShouldButtonBeVisible()
	{
		return false;
	}

	public void SetHudActive(bool isActive)
	{
	}

	public void OpenEmergencyMinigame()
	{
	}
}
