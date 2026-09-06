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

	public static float CooldownRemaining => 0f;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public static void StartLocalCooldown()
	{
	}

	public static void ClearLocalCooldown()
	{
	}

	private void Start()
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
