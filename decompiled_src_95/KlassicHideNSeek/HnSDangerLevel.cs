using System.Collections.Generic;

namespace KlassicHideNSeek;

internal sealed class HnSDangerLevel
{
	private float scaryDist;

	private float veryScaryDist;

	private float dangerLevel1;

	private float dangerLevel2;

	private bool firstActivation;

	private float firstCrossfadeCountdown;

	private List<PlayerControl> impostors;

	private HnSMusicManager musicManager;

	internal HnSDangerLevel(HnSMusicManager music)
	{
	}

	internal void OnGameStart(float playerSpeedBase)
	{
	}

	internal void OnGameEnd()
	{
	}

	internal void FixedUpdate(bool isEscapePhase)
	{
	}

	private void UpdateMeterVisual()
	{
	}
}
