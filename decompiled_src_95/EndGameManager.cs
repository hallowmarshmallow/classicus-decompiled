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

		internal int _003CSetEverythingUp_003Eb__42_0(WinningPlayerData b)
		{
			return 0;
		}

		internal bool _003CSetEverythingUp_003Eb__42_1(WinningPlayerData h)
		{
			return false;
		}

		internal bool _003CSetEverythingUp_003Eb__42_2(WinningPlayerData w)
		{
			return false;
		}

		internal bool _003CSetEverythingUp_003Eb__42_3(WinningPlayerData w)
		{
			return false;
		}

		internal string _003CSetEverythingUp_003Eb__42_4(WinningPlayerData w)
		{
			return null;
		}

		internal bool _003CSetEverythingUp_003Eb__42_5(WinningPlayerData w)
		{
			return false;
		}

		internal bool _003CSetEverythingUp_003Eb__42_6(WinningPlayerData h)
		{
			return false;
		}

		internal bool _003CSetEverythingUp_003Eb__42_7(WinningPlayerData h)
		{
			return false;
		}

		internal bool _003CSetUpRunnerEndScreen_003Eb__46_0(WinningPlayerData w)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public EndGameManager _003C_003E4__this;

		public int delta;

		internal void _003CWireRunnerPageButton_003Eb__0()
		{
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBegin_003Ed__71(int _003C_003E1__state)
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

	private sealed class _003CCoHoldRunnerPlacementText_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndGameManager _003C_003E4__this;

		public string placeText;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoHoldRunnerPlacementText_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CCoJoinGame_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoJoinGame_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003CWaitWithTimeout_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitWithTimeout_003Ed__76(int _003C_003E1__state)
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
	}

	private void ShowButtons()
	{
	}

	private void StartGlitch(float intensity)
	{
	}

	private void SetEverythingUp()
	{
	}

	private static string RunnerPlaceText(StringNames key, string englishFallback, int place)
	{
		return null;
	}

	private void FitLabelFont(TMP_Text label)
	{
	}

	private void FitWinLabels()
	{
	}

	private void SetUpRunnerEndScreen()
	{
	}

	private void SetUpRunnerNextButton()
	{
	}

	private IEnumerator CoHoldRunnerPlacementText(string placeText)
	{
		return null;
	}

	private GameObject FindSceneNextButton()
	{
		return null;
	}

	private GameObject FindSceneChild(string childName)
	{
		return null;
	}

	private void Update()
	{
	}

	private int RunnerNavUnder(Vector2 wp)
	{
		return 0;
	}

	private static bool RunnerButtonHit(GameObject button, Vector2 wp)
	{
		return false;
	}

	public void OnRunnerContinueClicked()
	{
	}

	private void ShowRunnerLeaderboard()
	{
	}

	private void RenderRunnerPage()
	{
	}

	public void StepRunnerPage(int delta)
	{
	}

	private static string CleanRunnerName(string stored)
	{
		return null;
	}

	private Color RunnerMedalColor(int place)
	{
		return default(Color);
	}

	private void EnsureRunnerPageNav(Transform leaderboard)
	{
	}

	private static void ActivateRunnerNav(Transform t, Transform stopAt)
	{
	}

	private Transform BuildRunnerNavButton(Transform page, string name, string label, float x, Transform rowTemplate, Transform boxTemplate)
	{
		return null;
	}

	private Transform BuildRunnerNavLabel(Transform parent, string name, string label, float x, Transform rowTemplate)
	{
		return null;
	}

	private static void EnsureRunnerNavCollider(GameObject go)
	{
	}

	private void WireRunnerPageButton(Transform btn, int delta)
	{
	}

	private void SetRunnerNavUsable(GameObject btn, bool usable)
	{
	}

	private static Transform FindRunnerChild(Transform root, string name)
	{
		return null;
	}

	private void StopRunnerEndMusic()
	{
	}

	public void SetWinnerPlayers(List<WinningPlayerData> list)
	{
	}

	private void GetStingerVol(AudioSource source, float dt)
	{
	}

	public IEnumerator CoBegin()
	{
		return null;
	}

	public void NextGame()
	{
	}

	public IEnumerator CoJoinGame()
	{
		return null;
	}

	public void Exit()
	{
	}

	public static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		return null;
	}
}
