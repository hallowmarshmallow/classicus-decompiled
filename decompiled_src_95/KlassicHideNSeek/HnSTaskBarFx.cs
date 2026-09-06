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
	}

	private void BuildTimerTags()
	{
	}

	private float ComputeLabelLift()
	{
		return 0f;
	}

	private static float CapHeight(TMP_FontAsset font, float size)
	{
		return 0f;
	}

	private void LateUpdate()
	{
	}

	private float GetTaskFraction()
	{
		return 0f;
	}

	private static float GetTimeFraction(HnSGameManager hns)
	{
		return 0f;
	}

	private void DriveBarColor(float timeFraction, bool finalPhase)
	{
	}

	private void DriveShake(float fraction, bool finalPhase)
	{
	}

	private void DriveTitle(float taskFraction, bool finalPhase, string timePrefix)
	{
	}

	private void DriveHidersIcon(bool finalPhase)
	{
	}

	private static void CountHiders(out int alive, out int total)
	{
		alive = default(int);
		total = default(int);
	}

	private void RestoreClassicVisuals()
	{
	}
}
