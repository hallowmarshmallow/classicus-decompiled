using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameManager : DestroyableSingleton<EndGameManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<WinningPlayerData, int> _003C_003E9__42_0;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_1;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_2;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_3;

		public static Func<WinningPlayerData, string> _003C_003E9__42_4;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_5;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_6;

		public static Func<WinningPlayerData, bool> _003C_003E9__42_7;

		public static Func<WinningPlayerData, bool> _003C_003E9__46_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal int _003CSetEverythingUp_003Eb__42_0(WinningPlayerData b)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_1(WinningPlayerData h)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_2(WinningPlayerData w)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_3(WinningPlayerData w)
		{
			throw null;
		}

		internal string _003CSetEverythingUp_003Eb__42_4(WinningPlayerData w)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_5(WinningPlayerData w)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_6(WinningPlayerData h)
		{
			throw null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_7(WinningPlayerData h)
		{
			throw null;
		}

		internal bool _003CSetUpRunnerEndScreen_003Eb__46_0(WinningPlayerData w)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public EndGameManager _003C_003E4__this;

		public int delta;

		public _003C_003Ec__DisplayClass65_0()
		{
			throw null;
		}

		internal void _003CWireRunnerPageButton_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoBegin_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndGameManager _003C_003E4__this;

		private Color _003Cc_003E5__2;

		private Color _003Cfade_003E5__3;

		private Vector3 _003CtitlePos_003E5__4;

		private float _003Ctimer_003E5__5;

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

		public _003CCoBegin_003Ed__71(int _003C_003E1__state)
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

	private sealed class _003CCoHoldRunnerPlacementText_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndGameManager _003C_003E4__this;

		public string placeText;

		private float _003Ctimer_003E5__2;

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

		public _003CCoHoldRunnerPlacementText_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CCoJoinGame_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Ctimer_003E5__2;

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

		public _003CCoJoinGame_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003CWaitWithTimeout_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

		private float _003Ctimer_003E5__2;

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

		public _003CWaitWithTimeout_003Ed__76(int _003C_003E1__state)
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

	public TextMeshPro WinText;

	public TextMeshPro AltWinText;

	public MeshRenderer BackgroundBar;

	public MeshRenderer Foreground;

	public FloatRange ForegroundRadius;

	public SpriteRenderer FrontMost;

	public PoolablePlayer PlayerPrefab;

	public Sprite GhostSprite;

	public SpriteRenderer PlayAgainButton;

	public SpriteRenderer ExitButton;

	public AudioClip DisconnectStinger;

	public AudioClip CrewStinger;

	public AudioClip ImpostorStinger;

	public AudioClip GlitchStinger;

	public float BaseY;

	private float stingerTime;

	private bool isRunnerEnd;

	private bool continueClicked;

	private readonly Dictionary<TMP_Text, TMP_FontAsset> pristineFonts;

	private string fittedWinText;

	private string fittedAltWinText;

	private GameObject runnerNextButton;

	private AudioClip runnerEndMusic;

	private const int RunnerSlotsPerPage = 5;

	private static readonly string[] RunnerSlotNames;

	private readonly List<Transform> runnerSlots;

	private readonly List<Color> runnerSlotColors;

	private const float RunnerNavRowY = -1.5f;

	private const float RunnerNavRowZ = -1f;

	private const float RunnerNavButtonX = 2.55f;

	private const float RunnerNavButtonWidth = 2.8f;

	private const float RunnerNavButtonHeight = 0.62f;

	private TMP_Text runnerPagesText;

	private GameObject runnerPrevPageButton;

	private GameObject runnerNextPageButton;

	private int runnerPage;

	private int runnerPages;

	private int runnerLastPageStepFrame;

	private int runnerPressedPage;

	private const float RejoinTimeoutSeconds = 25f;

	public void Start()
	{
		throw null;
	}

	private void ShowButtons()
	{
		throw null;
	}

	private void StartGlitch(float intensity)
	{
		throw null;
	}

	private void SetEverythingUp()
	{
		throw null;
	}

	private static string RunnerPlaceText(StringNames key, string englishFallback, int place)
	{
		throw null;
	}

	private void FitLabelFont(TMP_Text label)
	{
		throw null;
	}

	private void FitWinLabels()
	{
		throw null;
	}

	private void SetUpRunnerEndScreen()
	{
		throw null;
	}

	private void SetUpRunnerNextButton()
	{
		throw null;
	}

	private IEnumerator CoHoldRunnerPlacementText(string placeText)
	{
		throw null;
	}

	private GameObject FindSceneNextButton()
	{
		throw null;
	}

	private GameObject FindSceneChild(string childName)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private int RunnerNavUnder(Vector2 wp)
	{
		throw null;
	}

	private static bool RunnerButtonHit(GameObject button, Vector2 wp)
	{
		throw null;
	}

	public void OnRunnerContinueClicked()
	{
		throw null;
	}

	private void ShowRunnerLeaderboard()
	{
		throw null;
	}

	private void RenderRunnerPage()
	{
		throw null;
	}

	public void StepRunnerPage(int delta)
	{
		throw null;
	}

	private static string CleanRunnerName(string stored)
	{
		throw null;
	}

	private Color RunnerMedalColor(int place)
	{
		throw null;
	}

	private void EnsureRunnerPageNav(Transform leaderboard)
	{
		throw null;
	}

	private static void ActivateRunnerNav(Transform t, Transform stopAt)
	{
		throw null;
	}

	private Transform BuildRunnerNavButton(Transform page, string name, string label, float x, Transform rowTemplate, Transform boxTemplate)
	{
		throw null;
	}

	private Transform BuildRunnerNavLabel(Transform parent, string name, string label, float x, Transform rowTemplate)
	{
		throw null;
	}

	private static void EnsureRunnerNavCollider(GameObject go)
	{
		throw null;
	}

	private void WireRunnerPageButton(Transform btn, int delta)
	{
		throw null;
	}

	private void SetRunnerNavUsable(GameObject btn, bool usable)
	{
		throw null;
	}

	private static Transform FindRunnerChild(Transform root, string name)
	{
		throw null;
	}

	private void StopRunnerEndMusic()
	{
		throw null;
	}

	public void SetWinnerPlayers(List<WinningPlayerData> list)
	{
		throw null;
	}

	private void GetStingerVol(AudioSource source, float dt)
	{
		throw null;
	}

	public IEnumerator CoBegin()
	{
		throw null;
	}

	public void NextGame()
	{
		throw null;
	}

	public IEnumerator CoJoinGame()
	{
		throw null;
	}

	public void Exit()
	{
		throw null;
	}

	public static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		throw null;
	}

	public EndGameManager()
	{
		throw null;
	}

	static EndGameManager()
	{
		throw null;
	}
}
