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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoVote_003Ed__10(int _003C_003E1__state)
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

	private PlayerControl myPlayer;

	private FloatRange voteTime;

	private bool voted;

	public int PlayerIdToVoteFor;

	public bool Hostile;

	private float _nextKillAttemptAt;

	private const float KillAttemptInterval = 1f;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void UpdateHostile()
	{
	}

	private IEnumerator DoVote()
	{
		return null;
	}

	public static void ForceAllDummiesVoteFor(byte targetPlayerId)
	{
	}
}
