using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace KlassicHideNSeek;

public sealed class HnSHudOverlay : MonoBehaviour
{
	private TextMeshPro lobbyBanner;

	private TextMeshPro seekerCountdown;

	private TextMeshPro ventTimer;

	private TextMeshPro revealNotify;

	private GameObject proximityRoot;

	private SpriteRenderer[] proximityBars;

	private TextMeshPro proximityLabel;

	private Color proximityEmptyColor;

	private SpriteRenderer fullScreenFlash;

	private TextMeshPro deathPopupTemplate;

	private SpriteRenderer adminDotTemplate;

	private Camera uiCamera;

	private readonly List<TextMeshPro> deathPool;

	private readonly List<SpriteRenderer> dotPool;

	private static HnSHudOverlay _003CInstance_003Ek__BackingField;

	private TMP_Text ventButtonTimer;

	private bool ventButtonTimerResolved;

	internal static HnSHudOverlay Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void HideAll()
	{
	}

	public void SetLobbyBanner(bool show, string text)
	{
	}

	public void SetSeekerCountdown(bool show, int seconds)
	{
	}

	public void SetUseTimer(bool show, float seconds, float maxSeconds = 0f)
	{
	}

	public void SetVentTimer(bool show, float seconds, float maxSeconds = 0f)
	{
	}

	private TMP_Text VentButtonTimer()
	{
		return null;
	}

	private static void Paint(TMP_Text label, bool show, float seconds, float maxSeconds)
	{
	}

	public void SetRevealNotify(bool show, float alpha, string text)
	{
	}

	public void SetProximity(bool show, int bars, string label)
	{
	}

	public void SetFlash(float alpha)
	{
	}

	public void SetDeathPopups(IList<string> lines, IList<float> scales)
	{
	}

	public void SetAdminDots(IList<Vector2> screenPts, IList<Color> colors)
	{
	}

	private void EnsureDeathPool(int needed)
	{
	}

	private void EnsureDotPool(int needed)
	{
	}
}
