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
	}

	public void WriteMeetingStarted(bool isEmergency)
	{
	}

	public void WriteMeetingEnded(float duration)
	{
	}

	public void WriteMurder()
	{
	}

	public void WriteSabotageUsed(SystemTypes systemType)
	{
	}

	public void WriteUse(byte playerNum, TaskTypes taskType, Vector3 worldPos)
	{
	}

	public void WriteCompleteTask(byte playerNum, TaskTypes taskType)
	{
	}

	internal void WriteDisconnect(DisconnectReasons reason)
	{
	}

	public void EndGame(GameOverReason endReason)
	{
	}

	public void SendWho()
	{
	}

	public void SelectInfected(int colorId, uint hatId)
	{
	}

	public void WonGame(int colorId, string hatId)
	{
	}
}
