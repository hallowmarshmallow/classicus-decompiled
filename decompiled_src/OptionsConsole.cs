using UnityEngine;

public class OptionsConsole : MonoBehaviour, IUsable
{
	public CustomPlayerMenu MenuPrefab;

	public SpriteRenderer Outline;

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

	public OptionsConsole()
	{
		throw null;
	}
}
