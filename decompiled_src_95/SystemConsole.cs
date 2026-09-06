using UnityEngine;

public class SystemConsole : MonoBehaviour, IUsable
{
	public float usableDistance;

	public bool FreeplayOnly;

	public SpriteRenderer Image;

	public Minigame MinigamePrefab;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void Start()
	{
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void Use()
	{
	}
}
