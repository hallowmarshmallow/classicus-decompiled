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

		public _003CCoAnimateOverlay_003Ed__38(int _003C_003E1__state)
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

	public bool DidVote
	{
		get
		{
			throw null;
		}
	}

	public MeetingHud Parent
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

	public void SetupAll()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void SetDead(bool isMe, bool didReport, bool isDead)
	{
		throw null;
	}

	public void SetDisabled()
	{
		throw null;
	}

	public void SetEnabled()
	{
		throw null;
	}

	public IEnumerator CoAnimateOverlay()
	{
		throw null;
	}

	private static float TriangleWave(float t)
	{
		throw null;
	}

	internal void SetVote(byte suspectIdx)
	{
		throw null;
	}

	public void UnsetVote()
	{
		throw null;
	}

	public void ClearButtons()
	{
		throw null;
	}

	public void ClearForResults()
	{
		throw null;
	}

	public void VoteForMe()
	{
		throw null;
	}

	public void Select()
	{
		throw null;
	}

	public void Cancel()
	{
		throw null;
	}

	public void Serialize(MessageWriter writer)
	{
		throw null;
	}

	public void Deserialize(MessageReader reader)
	{
		throw null;
	}

	public static byte GetVotedFor(byte state)
	{
		throw null;
	}

	public byte GetState()
	{
		throw null;
	}

	private void UpdateVoiceVisualizer()
	{
		throw null;
	}

	private void EnsureVoiceVisualizer()
	{
		throw null;
	}

	private bool TryGetTargetNetId(out uint netId)
	{
		throw null;
	}

	public PlayerVoteArea()
	{
		throw null;
	}
}
