using UnityEngine;

public class DoorConsole : MonoBehaviour, IUsable
{
	public Minigame MinigamePrefab;

	private OpenableDoor MyDoor;

	private SpriteRenderer Image;

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

	public DoorConsole()
	{
		throw null;
	}
}
