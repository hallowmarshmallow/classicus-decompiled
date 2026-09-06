using UnityEngine;

public class InfectedOverlay : MonoBehaviour
{
	public MapRoom[] rooms;

	private IActivatable doors;

	private DoorsSystemType doorSystem;

	private SabotageSystemType SabSystem;

	public bool CanUseDoors => false;

	private bool DoorsBlockSpecial => false;

	public bool CanUseSpecial => false;

	public void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
