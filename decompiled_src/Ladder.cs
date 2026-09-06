using UnityEngine;

public class Ladder : MonoBehaviour, IUsable
{
	public const float CooldownDuration = 5f;

	private static float localCooldownUntil;

	public byte Id;

	public SpriteRenderer SpotArea;

	public bool IsTop;

	public Ladder Destination;

	public AudioClip UseSound;

	public SpriteRenderer Image;

	public static float CooldownRemaining
	{
		get
		{
			throw null;
		}
	}

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

	public static void StartLocalCooldown()
	{
		throw null;
	}

	public static void ClearLocalCooldown()
	{
		throw null;
	}

	private void Start()
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

	public Ladder()
	{
		throw null;
	}
}
