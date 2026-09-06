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

		internal bool _003CUpdate_003Eb__5_0(SpriteRenderer v)
		{
			return false;
		}
	}

	public List<SpriteRenderer> Votes;

	public FloatRange VoteRange;

	public int maxVotesBeforeSmoosh;

	public float CounterY;

	public bool ResultsShowing;

	private void Update()
	{
	}

	public void AddVote(SpriteRenderer newVote)
	{
	}

	public void LockResults()
	{
	}
}
