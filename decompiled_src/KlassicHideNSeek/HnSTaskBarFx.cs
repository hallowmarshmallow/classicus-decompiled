using TMPro;
using UnityEngine;

namespace KlassicHideNSeek;

public sealed class HnSTaskBarFx : MonoBehaviour
{
	private MeshRenderer tileParent;

	private TextMeshPro titleText;

	private SpriteRenderer hidersIcon;

	private TextMeshPro hidersText;

	private string totalLabel;

	private string gettingCloserLabel;

	private string almostDoneLabel;

	private string finalLabel;

	private float shakeStartFraction;

	private float maxShakeAmplitude;

	private float completedPopupSeconds;

	private TMP_FontAsset timerFont;

	private Material timerMaterial;

	private float timerFontSize;

	private bool timerBold;

	private float timerLabelNudge;

	private const string FullColorProperty = "_FullColor";

	private static readonly Color DrainFullColor;

	private static readonly Color DrainEmptyColor;

	private Material tileMaterial;

	private TextTranslatorTMP titleTranslator;

	private Color defaultFullColor;

	private bool defaultFullColorCaptured;

	private string timerOpenTag;

	private string timerCloseTag;

	private string labelOpenTag;

	private string labelCloseTag;

	private Vector3 restLocalPosition;

	private bool shaking;

	private bool loggedIdleGate;

	private int initialHiderCount;

	private int lastCompletedTasks;

	private float popupUntil;

	private void Awake()
	{
		throw null;
	}

	private void BuildTimerTags()
	{
		throw null;
	}

	private float ComputeLabelLift()
	{
		throw null;
	}

	private static float CapHeight(TMP_FontAsset font, float size)
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private float GetTaskFraction()
	{
		throw null;
	}

	private static float GetTimeFraction(HnSGameManager hns)
	{
		throw null;
	}

	private void DriveBarColor(float timeFraction, bool finalPhase)
	{
		throw null;
	}

	private void DriveShake(float fraction, bool finalPhase)
	{
		throw null;
	}

	private void DriveTitle(float taskFraction, bool finalPhase, string timePrefix)
	{
		throw null;
	}

	private void DriveHidersIcon(bool finalPhase)
	{
		throw null;
	}

	private static void CountHiders(out int alive, out int total)
	{
		throw null;
	}

	private void RestoreClassicVisuals()
	{
		throw null;
	}

	public HnSTaskBarFx()
	{
		throw null;
	}

	static HnSTaskBarFx()
	{
		throw null;
	}
}
