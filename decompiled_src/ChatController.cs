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

		public _003CBounceDot_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CCoClose_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private Vector3 _003Cscale_003E5__2;

		private float _003CtargetScale_003E5__3;

		private float _003Ctimer_003E5__4;

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

		public _003CCoClose_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003CCoOpen_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private Vector3 _003Cscale_003E5__2;

		private float _003CtargetScale_003E5__3;

		private float _003Ctimer_003E5__4;

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

		public _003CCoOpen_003Ed__32(int _003C_003E1__state)
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

	public bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	public bool IsAnimating
	{
		get
		{
			throw null;
		}
	}

	private void Start()
	{
		throw null;
	}

	public void Toggle()
	{
		throw null;
	}

	public void SetVisible(bool visible)
	{
		throw null;
	}

	public void ForceClosed()
	{
		throw null;
	}

	public IEnumerator CoOpen()
	{
		throw null;
	}

	public IEnumerator CoClose()
	{
		throw null;
	}

	public void SetPosition(MeetingHud meeting)
	{
		throw null;
	}

	public void UpdateCharCount()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void SendChat()
	{
		throw null;
	}

	private string GetTooFastMessage(int seconds)
	{
		throw null;
	}

	public void AddChatNote(GameData.PlayerInfo srcPlayer, ChatNoteTypes noteType)
	{
		throw null;
	}

	public void AddChat(PlayerControl sourcePlayer, string chatText)
	{
		throw null;
	}

	public void AddChatWarning(string warningText)
	{
		throw null;
	}

	private void AlignAllBubbles()
	{
		throw null;
	}

	private IEnumerator BounceDot()
	{
		throw null;
	}

	public void GiveFocus()
	{
		throw null;
	}

	private void DisableBanMenuImmediate()
	{
		throw null;
	}

	private void EnableBanMenuAfterOpen()
	{
		throw null;
	}

	private void ResolveEmojiObjects()
	{
		throw null;
	}

	private void DisableEmojiButtonImmediate()
	{
		throw null;
	}

	private void EnableEmojiButtonAfterOpen()
	{
		throw null;
	}

	public ChatController()
	{
		throw null;
	}

	private void _003CStart_003Eb__28_0()
	{
		throw null;
	}
}
