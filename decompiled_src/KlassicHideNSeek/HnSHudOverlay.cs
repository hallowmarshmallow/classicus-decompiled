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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public void HideAll()
	{
		throw null;
	}

	public void SetLobbyBanner(bool show, string text)
	{
		throw null;
	}

	public void SetSeekerCountdown(bool show, int seconds)
	{
		throw null;
	}

	public void SetUseTimer(bool show, float seconds, float maxSeconds = 0f)
	{
		throw null;
	}

	public void SetVentTimer(bool show, float seconds, float maxSeconds = 0f)
	{
		throw null;
	}

	private TMP_Text VentButtonTimer()
	{
		throw null;
	}

	private static void Paint(TMP_Text label, bool show, float seconds, float maxSeconds)
	{
		throw null;
	}

	public void SetRevealNotify(bool show, float alpha, string text)
	{
		throw null;
	}

	public void SetProximity(bool show, int bars, string label)
	{
		throw null;
	}

	public void SetFlash(float alpha)
	{
		throw null;
	}

	public void SetDeathPopups(IList<string> lines, IList<float> scales)
	{
		throw null;
	}

	public void SetAdminDots(IList<Vector2> screenPts, IList<Color> colors)
	{
		throw null;
	}

	private void EnsureDeathPool(int needed)
	{
		throw null;
	}

	private void EnsureDotPool(int needed)
	{
		throw null;
	}

	public HnSHudOverlay()
	{
		throw null;
	}
}
