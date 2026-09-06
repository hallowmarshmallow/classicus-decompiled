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
		throw null;
	}

	public void ApplySettings(MUQualitySettings.QualityPreset preset)
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void OnDeadBodyCreated(DeadBody body)
	{
		throw null;
	}

	public void RunSubCutscene()
	{
		throw null;
	}

	public override void SetupCustomStrings()
	{
		throw null;
	}

	public override void PostIntroCutscene()
	{
		throw null;
	}

	public override void PreBegin()
	{
		throw null;
	}

	public void GoToSpawnLocation(PlayerControl player, int numPlayers, bool upper)
	{
		throw null;
	}

	public override void PostExile(GameData.PlayerInfo exiled)
	{
		throw null;
	}

	public override void AddSystems()
	{
		throw null;
	}

	private void SetElevDoorStatus(int id, bool status)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public SubmergedStatus()
	{
		throw null;
	}
}
