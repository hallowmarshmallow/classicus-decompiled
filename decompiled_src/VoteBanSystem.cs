using System.Collections.Generic;
using Hazel;
using InnerNet;

public class VoteBanSystem : InnerNetObject
{
	public static VoteBanSystem Instance;

	public Dictionary<int, int[]> Votes;

	public void Awake()
	{
		throw null;
	}

	public static int GetRequiredVotes()
	{
		throw null;
	}

	public void CmdAddVote(int clientId)
	{
		throw null;
	}

	private void AddVote(int srcClient, int clientId)
	{
		throw null;
	}

	public bool HasMyVote(int clientId)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public VoteBanSystem()
	{
		throw null;
	}
}
