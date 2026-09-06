using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeClockController : MonoBehaviour
{
	private enum TimePeriod
	{
		Morning,
		Evening,
		Night
	}

	private sealed class _003CUpdateLoop_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeClockController _003C_003E4__this;

		private float _003CpitchTimer_003E5__2;

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

		public _003CUpdateLoop_003Ed__68(int _003C_003E1__state)
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

	private const string LobbyObjectNameFragment = "Lobby";

	private const string LobbyThemeChildName = "LobbyTheme";

	public GameObject timeClockRoot;

	public TextMeshPro periodLabel;

	public SpriteRenderer periodIcon;

	public Sprite morningSprite;

	public Sprite eveningSprite;

	public Sprite nightSprite;

	public string MorningEnglish;

	public string MorningPortuguese;

	public string MorningSpanishSpain;

	public string MorningSpanishMexico;

	public string MorningSpanishArgentina;

	public string MorningGerman;

	public string MorningDutch;

	public string MorningSwedish;

	public string MorningItalian;

	public string MorningPolish;

	public string MorningRussian;

	public string MorningTurkish;

	public string MorningVietnamese;

	public string MorningFrench;

	public string MorningKorean;

	public string MorningJapanese;

	public string MorningArabic;

	public string EveningEnglish;

	public string EveningPortuguese;

	public string EveningSpanishSpain;

	public string EveningSpanishMexico;

	public string EveningSpanishArgentina;

	public string EveningGerman;

	public string EveningDutch;

	public string EveningSwedish;

	public string EveningItalian;

	public string EveningPolish;

	public string EveningRussian;

	public string EveningTurkish;

	public string EveningVietnamese;

	public string EveningFrench;

	public string EveningKorean;

	public string EveningJapanese;

	public string EveningArabic;

	public string NightEnglish;

	public string NightPortuguese;

	public string NightSpanishSpain;

	public string NightSpanishMexico;

	public string NightSpanishArgentina;

	public string NightGerman;

	public string NightDutch;

	public string NightSwedish;

	public string NightItalian;

	public string NightPolish;

	public string NightRussian;

	public string NightTurkish;

	public string NightVietnamese;

	public string NightFrench;

	public string NightKorean;

	public string NightJapanese;

	public string NightArabic;

	private LobbyMusicPlayer musicPlayer;

	private Coroutine updateCoroutine;

	private bool _started;

	private const float LobbyCheckInterval = 1f;

	private const float PitchRefreshInterval = 30f;

	private void Start()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private IEnumerator UpdateLoop()
	{
		throw null;
	}

	private void SetVisible(bool visible)
	{
		throw null;
	}

	private static GameObject FindLobbyRoot()
	{
		throw null;
	}

	private void TryBindMusicPlayer(GameObject lobbyRoot)
	{
		throw null;
	}

	private void ApplyCurrentTime()
	{
		throw null;
	}

	private static TimePeriod GetPeriod(int hour)
	{
		throw null;
	}

	private static float PitchForHour(int hour, TimePeriod period)
	{
		throw null;
	}

	private void UpdateLabel(TimePeriod period)
	{
		throw null;
	}

	private string GetLocalizedLabel(TimePeriod period)
	{
		throw null;
	}

	private static string Pick(string value, string fallback)
	{
		throw null;
	}

	private void UpdateIcon(TimePeriod period)
	{
		throw null;
	}

	private void ApplyPitch(float pitch)
	{
		throw null;
	}

	public TimeClockController()
	{
		throw null;
	}
}
