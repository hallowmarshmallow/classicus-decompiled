using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using InnerNet;
using UnityEngine;

public class MeetingHud : InnerNetObject, IDisconnectHandler
{
	public enum VoteStates
	{
		Discussion,
		NotVoted,
		Voted,
		Results,
		Proceeding
	}

	private enum RpcCalls
	{
		Close,
		VotingComplete,
		CastVote,
		ClearVote
	}

	public struct VoterState
	{
		public byte VoterId;

		public byte VotedForId;

		public bool SkippedVote
		{
			get
			{
				throw null;
			}
		}

		public void Serialize(MessageWriter writer)
		{
			throw null;
		}

		public static VoterState Deserialize(MessageReader reader)
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ShipRoom, bool> _003C_003E9__49_0;

		public static Func<PlayerVoteArea, bool> _003C_003E9__94_0;

		public static Func<byte, int> _003C_003E9__94_1;

		public static Func<PlayerVoteArea, int> _003C_003E9__106_0;

		public static Func<PlayerVoteArea, byte> _003C_003E9__106_1;

		public static Func<PlayerVoteArea, bool> _003C_003E9__109_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CStart_003Eb__49_0(ShipRoom r)
		{
			throw null;
		}

		internal bool _003CCheckForEndVoting_003Eb__94_0(PlayerVoteArea ps)
		{
			throw null;
		}

		internal int _003CCheckForEndVoting_003Eb__94_1(byte v)
		{
			throw null;
		}

		internal int _003CSortButtons_003Eb__106_0(PlayerVoteArea p)
		{
			throw null;
		}

		internal byte _003CSortButtons_003Eb__106_1(PlayerVoteArea p)
		{
			throw null;
		}

		internal bool _003CGetVotesRemaining_003Eb__109_0(PlayerVoteArea ps)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public byte playerId;

		public _003C_003Ec__DisplayClass108_0()
		{
			throw null;
		}

		internal bool _003CDidVote_003Eb__0(PlayerVoteArea p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public PlayerControl pc;

		public _003C_003Ec__DisplayClass89_0()
		{
			throw null;
		}

		internal bool _003CHandleDisconnect_003Eb__0(PlayerVoteArea pv)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public byte srcPlayerId;

		public _003C_003Ec__DisplayClass92_0()
		{
			throw null;
		}

		internal bool _003CCastVote_003Eb__0(PlayerVoteArea pv)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public int maxIdx;

		public _003C_003Ec__DisplayClass94_0()
		{
			throw null;
		}

		internal bool _003CCheckForEndVoting_003Eb__2(GameData.PlayerInfo p)
		{
			throw null;
		}
	}

	private sealed class _003CCoIntro_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingHud _003C_003E4__this;

		public GameData.PlayerInfo targetPlayer;

		public GameData.PlayerInfo reporter;

		private Vector3 _003Ctemp_003E5__2;

		private float _003Ctimer_003E5__3;

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

		public _003CCoIntro_003Ed__68(int _003C_003E1__state)
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

	private sealed class _003CCoStartCutscene_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingHud _003C_003E4__this;

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

		public _003CCoStartCutscene_003Ed__69(int _003C_003E1__state)
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

	private const float ResultsTime = 5f;

	private const float Depth = -100f;

	private const float ButtonDepthStep = -0.2f;

	public static MeetingHud Instance;

	public OverlayKillAnimation MeetingAnimation;

	public Transform ButtonParent;

	public TextRenderer TitleText;

	public Vector3 VoteOrigin;

	public Vector3 VoteButtonOffsets;

	private Vector3 CounterOrigin;

	private Vector3 CounterOffsets;

	public PlayerVoteArea SkipVoteButton;

	private PlayerVoteArea[] playerStates;

	public PlayerVoteArea PlayerButtonPrefab;

	public SpriteRenderer PlayerVotePrefab;

	public SpriteRenderer VoteBackground;

	public SpriteRenderer MiddleButton;

	public Sprite CrackedGlass;

	public SpriteRenderer Glass;

	public PassiveButton ProceedButton;

	public AudioClip VoteSound;

	public AudioClip VoteLockinSound;

	public AudioClip VoteEndingSound;

	private VoteStates state;

	public GameObject SkippedVoting;

	public SpriteRenderer HostIcon;

	public Sprite KillBackground;

	private GameData.PlayerInfo exiledPlayer;

