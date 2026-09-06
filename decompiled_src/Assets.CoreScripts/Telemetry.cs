using System;
using InnerNet;
using UnityEngine;

namespace Assets.CoreScripts;

public class Telemetry : DestroyableSingleton<Telemetry>
{
	private static readonly string[] ColorNames;

	private bool amHost;

	private bool gameStarted;

	private DateTime timeStarted;

	public void StartGame(bool isHost, int playerCount, int impostorCount, GameModes gameMode, uint timesImpostor, uint gamesPlayed, uint crewStreak, uint colorId)
	{
		throw null;
	}

	public void WriteMeetingStarted(bool isEmergency)
	{
		throw null;
	}

	public void WriteMeetingEnded(float duration)
	{
		throw null;
	}

	public void WriteMurder()
	{
		throw null;
	}

	public void WriteSabotageUsed(SystemTypes systemType)
	{
		throw null;
	}

	public void WriteUse(byte playerNum, TaskTypes taskType, Vector3 worldPos)
	{
		throw null;
	}

	public void WriteCompleteTask(byte playerNum, TaskTypes taskType)
	{
		throw null;
	}

	internal void WriteDisconnect(DisconnectReasons reason)
	{
		throw null;
	}

	public void EndGame(GameOverReason endReason)
	{
		throw null;
	}

	public void SendWho()
	{
		throw null;
	}

	public void SelectInfected(int colorId, uint hatId)
	{
		throw null;
	}

	public void WonGame(int colorId, string hatId)
	{
		throw null;
	}

	public Telemetry()
	{
		throw null;
	}

	static Telemetry()
	{
		throw null;
	}
}
