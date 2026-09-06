using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class PlayerVoteArea : MonoBehaviour
{
	private sealed class _003CCoAnimateOverlay_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerVoteArea _003C_003E4__this;

		private Transform _003CxMark_003E5__2;

		private float _003CfadeDuration_003E5__3;

		private float _003CscaleDuration_003E5__4;

		private float _003Ct_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOverlay_003Ed__38(int _003C_003E1__state)
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

	public byte TargetPlayerId;

	public const byte HasNotVoted = byte.MaxValue;

	public const byte MissedVote = 254;

	public const byte SkippedVote = 253;

	public const byte DeadVote = 252;

	public byte VotedFor;

	public GameObject Buttons;

	public SpriteRenderer PlayerIcon;

	public SpriteRenderer Flag;

	public SpriteRenderer Megaphone;

	public SpriteRenderer Overlay;

	public TextRenderer NameText;

	public VoiceFftVisualizer VoiceVisualizer;

	public SpriteRenderer VoiceVisualizerSquarePrefab;

	public Transform VoiceVisualizerArea;

	public Vector2 VoiceVisualizerOffset;

	public Vector2 VoiceVisualizerSize;

	public float VoiceVisualizerDepth;

	public float VoiceVisualizerMinRms;

	public PoolablePlayer player;

	public GameObject PlayerModel;

	public bool isDead;

	public bool didReport;

	public bool voteComplete;

	public bool resultsShowing;

	private MeetingHud _003CParent_003Ek__BackingField;

	private readonly float[] voiceSpectrumBands;

	public bool DidVote => false;

	public MeetingHud Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public void SetupAll()
	{
	}

	private void Update()
	{
	}

	public void SetDead(bool isMe, bool didReport, bool isDead)
	{
	}

	public void SetDisabled()
	{
	}

	public void SetEnabled()
	{
	}

	public IEnumerator CoAnimateOverlay()
	{
		return null;
	}

	private static float TriangleWave(float t)
	{
		return 0f;
	}

	internal void SetVote(byte suspectIdx)
	{
	}

	public void UnsetVote()
	{
	}

	public void ClearButtons()
	{
	}

	public void ClearForResults()
	{
	}

	public void VoteForMe()
	{
	}

	public void Select()
	{
	}

	public void Cancel()
	{
	}

	public void Serialize(MessageWriter writer)
	{
	}

	public void Deserialize(MessageReader reader)
	{
	}

	public static byte GetVotedFor(byte state)
	{
		return 0;
	}

	public byte GetState()
	{
		return 0;
	}

	private void UpdateVoiceVisualizer()
	{
	}

	private void EnsureVoiceVisualizer()
	{
	}

	private bool TryGetTargetNetId(out uint netId)
	{
		netId = default(uint);
		return false;
	}
}