	private bool wasTie;

	public TextRenderer TimerText;

	public float discussionTimer;

	public PassiveButton VoteMeButton;

	private byte reporterId;

	private bool amDead;

	private float resultsStartedAt;

	private int lastSecond;

	private static int currentPage;

	public GameObject LeftArrow;

	public GameObject RightArrow;

	private const sbyte VoteNone = -2;

	private const byte VoteSkip = 253;

	private const int MaxSaneDiscussionTime = 120;

	private const int MaxSaneVotingTime = 300;

	private const int FallbackDiscussionTime = 15;

	private const int FallbackVotingTime = 120;

	private bool _loggedInsaneTimings;

	private PlayerVoteArea[] aliveFirstOrder;

	private PlayerVoteArea[] aliveFirstSource;

	private ulong aliveFirstSignature;

	private bool aliveFirstValid;

	private bool cutsceneHandedOff;

	private bool chatDockedToMeeting;

	private static readonly Vector2 MeetingChatButtonOffset;

	private const float MeetingBanButtonX = -0.3f;

	private Transform nudgedChatButton;

	private Vector3 nudgedChatButtonHome;

	private Transform nudgedBanButton;

	private Vector3 nudgedBanButtonHome;

	private static int maxPages
	{
		get
		{
			throw null;
		}
	}

	private static int SaneDiscussionTime
	{
		get
		{
			throw null;
		}
	}

	private static int SaneVotingTime
	{
		get
		{
			throw null;
		}
	}

	private void RefreshArrows()
	{
		throw null;
	}

	private void SetupVoteMeButton()
	{
		throw null;
	}

	public void OnVoteMeClicked()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void SetForegroundForDead()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private PlayerVoteArea[] GetAliveFirstOrder()
	{
		throw null;
	}

	public void AdvancePage()
	{
		throw null;
	}

	public void RecedePage()
	{
		throw null;
	}

	public IEnumerator CoIntro(GameData.PlayerInfo reporter, GameData.PlayerInfo targetPlayer)
	{
		throw null;
	}

	private IEnumerator CoStartCutscene()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void ServerStart(byte reporter)
	{
		throw null;
	}

	public void Close()
	{
		throw null;
	}

	private void NudgeChatButtonForMeeting()
	{
		throw null;
	}

	private void RestoreChatButtonOffset()
	{
		throw null;
	}

	private static Transform FindDeepChild(Transform root, string name)
	{
		throw null;
	}

	private static bool ShouldDockChatToMeeting()
	{
		throw null;
	}

	private void UndockChatFromMeeting()
	{
		throw null;
	}

	private void VotingComplete(VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
		throw null;
	}

	public bool Select(int suspectStateIdx)
	{
		throw null;
	}

	public void Confirm(byte suspectStateIdx)
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

	private void ForceSkipAll()
	{
		throw null;
	}

	public void CastVote(byte srcPlayerId, byte suspectPlayerId)
	{
		throw null;
	}

	public void ClearVote()
	{
		throw null;
	}

	private void CheckForEndVoting()
	{
		throw null;
	}

	private byte[] CalculateVotes()
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	private void SetDirtyIndex(int index)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public void HandleProceed()
	{
		throw null;
	}

	public void ForceProceed()
	{
		throw null;
	}

	private void SetupProceedButton()
	{
		throw null;
	}

	private void PopulateResults(VoterState[] states)
	{
		throw null;
	}

	private void BloopAVoteIcon(GameData.PlayerInfo voterPlayer, int index, Transform parent)
	{
		throw null;
	}

	private void UpdateButtons()
	{
		throw null;
	}

	private void PopulateButtons(byte reporter)
	{
		throw null;
	}

	private void SortButtons()
	{
		throw null;
	}

	private PlayerVoteArea CreateButton(GameData.PlayerInfo playerInfo)
	{
		throw null;
	}

	public bool DidVote(byte playerId)
	{
		throw null;
	}

	public int GetVotesRemaining()
	{
		throw null;
	}

	public void RpcClose()
	{
		throw null;
	}

	public void CmdCastVote(byte playerId, byte suspectIdx)
	{
		throw null;
	}

	private void RpcVotingComplete(VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
		throw null;
	}

	private void RpcClearVote(int clientId)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public MeetingHud()
	{
		throw null;
	}

	static MeetingHud()
	{
		throw null;
	}
}
