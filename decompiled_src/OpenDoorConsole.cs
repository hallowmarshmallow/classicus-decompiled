using UnityEngine;

public class OpenDoorConsole : MonoBehaviour, IUsable
{
	public float usableDisance;

	private OpenableDoor myDoor;

	private SpriteRenderer image;

	public float UsableDistance
	{
		get
		{
			throw null;
		}
	}

	public float PercentCool
	{
		get
		{
			throw null;
		}
	}

	public void Awake()
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	public OpenDoorConsole()
	{
		throw null;
	}
}
