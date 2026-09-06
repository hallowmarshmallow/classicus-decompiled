using UnityEngine;

public class OpenDoorConsole : MonoBehaviour, IUsable
{
	public float usableDisance;

	private OpenableDoor myDoor;

	private SpriteRenderer image;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void Awake()
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public void Use()
	{
	}
}
