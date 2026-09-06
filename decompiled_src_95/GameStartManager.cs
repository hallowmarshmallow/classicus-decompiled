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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClientFadeOutLobbyMusic_003Ed__73(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoStartGameWatchdog_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameStartManager _003C_003E4__this;

		private float _003CretryTimer_003E5__2;

		private float _003CtimeoutTimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartGameWatchdog_003Ed__78(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
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

	private int EffectiveMinPlayers => 0;

	public static string RealGameCode
	{
		get
		{
			return _003CRealGameCode_003Ek__BackingField;
		}
		private set
		{
			_003CRealGameCode_003Ek__BackingField = value;
		}
	}

	public bool IsCountingDown => false;

	public void ApplyStreamerMode()
	{
	}

	public static void RefreshStreamerMode()
	{
	}

	public override void Awake()
	{
	}

	public void Start()
	{
	}

	private Sprite GetPublicSprite(int languageIndex)
	{
		return null;
	}

	private Sprite GetPrivateSprite(int languageIndex)
	{
		return null;
	}

	private int GetCurrentLanguageIndex()
	{
		return 0;
	}

	public void MakePublic()
	{
	}

	public void Update()
	{
	}

	private bool AllClientsReady()
	{
		return false;
	}

	private string DescribeUnreadyClients()
	{
		return null;
	}

	public void ResetStartState()
	{
	}

	public void SetStartCounter(sbyte sec)
	{
	}

	private IEnumerator ClientFadeOutLobbyMusic()
	{
		return null;
	}

	public void BeginGame()
	{
	}

	public void ReallyBegin()
	{
	}

	private void ClampImpostorCount()
	{
	}

	public void FinallyBegin()
	{
	}

	private IEnumerator CoStartGameWatchdog()
	{
		return null;
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}
}
