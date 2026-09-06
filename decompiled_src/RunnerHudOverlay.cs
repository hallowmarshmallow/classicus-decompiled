using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public sealed class RunnerHudOverlay : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Transform> _003C_003E9__80_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal int _003CBuildShieldIcons_003Eb__80_0(Transform a, Transform b)
		{
			throw null;
		}
	}

	private sealed class _003CCoCrossfadeToUltimate_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerHudOverlay _003C_003E4__this;

		public AudioClip clip;

		private AudioSource _003Coutgoing_003E5__2;

		private float _003CoutgoingStart_003E5__3;

		private AudioSource _003Cincoming_003E5__4;

		private float _003Ctarget_003E5__5;

		private float _003Ct_003E5__6;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoCrossfadeToUltimate_003Ed__112(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCountdownRoutine_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerHudOverlay _003C_003E4__this;

		private float _003Celapsed_003E5__2;

		private int _003Cn_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCountdownRoutine_003Ed__91(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private TextMeshPro countdownText;

	private int countFrom;

	private float runHoldSeconds;

	private float shakeMagnitude;

	private AudioClip lobbyTimerClip;

	private AudioClip runClip;

	private float ultimateBpm;

	private float ultimateFirstBeat;

	private float ultimateZoomPulse;

	private float ultimateZoomRelax;

	private int ultimateBeatsPerPulse;

	private TextMeshPro timerText;

	private TextMeshPro difficultyText;

	private TextMeshPro speedWearingOffText;

	private Transform shieldRoot;

	private static bool _003CMovementFrozen_003Ek__BackingField;

	private static bool _003CRunActive_003Ek__BackingField;

	private static float _003CRunStartTime_003Ek__BackingField;

	public const float UltimateAtSeconds = 300f;

	private static readonly string[] TierNames;

	private static readonly StringNames[] TierStrings;

	private static readonly float[] TierShake;

	private static readonly Color MediumYellow;

	private static readonly Color HardOrange;

	private static readonly Color InsaneRed;

	private static readonly Color UltimateRed;

	private static readonly Color UltimateWhite;

	private static RunnerHudOverlay _003CInstance_003Ek__BackingField;

	private Coroutine _routine;

	private AudioSource _runSource;

	private AudioClip _activeRunClip;

	private static int _runMusicTurn;

	private static AudioClip _bangBangClip;

	private static AudioClip _theShowClip;

	private static AudioClip _instrumentalClip;

	private static AudioClip _jumperClip;

	private static bool _extraClipsLoaded;

	private static RunnerMusicPlaylist _playlist;

	private static bool _playlistLoaded;

	private const int RussianLanguageIndex = 10;

	private static bool _rotationWasRussian;

	private static bool _rotationLangKnown;

	private Vector3 _countdownBaseLocalPos;

	private bool _hasBasePos;

	private bool _counting;

	private Vector3 _difficultyBasePos;

	private Color _difficultyBaseColor;

	private TMP_FontAsset _difficultyBaseFont;

	private TMP_FontAsset _countdownBaseFont;

	private float _extremeBlend;

	private readonly StringBuilder _timerSb;

	private int _lastAppliedTier;

	private TMP_FontAsset _speedBaseFont;

	private int _lastSpeedSeconds;

	private static readonly Color SpeedFadeStart;

	private static readonly Color SpeedFadeEnd;

	private readonly List<Transform> _shieldPips;

	private const float UltimateFadeSeconds = 0.5f;

	private static readonly float[] UltimateVocalSpans;

	private AudioSource _ultimateSource;

	private AudioClip _ultimateClip;

	private bool _ultimateStarted;

	private bool _redOverlayOn;

	private int _lastPulseIndex;

	private float _zoomOffset;

	private float _hue;

	private float _hueRate;

	private Camera _beatCamera;

	private bool _projectionOverridden;

	public static bool MovementFrozen
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

	public static bool RunActive
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

	public static float RunStartTime
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

	public static float RunElapsed
	{
		get
		{
			throw null;
		}
	}

	public static int CurrentTier
	{
		get
		{
			throw null;
		}
	}

	public static bool UltimateActive
	{
		get
		{
			throw null;
		}
	}

	internal static RunnerHudOverlay Instance
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

	public static bool SkipTo(float seconds)
	{
		throw null;
	}

	private static string DifficultyLabel(int tier)
	{
		throw null;
	}

	private static string Loc(StringNames id, string fallback, object[] parts)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void BuildShieldIcons()
	{
		throw null;
	}

	private void UpdateShieldHud()
	{
		throw null;
	}

	private void UpdateSpeedHud()
	{
		throw null;
	}

	private static bool SurvivalHudShouldShow()
	{
		throw null;
	}

	private void BeginSurvivalHud()
	{
		throw null;
	}

	private void EndSurvivalHud()
	{
		throw null;
	}

	private void UpdateSurvivalHud()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public static void BeginRunnerCountdown()
	{
		throw null;
	}

	public static void CancelRunnerCountdown()
	{
		throw null;
	}

	private void StartCountdown()
	{
		throw null;
	}

	private IEnumerator CountdownRoutine()
	{
		throw null;
	}

	private void PlayOneShot(AudioClip clip)
	{
		throw null;
	}

	private static bool IsRussianLanguage()
	{
		throw null;
	}

	private static AudioClip RotationClip(int index, bool russian)
	{
		throw null;
	}

	private AudioClip NextRunClip()
	{
		throw null;
	}

	private void StartRunLoop()
	{
		throw null;
	}

	private void StopRunLoop()
	{
		throw null;
	}

	private void EnterUltimate()
	{
		throw null;
	}

	private static AudioClip UltimateClip()
	{
		throw null;
	}

	private IEnumerator CoCrossfadeToUltimate(AudioClip clip)
	{
		throw null;
	}

	private void UpdateUltimateOverlay(bool on)
	{
		throw null;
	}

	private void UpdateUltimateBeat()
	{
		throw null;
	}

	private void RestoreUltimateBeat()
	{
		throw null;
	}

	private static bool VocalsActive(float clipTime)
	{
		throw null;
	}

	private void ClearUltimate()
	{
		throw null;
	}

	public RunnerHudOverlay()
	{
		throw null;
	}

	static RunnerHudOverlay()
	{
		throw null;
	}
}
