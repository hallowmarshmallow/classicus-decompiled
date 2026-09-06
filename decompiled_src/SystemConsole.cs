using UnityEngine;

public class SystemConsole : MonoBehaviour, IUsable
{
	public float usableDistance;

	public bool FreeplayOnly;

	public SpriteRenderer Image;

	public Minigame MinigamePrefab;

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

	public void Start()
	{
		throw null;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	public SystemConsole()
	{
		throw null;
	}
}
