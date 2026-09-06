using TMPro;
using UnityEngine;

namespace KlassicHideNSeek;

public sealed class HnSThemeSettings : ScriptableObject
{
	public AudioClip IntroStinger;

	public Color SeekerRevealBackgroundColor;

	public AudioClip SeekerTransformMusic;

	public float SeekerTransformMusicDelay;

	public Color SeekerTransformBackgroundColor;

	public Color SeekerTitleColor;

	public RuntimeAnimatorController SeekerTransformAnimator;

	public AudioClip SeekerTransformSFX;

	public float SeekerMorphHatShowAfter;

	public float SeekerMorphHatScale;

	public Vector2 SeekerMorphHatOffset;

	public bool SeekerMorphHoldForTuning;

	public float SeekerTransformSfxDelay;

	public float IntroSeekerPreviewScale;

	public Vector2 IntroSeekerPreviewOffset;

	public float IntroSeekerPreviewSpacing;

	public float IntroTransformScale;

	public Vector2 IntroTransformOffset;

	public Vector2 SeekerHatOffset;

	public float SeekerHatBobScale;

	public float SeekerHatBobStrength;

	public float SeekerHatBobTiltDegrees;

	public bool SeekerHatBobInvert;

	public float SeekerHatBobUpScale;

	public float SeekerHatBobDownScale;

	public float SeekerHatBobPivot;

	public float SeekerHatIdleBobSpeed;

	public float SeekerHatIdleBobAmount;

	public bool SeekerHatIdleBobSyncToAnim;

	public float SeekerHatIdleNodAmplify;

	public AnimationClip SeekerWalkAnim;

	public AnimationClip SeekerRunAnim;

	public AnimationClip SeekerCountdownMorphAnim;

	public AnimationClip SeekerGroundMorphAnim;

	public float SeekerGroundMorphScale;

	public Vector2 SeekerGroundMorphOffset;

	public Texture SeekerGroundMorphSheet;

	public bool SeekerGroundMorphRepeat;

	public float SeekerGroundMorphHatScale;

	public float SeekerGroundMorphHatSwapAt;

	public Vector2 SeekerGroundMorphHatOffset;

	public Vector2 SeekerMorphHandOffset;

	public AudioClip MatchMusicNormal;

	public AudioClip MatchMusicTask;

	public AudioClip MatchMusicDanger1;

	public AudioClip MatchMusicDanger2;

	public AudioClip MatchMusicDanger3;

	public AudioClip MatchMusicSeekerLong;

	public AudioClip MatchMusicSeekerShort;

	public AudioClip MatchMusicSeekerOverride;

	public bool SeekerMusicLoop;

	public AudioClip FinalHideAlertSFX;

	public AudioClip FinalHideCountdownSFX;

	public AudioClip HuntStartSFX;

	public AudioClip TaskFinishedSFX;

	public AudioClip PingSFX;

	public AudioClip DeathNotificationSFX;

	public AudioClip[] KillStings;

	public AudioClip[] HiderKillStings;

	public string DeathPopupTemplate;

	public Sprite PingDotSprite;

	public Sprite KillBannerIcon;

	public Sprite BrokenEmergencyButtonSprite;

	public Sprite IntroCard01;

	public Sprite IntroCard02;

	public Sprite IntroCard03;

	public float TaskTimeDeductionShort;

	public float TaskTimeDeductionLong;

	public float FinalHuntRedFlashSpeed;

	public bool ShowSeekerProximityMeter;

	public string SeekerProximityLabel;

	public string LobbyBannerLabel;

	public string PositionRevealedLabel;

	public string TimeTextLabel;

	public bool TimeTextBold;

	public TextAlignmentOptions TextAlignment;

	public float CharacterSpacing;

	public float WordSpacing;

	public float LineSpacing;

	public float ParagraphSpacing;

	public string HiderRoleLabel;

	public string SeekerRoleLabel;

	public string EscapePhaseLabel;

	public string HuntPhaseLabel;

	public string FinalHuntPhaseLabel;

	public string EscapeHiderText;

	public string EscapeSeekerText;

	public string HuntSeekerText;

	public string HuntHiderText;

	public string FinalHuntSeekerText;

	public string FinalHuntHiderText;

	public bool ShowIntroOverlay;

	public string IntroRoleLabel;

	public string[] IntroCardTitles;

	public string[] IntroCardDescriptions;

	public HnSThemeSettings()
	{
		throw null;
	}
}
