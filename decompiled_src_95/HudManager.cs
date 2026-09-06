using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using KlassicHideNSeek;
using TMPro;
using UnityEngine;

public class HudManager : DestroyableSingleton<HudManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__53_0;

		internal void _003COpenMap_003Eb__53_0(MapBehaviour m)
		{
		}
	}

	private sealed class _003CCoFadeFullScreen_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		public Color target;

		public bool coverCosmetics;

		public Color source;

		public float duration;

		private string _003ClayerBefore_003E5__2;

		private int _003CorderBefore_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFadeFullScreen_003Ed__79(int _003C_003E1__state)
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

	private sealed class _003CCoReactorFlash_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoReactorFlash_003Ed__80(int _003C_003E1__state)
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

	private sealed class _003CCoShowIntro_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		public List<PlayerControl> yourTeam;

		private IEnumerator _003CemblemRoutine_003E5__2;

		private bool _003ChnsSeekerLock_003E5__3;

		private IEnumerator _003CintroRoutine_003E5__4;

		private float _003CseekerPickerTimeout_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowIntro_003Ed__81(int _003C_003E1__state)
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

	private sealed class _003CCoTaskComplete_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoTaskComplete_003Ed__50(int _003C_003E1__state)
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

	private sealed class _003CShowEmblem_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool shhh;

		public HudManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowEmblem_003Ed__73(int _003C_003E1__state)
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

	public Camera UICamera;

	public MeetingHud MeetingPrefab;

	public KillButtonManager KillButton;

	public UseButtonManager UseButton;

	private VentButton _hiderVentButton;

	private bool _hiderVentButtonSearched;

	public CrewKillButtonManager CrewKillButton;

	public ReportButtonManager ReportButton;

	public GameObject GameSettings;

	public TextMeshPro GameSettingsTMP;

	public GameObject TaskStuff;

	public ChatController Chat;

	public DialogueBox Dialogue;

	public ReportUserBox ReportUI;

	public ChatPopupController ChatPopup;

	public TextRenderer TaskText;

	public Transform TaskCompleteOverlay;

	private float taskDirtyTimer;

	private bool _hnsEmptyTaskWarned;

	public MeshRenderer ShadowQuad;

	public SpriteRenderer FullScreen;

	public SpriteRenderer MapButton;

	public KillOverlay KillOverlay;

	public IVirtualJoystick joystick;

	public MonoBehaviour[] Joysticks;

	public DiscussBehaviour discussEmblem;

	public ShhhBehaviour shhhEmblem;

	public IntroCutscene IntroPrefab;

	public NotificationPopper Notifier;

	public RoomTracker roomTracker;

	public AudioClip SabotageSound;

	public AudioClip TaskCompleteSound;

	public AudioClip TaskUpdateSound;

	private StringBuilder tasksString;

	private Coroutine _003CReactorFlash_003Ek__BackingField;

	private Coroutine _003COxyFlash_003Ek__BackingField;

	private DestroyableSkeldMeetingButton cachedMeetingButton;

	private HnSTaskBarFx cachedTaskBar;

	private bool _lastHudActive;

	private TMP_FontAsset _taskTextBaseFont;

	private string _taskTextFitted;

	private bool _hnsTextLayoutCaptured;

	private TextAlignmentOptions _origTextAlignment;

	private float _origCharacterSpacing;

	private float _origWordSpacing;

	private float _origLineSpacing;

	private float _origParagraphSpacing;

	public VentButton HiderVentButton => null;

	public Coroutine ReactorFlash
	{
		get
		{
			return _003CReactorFlash_003Ek__BackingField;
		}
		set
		{
			_003CReactorFlash_003Ek__BackingField = value;
		}
	}

	public Coroutine OxyFlash
	{
		get
		{
			return _003COxyFlash_003Ek__BackingField;
		}
		set
		{
			_003COxyFlash_003Ek__BackingField = value;
		}
	}

	private bool WantHiderVentButton(bool hudActive)
	{
		return false;
	}

	private static string HnSGhostLine()
	{
		return null;
	}

	public void Start()
	{
	}

	public void ShowTaskComplete()
	{
	}

	private IEnumerator CoTaskComplete()
	{
		return null;
	}

	public void SetJoystickSize()
	{
	}

	public void SetTouchType(int touch)
	{
	}

	public void OpenMap()
	{
	}

	public void ShowMap(Action<MapBehaviour> mapAction)
	{
	}

	public void SetHudActive(bool isActive)
	{
	}

	public void SetHudActive(PlayerControl localPlayer, bool isActive)
	{
	}

	public void SetHudActiveForced(bool isActive)
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void FitTaskTextFont()
	{
	}

	private void ApplyHnSTextLayout(HnSThemeSettings ts)
	{
	}

	private void RestoreHnSTextLayout()
	{
	}

	public IEnumerator ShowEmblem(bool shhh)
	{
		return null;
	}

	public void StartReactorFlash()
	{
	}

	public void StartOxyFlash()
	{
	}

	public void ShowPopUp(string text)
	{
	}

	public void StopReactorFlash()
	{
	}

	public void StopOxyFlash()
	{
	}

	public IEnumerator CoFadeFullScreen(Color source, Color target, float duration = 0.2f, bool coverCosmetics = false)
	{
		return null;
	}

	private IEnumerator CoReactorFlash()
	{
		return null;
	}

	public IEnumerator CoShowIntro(List<PlayerControl> yourTeam)
	{
		return null;
	}

	public void OpenMeetingRoom(PlayerControl reporter)
	{
	}

	public void OpenOptionsMenu()
	{
	}
}
