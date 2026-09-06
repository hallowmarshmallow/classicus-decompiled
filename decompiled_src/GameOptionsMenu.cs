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
		throw null;
	}

	public void Setup()
	{
		throw null;
	}

	public void WireChildren()
	{
		throw null;
	}

	public void SetChildren()
	{
		throw null;
	}

	private void EnsureVentCooldownRow()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void RefreshChildren()
	{
		throw null;
	}

	public void ValueChanged(OptionBehaviour option)
	{
		throw null;
	}

	private static void SetRowInteractable(OptionBehaviour option, bool interactable)
	{
		throw null;
	}

	private static void ApplyRunnerLockedDefaults(GameOptionsData o)
	{
		throw null;
	}

	private static bool IsRunnerDisabledMap(byte mapId)
	{
		throw null;
	}

	private static byte FindRunnerAllowedMapId()
	{
		throw null;
	}

	public GameOptionsMenu()
	{
		throw null;
	}

	static GameOptionsMenu()
	{
		throw null;
	}
}
