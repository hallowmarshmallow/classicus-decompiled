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

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	public virtual void Use()
	{
	}
}
