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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003COpenMap_003Eb__53_0(MapBehaviour m)
		{
			throw null;
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

		public _003CCoFadeFullScreen_003Ed__79(int _003C_003E1__state)
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

	private sealed class _003CCoReactorFlash_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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

		public _003CCoReactorFlash_003Ed__80(int _003C_003E1__state)
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

		public _003CCoShowIntro_003Ed__81(int _003C_003E1__state)
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

	private sealed class _003CCoTaskComplete_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private float _003Ctime_003E5__2;

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

		public _003CCoTaskComplete_003Ed__50(int _003C_003E1__state)
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

	private sealed class _003CShowEmblem_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool shhh;

		public HudManager _003C_003E4__this;

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

		public _003CShowEmblem_003Ed__73(int _003C_003E1__state)
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

	public VentButton HiderVentButton
	{
		get
		{
			throw null;
		}
	}

	public Coroutine ReactorFlash
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public Coroutine OxyFlash
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	private bool WantHiderVentButton(bool hudActive)
	{
		throw null;
	}

	private static string HnSGhostLine()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void ShowTaskComplete()
	{
		throw null;
	}

	private IEnumerator CoTaskComplete()
	{
		throw null;
	}

	public void SetJoystickSize()
	{
		throw null;
	}

	public void SetTouchType(int touch)
	{
		throw null;
	}

	public void OpenMap()
	{
		throw null;
	}

	public void ShowMap(Action<MapBehaviour> mapAction)
	{
		throw null;
	}

	public void SetHudActive(bool isActive)
	{
		throw null;
	}

	public void SetHudActive(PlayerControl localPlayer, bool isActive)
	{
		throw null;
	}

	public void SetHudActiveForced(bool isActive)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void FitTaskTextFont()
	{
		throw null;
	}

	private void ApplyHnSTextLayout(HnSThemeSettings ts)
	{
		throw null;
	}

	private void RestoreHnSTextLayout()
	{
		throw null;
	}

	public IEnumerator ShowEmblem(bool shhh)
	{
		throw null;
	}

	public void StartReactorFlash()
	{
		throw null;
	}

	public void StartOxyFlash()
	{
		throw null;
	}

	public void ShowPopUp(string text)
	{
		throw null;
	}

	public void StopReactorFlash()
	{
		throw null;
	}

	public void StopOxyFlash()
	{
		throw null;
	}

	public IEnumerator CoFadeFullScreen(Color source, Color target, float duration = 0.2f, bool coverCosmetics = false)
	{
		throw null;
	}

	private IEnumerator CoReactorFlash()
	{
		throw null;
	}

	public IEnumerator CoShowIntro(List<PlayerControl> yourTeam)
	{
		throw null;
	}

	public void OpenMeetingRoom(PlayerControl reporter)
	{
		throw null;
	}

	public void OpenOptionsMenu()
	{
		throw null;
	}

	public HudManager()
	{
		throw null;
	}
}
