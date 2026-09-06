using UnityEngine;

public class PlatformConsole : MonoBehaviour, IUsable
{
	public float usableDistance;

	public SpriteRenderer Image;

	public MovingPlatformBehaviour Platform;

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

	public PlatformConsole()
	{
		throw null;
	}
}
