using System;
using System.Collections.Generic;
using UnityEngine;

public class VoteSpreader : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SpriteRenderer, bool> _003C_003E9__5_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__5_0(SpriteRenderer v)
		{
			throw null;
		}
	}

	public List<SpriteRenderer> Votes;

	public FloatRange VoteRange;

	public int maxVotesBeforeSmoosh;

	public float CounterY;

	public bool ResultsShowing;

	private void Update()
	{
		throw null;
	}

	public void AddVote(SpriteRenderer newVote)
	{
		throw null;
	}

	public void LockResults()
	{
		throw null;
	}

	public VoteSpreader()
	{
		throw null;
	}
}
