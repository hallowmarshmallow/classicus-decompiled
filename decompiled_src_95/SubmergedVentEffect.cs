using UnityEngine;

public class SubmergedVentEffect : MonoBehaviour
{
	public SpriteMask VentMask;

	public int sortingOrderOffset;

	public void OnPlayerEnteredVent(PlayerControl player)
	{
	}

	public void OnPlayerExitingVent(PlayerControl player)
	{
	}

	public static void ApplyVentZDepth(PlayerPhysics physics, PlayerControl player)
	{
	}
}
