using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class SubmergedStatus : ShipStatus, IQualityElement, IDeathListener
{
	public GameObject SelectUpperOrLower;

	public ElevatorTransition[] AllElevators;

	public OverlayKillAnimation OxyDeath;

	public ShadowManager ShadowManager;

	public List<Camera> GlassCams;

	public AudioClip ReactorSabotageSound;

	public AudioClip OxySabotageSound;

	public override void Awake()
	{
	}

	public void ApplySettings(MUQualitySettings.QualityPreset preset)
	{
	}

	public override void OnDestroy()
	{
	}

	public void OnDeadBodyCreated(DeadBody body)
	{
	}

	public void RunSubCutscene()
	{
	}

	public override void SetupCustomStrings()
	{
	}

	public override void PostIntroCutscene()
	{
	}

	public override void PreBegin()
	{
	}

	public void GoToSpawnLocation(PlayerControl player, int numPlayers, bool upper)
	{
	}

	public override void PostExile(GameData.PlayerInfo exiled)
	{
	}

	public override void AddSystems()
	{
	}

	private void SetElevDoorStatus(int id, bool status)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
