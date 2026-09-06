using UnityEngine;

public class Console : MonoBehaviour, IUsable
{
	public float usableDistance;

	public int ConsoleId;

	public bool onlyFromBelow;

	public bool onlySameRoom;

	public bool GhostsIgnored;

	public bool AllowImpostor;

	public SystemTypes Room;

	public TaskTypes[] TaskTypes;

	public TaskSet[] ValidTasks;

	public SpriteRenderer Image;

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

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	private PlayerTask FindTask(PlayerControl pc)
	{
		throw null;
	}

	public virtual void Use()
	{
		throw null;
	}

	public Console()
	{
		throw null;
	}
}
