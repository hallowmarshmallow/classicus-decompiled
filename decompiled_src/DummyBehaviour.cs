using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBehaviour : MonoBehaviour
{
	private sealed class _003CDoVote_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DummyBehaviour _003C_003E4__this;

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

		public _003CDoVote_003Ed__10(int _003C_003E1__state)
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

	private PlayerControl myPlayer;

	private FloatRange voteTime;

	private bool voted;

	public int PlayerIdToVoteFor;

	public bool Hostile;

	private float _nextKillAttemptAt;

	private const float KillAttemptInterval = 1f;

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void UpdateHostile()
	{
		throw null;
	}

	private IEnumerator DoVote()
	{
		throw null;
	}

	public static void ForceAllDummiesVoteFor(byte targetPlayerId)
	{
		throw null;
	}

	public DummyBehaviour()
	{
		throw null;
	}
}
