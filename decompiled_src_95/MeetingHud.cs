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

		public bool SkippedVote => false;

		public void Serialize(MessageWriter writer)
		{
		}

		public static VoterState Deserialize(MessageReader reader)
		{
			return default(VoterState);
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

		internal bool _003CStart_003Eb__49_0(ShipRoom r)
		{
			return false;
		}

		internal bool _003CCheckForEndVoting_003Eb__94_0(PlayerVoteArea ps)
		{
			return false;
		}

		internal int _003CCheckForEndVoting_003Eb__94_1(byte v)
		{
			return 0;
		}

		internal int _003CSortButtons_003Eb__106_0(PlayerVoteArea p)
		{
			return 0;
		}

		internal byte _003CSortButtons_003Eb__106_1(PlayerVoteArea p)
		{
			return 0;
		}

		internal bool _003CGetVotesRemaining_003Eb__109_0(PlayerVoteArea ps)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public byte playerId;

		internal bool _003CDidVote_003Eb__0(PlayerVoteArea p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public PlayerControl pc;

		internal bool _003CHandleDisconnect_003Eb__0(PlayerVoteArea pv)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public byte srcPlayerId;

		internal bool _003CCastVote_003Eb__0(PlayerVoteArea pv)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public int maxIdx;

		internal bool _003CCheckForEndVoting_003Eb__2(GameData.PlayerInfo p)
		{
			return false;
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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoIntro_003Ed__68(int _003C_003E1__state)
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

	private sealed class _003CCoStartCutscene_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingHud _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartCutscene_003Ed__69(int _003C_003E1__state)
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

	private static int maxPages => 0;

	private static int SaneDiscussionTime => 0;

	private static int SaneVotingTime => 0;

	private void RefreshArrows()
	{
	}

	private void SetupVoteMeButton()
	{
	}

	public void OnVoteMeClicked()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetForegroundForDead()
	{
	}

	public void Update()
	{
	}

	private PlayerVoteArea[] GetAliveFirstOrder()
	{
		return null;
	}

	public void AdvancePage()
	{
	}

	public void RecedePage()
	{
	}

	public IEnumerator CoIntro(GameData.PlayerInfo reporter, GameData.PlayerInfo targetPlayer)
	{
		return null;
	}

	private IEnumerator CoStartCutscene()
	{
		return null;
	}

	public override void OnDestroy()
	{
	}

	public void ServerStart(byte reporter)
	{
	}

	public void Close()
	{
	}

	private void NudgeChatButtonForMeeting()
	{
	}

	private void RestoreChatButtonOffset()
	{
	}

	private static Transform FindDeepChild(Transform root, string name)
	{
		return null;
	}

	private static bool ShouldDockChatToMeeting()
	{
		return false;
	}

	private void UndockChatFromMeeting()
	{
	}

	private void VotingComplete(VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
	}

	public bool Select(int suspectStateIdx)
	{
		return false;
	}

	public void Confirm(byte suspectStateIdx)
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}

	private void ForceSkipAll()
	{
	}

	public void CastVote(byte srcPlayerId, byte suspectPlayerId)
	{
	}

	public void ClearVote()
	{
	}

	private void CheckForEndVoting()
	{
	}

	private byte[] CalculateVotes()
	{
		return null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	private void SetDirtyIndex(int index)
	{
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public void HandleProceed()
	{
	}

	public void ForceProceed()
	{
	}

	private void SetupProceedButton()
	{
	}

	private void PopulateResults(VoterState[] states)
	{
	}

	private void BloopAVoteIcon(GameData.PlayerInfo voterPlayer, int index, Transform parent)
	{
	}

	private void UpdateButtons()
	{
	}

	private void PopulateButtons(byte reporter)
	{
	}

	private void SortButtons()
	{
	}

	private PlayerVoteArea CreateButton(GameData.PlayerInfo playerInfo)
	{
		return null;
	}

	public bool DidVote(byte playerId)
	{
		return false;
	}

	public int GetVotesRemaining()
	{
		return 0;
	}

	public void RpcClose()
	{
	}

	public void CmdCastVote(byte playerId, byte suspectIdx)
	{
	}

	private void RpcVotingComplete(VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
	}

	private void RpcClearVote(int clientId)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
