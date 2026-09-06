using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatController : MonoBehaviour
{
	private sealed class _003CBounceDot_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBounceDot_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CCoClose_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private Vector3 _003Cscale_003E5__2;

		private float _003CtargetScale_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoClose_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003CCoOpen_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private Vector3 _003Cscale_003E5__2;

		private float _003CtargetScale_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoOpen_003Ed__32(int _003C_003E1__state)
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

	public ObjectPoolBehavior chatBubPool;

	public Transform TypingArea;

	public SpriteRenderer TextBubble;

	public TextBoxTMP TextArea;

	public TextRenderer CharCount;

	public int MaxChat;

	public Scroller scroller;

	public GameObject Content;

	public SpriteRenderer BackgroundImage;

	public SpriteRenderer ChatNotifyDot;

	public TextRenderer SendRateMessage;

	public Vector3 SourcePos;

	public Vector3 TargetPos;

	private const float MaxChatSendRate = 3f;

	private float TimeSinceLastMessage;

	public AudioClip MessageSound;

	public AudioClip WarningSound;

	private bool animating;

	private Coroutine notificationRoutine;

	public BanMenu BanButton;

	public GameObject EmojiButton;

	private Transform emojiMenu;

	private bool resolvedEmoji;

	public PassiveButton CloseHitbox;

	public bool IsOpen => false;

	public bool IsAnimating => false;

	private void Start()
	{
	}

	public void Toggle()
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void ForceClosed()
	{
	}

	public IEnumerator CoOpen()
	{
		return null;
	}

	public IEnumerator CoClose()
	{
		return null;
	}

	public void SetPosition(MeetingHud meeting)
	{
	}

	public void UpdateCharCount()
	{
	}

	private void Update()
	{
	}

	public void SendChat()
	{
	}

	private string GetTooFastMessage(int seconds)
	{
		return null;
	}

	public void AddChatNote(GameData.PlayerInfo srcPlayer, ChatNoteTypes noteType)
	{
	}

	public void AddChat(PlayerControl sourcePlayer, string chatText)
	{
	}

	public void AddChatWarning(string warningText)
	{
	}

	private void AlignAllBubbles()
	{
	}

	private IEnumerator BounceDot()
	{
		return null;
	}

	public void GiveFocus()
	{
	}

	private void DisableBanMenuImmediate()
	{
	}

	private void EnableBanMenuAfterOpen()
	{
	}

	private void ResolveEmojiObjects()
	{
	}

	private void DisableEmojiButtonImmediate()
	{
	}

	private void EnableEmojiButtonAfterOpen()
	{
	}

	private void _003CStart_003Eb__28_0()
	{
	}
}
