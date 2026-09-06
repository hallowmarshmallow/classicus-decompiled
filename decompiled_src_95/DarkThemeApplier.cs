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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGameSessionRoutine_003Ed__69(int _003C_003E1__state)
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
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	public static Sprite S_BaseGlassGhost => null;

	public static Sprite S_MeetingClassicDark => null;

	public static Sprite S_BaseGlassDark => null;

	public static Sprite S_ChatBubbleDark => null;

	public static Sprite S_ChatBgDark => null;

	public static Sprite S_VotePlayerDark => null;

	public static Sprite S_ChatBaseDark => null;

	public static Sprite S_PlayerOptionsBgDark => null;

	public static Sprite S_TabInactiveDark => null;

	public static Sprite S_HatChipBgDark => null;

	public static Sprite S_ChatPopupDark => null;

	public static Sprite S_RunnerRowDark => null;

	public static Sprite S_RunnerRowLight => null;

	public static Sprite S_MeetingClassicOrig => null;

	public static Sprite S_BaseGlassOrig => null;

	public static Sprite S_ChatBubbleOrig => null;

	public static Sprite S_ChatBgOrig => null;

	public static Sprite S_VotePlayerOrig => null;

	public static Sprite S_ChatBaseOrig => null;

	public static Sprite S_PlayerOptionsBgOrig => null;

	public static Sprite S_TabInactiveOrig => null;

	public static Sprite S_HatChipBgOrig => null;

	public static Sprite S_ChatPopupOrig => null;

	private static void Bootstrap()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private IEnumerator GameSessionRoutine()
	{
		return null;
	}

	private void PatchAllBubbles()
	{
	}

	internal void ApplyBubble(ChatBubble bubble, bool enabled)
	{
	}

	public void ApplyState(bool enabled)
	{
	}

	private void ApplyChatPopup(bool enabled)
	{
	}

	private void ApplyChatTypingArea(bool enabled)
	{
	}

	private void ApplyMeetingHub(MeetingHud meeting, bool enabled)
	{
	}

	private void ApplyPlayerButtons(bool enabled)
	{
	}

	public void ApplyPlayerOptionsMenu(bool enabled)
	{
	}

	public void ApplyTabInactiveSprites(bool enabled)
	{
	}

	public void ApplyHatChipBackgrounds(bool enabled)
	{
	}

	public static bool IsEnabled()
	{
		return false;
	}

	private static bool IsGameScene()
	{
		return false;
	}

	private static ChatController GetChat()
	{
		return null;
	}

	private static Transform DeepFind(Transform parent, string childName)
	{
		return null;
	}
}
