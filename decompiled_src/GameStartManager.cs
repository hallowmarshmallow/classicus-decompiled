using System;
using System.Collections;
using System.Collections.Generic;
using InnerNet;
using TMPro;
using UnityEngine;

public class GameStartManager : DestroyableSingleton<GameStartManager>, IDisconnectHandler
{
	private enum StartingStates
	{
		NotStarting,
		Countdown,
		Starting
	}

	private sealed class _003CClientFadeOutLobbyMusic_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private AudioSource _003ClobbyAudio_003E5__2;

		private float _003CstartVolume_003E5__3;

		private float _003Celapsed_003E5__4;

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

		public _003CClientFadeOutLobbyMusic_003Ed__73(int _003C_003E1__state)
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

	private sealed class _003CCoStartGameWatchdog_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameStartManager _003C_003E4__this;

		private float _003CretryTimer_003E5__2;

		private float _003CtimeoutTimer_003E5__3;

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

		public _003CCoStartGameWatchdog_003Ed__78(int _003C_003E1__state)
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

	private static readonly string[] RunnerDisabledMapNames;

	public int MinPlayers;

	private int _classicMinPlayers;

	private static string _003CRealGameCode_003Ek__BackingField;

	private int _lastEffectiveMinPlayers;

	public TextMeshPro amogus;

	public TextRenderer PlayerCounter;

	public int LastPlayerCount;

	public TextMeshPro GameRoomName;

	public LobbyBehaviour LobbyPrefab;

	public TextRenderer GameStartText;

	public SpriteRenderer StartButton;

	public SpriteRenderer MakePublicButton;

	public Sprite PublicGameImage;

	public Sprite PrivateGameImage;

	public Sprite PublicEnglish;

	public Sprite PublicPortuguese;

	public Sprite PublicSpanishSpain;

	public Sprite PublicSpanishMexico;

	public Sprite PublicSpanishArgentina;

	public Sprite PublicGerman;

	public Sprite PublicDutch;

	public Sprite PublicSwedish;

	public Sprite PublicItalian;

	public Sprite PublicPolish;

	public Sprite PublicRussian;

	public Sprite PublicTurkish;

	public Sprite PublicVietnamese;

	public Sprite PublicFrench;

	public Sprite PublicKorean;

	public Sprite PublicJapanese;

	public Sprite PrivateEnglish;

	public Sprite PrivatePortuguese;

	public Sprite PrivateSpanishSpain;

	public Sprite PrivateSpanishMexico;

	public Sprite PrivateSpanishArgentina;

	public Sprite PrivateGerman;

	public Sprite PrivateDutch;

	public Sprite PrivateSwedish;

	public Sprite PrivateItalian;

	public Sprite PrivatePolish;

	public Sprite PrivateRussian;

	public Sprite PrivateTurkish;

	public Sprite PrivateVietnamese;

	public Sprite PrivateFrench;

	public Sprite PrivateKorean;

	public Sprite PrivateJapanese;

	private StartingStates startState;

	private float countDownTimer;

	private Coroutine startWatchdog;

	private float startHoldTimer;

	private bool clientFadeStarted;

	private int EffectiveMinPlayers
	{
		get
		{
			throw null;
		}
	}

	public static string RealGameCode
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

	public bool IsCountingDown
	{
		get
		{
			throw null;
		}
	}

	public void ApplyStreamerMode()
	{
		throw null;
	}

	public static void RefreshStreamerMode()
	{
		throw null;
	}

	public override void Awake()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	private Sprite GetPublicSprite(int languageIndex)
	{
		throw null;
	}

	private Sprite GetPrivateSprite(int languageIndex)
	{
		throw null;
	}

	private int GetCurrentLanguageIndex()
	{
		throw null;
	}

	public void MakePublic()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private bool AllClientsReady()
	{
		throw null;
	}

	private string DescribeUnreadyClients()
	{
		throw null;
	}

	public void ResetStartState()
	{
		throw null;
	}

	public void SetStartCounter(sbyte sec)
	{
		throw null;
	}

	private IEnumerator ClientFadeOutLobbyMusic()
	{
		throw null;
	}

	public void BeginGame()
	{
		throw null;
	}

	public void ReallyBegin()
	{
		throw null;
	}

	private void ClampImpostorCount()
	{
		throw null;
	}

	public void FinallyBegin()
	{
		throw null;
	}

	private IEnumerator CoStartGameWatchdog()
	{
		throw null;
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
		throw null;
	}

	public void HandleDisconnect()
	{
		throw null;
	}

	public GameStartManager()
	{
		throw null;
	}

	static GameStartManager()
	{
		throw null;
	}
}
