using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkThemeApplier : MonoBehaviour
{
	private sealed class _003CGameSessionRoutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DarkThemeApplier _003C_003E4__this;

		private MeetingHud _003ClastAppliedMeeting_003E5__2;

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

		public _003CGameSessionRoutine_003Ed__69(int _003C_003E1__state)
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

	private static DarkThemeApplier _003CInstance_003Ek__BackingField;

	private static DarkThemeConfig _config;

	private static Sprite _capturedMeetingClassicOrig;

	private static Sprite _capturedBaseGlassOrig;

	private static Sprite _capturedChatBubbleOrig;

	private static Sprite _capturedChatBaseOrig;

	private static Sprite _capturedChatPopupOrig;

	private static Color _capturedChatPopupText2Color;

	private static bool _chatPopupOriginsCaptured;

	private static Color _capturedTypingTextColor;

	private static bool _chatOriginsCaptured;

	private static readonly Dictionary<int, Sprite> _origBubbleSprites;

	private static readonly Dictionary<int, Color> _origBubbleColors;

	private const string ConfigResourcePath = "DarkThemeConfig";

	private const string GameScene = "OnlineGame";

	private const string TutorialScene = "Tutorial";

	private readonly List<ChatBubble> _bubbleScratch;

	private readonly List<PlayerVoteArea> _voteAreaScratch;

	public static DarkThemeApplier Instance
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

	public static Sprite S_BaseGlassGhost
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_MeetingClassicDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_BaseGlassDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBubbleDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBgDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_VotePlayerDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBaseDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_PlayerOptionsBgDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_TabInactiveDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_HatChipBgDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatPopupDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_RunnerRowDark
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_RunnerRowLight
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_MeetingClassicOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_BaseGlassOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBubbleOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBgOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_VotePlayerOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatBaseOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_PlayerOptionsBgOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_TabInactiveOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_HatChipBgOrig
	{
		get
		{
			throw null;
		}
	}

	public static Sprite S_ChatPopupOrig
	{
		get
		{
			throw null;
		}
	}

	private static void Bootstrap()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private IEnumerator GameSessionRoutine()
	{
		throw null;
	}

	private void PatchAllBubbles()
	{
		throw null;
	}

	internal void ApplyBubble(ChatBubble bubble, bool enabled)
	{
		throw null;
	}

	public void ApplyState(bool enabled)
	{
		throw null;
	}

	private void ApplyChatPopup(bool enabled)
	{
		throw null;
	}

	private void ApplyChatTypingArea(bool enabled)
	{
		throw null;
	}

	private void ApplyMeetingHub(MeetingHud meeting, bool enabled)
	{
		throw null;
	}

	private void ApplyPlayerButtons(bool enabled)
	{
		throw null;
	}

	public void ApplyPlayerOptionsMenu(bool enabled)
	{
		throw null;
	}

	public void ApplyTabInactiveSprites(bool enabled)
	{
		throw null;
	}

	public void ApplyHatChipBackgrounds(bool enabled)
	{
		throw null;
	}

	public static bool IsEnabled()
	{
		throw null;
	}

	private static bool IsGameScene()
	{
		throw null;
	}

	private static ChatController GetChat()
	{
		throw null;
	}

	private static Transform DeepFind(Transform parent, string childName)
	{
		throw null;
	}

	public DarkThemeApplier()
	{
		throw null;
	}

	static DarkThemeApplier()
	{
		throw null;
	}
}
