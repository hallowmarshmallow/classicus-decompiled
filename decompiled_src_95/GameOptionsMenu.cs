using System.Collections.Generic;
using UnityEngine;

public class GameOptionsMenu : MonoBehaviour
{
	private GameOptionsData cachedData;

	private OptionBehaviour[] Children;

	private bool _pendingRoleRebuild;

	public static List<StringNames> IntegerGameOptions;

	private int lastSetupFrame;

	private static readonly string[] RunnerDisabledMapNames;

	public void OnEnable()
	{
	}

	public void Setup()
	{
	}

	public void WireChildren()
	{
	}

	public void SetChildren()
	{
	}

	private void EnsureVentCooldownRow()
	{
	}

	public void Update()
	{
	}

	public void RefreshChildren()
	{
	}

	public void ValueChanged(OptionBehaviour option)
	{
	}

	private static void SetRowInteractable(OptionBehaviour option, bool interactable)
	{
	}

	private static void ApplyRunnerLockedDefaults(GameOptionsData o)
	{
	}

	private static bool IsRunnerDisabledMap(byte mapId)
	{
		return false;
	}

	private static byte FindRunnerAllowedMapId()
	{
		return 0;
	}
}
